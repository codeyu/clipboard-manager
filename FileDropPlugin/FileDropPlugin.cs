using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using PluginInterface;
using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Zip;

namespace FileDropPlugin{
    public enum PathStyle { Relative = 0, Full = 1, None = 2 };

    public class FileDropPlugin : IPlugin{
        string myName = "FileDrop Plugin";
        string myDescription = "Plugin to manage file copied in the clipboard";
        string myAuthor = "Francesco Ielpi";
        string myVersion = "1.0.0";
        string originalPath;
        string zipFileName;
        string baseDataPath;
        string zipPassword;
        string zipComment;
        string outputDir;
        string outputName;

        Object thisLock = new Object();

        int myID;
        int compressionLevel;
        int outputNameType;

        bool hasIcon = true;
        bool isAboutFormPresent = false;
        bool isOptionsFormPresent = true;
        bool deflateFiles;
        bool includeSubFolders;

        ArrayList myFormats = new ArrayList();
        NameValueCollection myOptions = new NameValueCollection();
        Crc32 crc;
        ZipOutputStream outStream;
        PathStyle pathStyle;

        IPluginHost myHost = null;

        public FileDropPlugin(){
            myFormats.Add(DataFormats.FileDrop);
        }

        public string PlugName{
            get { return myName; }
        }

        public string PlugDescription{
            get { return myDescription; }
        }

        public string PlugAuthor{
            get { return myAuthor; }
        }

        public string PlugVersion{
            get { return myVersion; }
        }

        public int PlugID{
            get { return myID; }
            set { myID = value; }
        }

        public bool HasIcon{
            get { return hasIcon; }
        }

        public bool IsAboutFormPresent{
            get { return isAboutFormPresent; }
        }

        public bool IsOptionsFormPresent{
            get { return isOptionsFormPresent; }
        }

        public ArrayList PlugFormats{
            get { return myFormats; }
        }

        public NameValueCollection PlugOptions{
            get { return myOptions; }
            set { myOptions = value; }
        }

        public IPluginHost Host{
            get { return myHost; }
            set { myHost = value; }
        }

        public Form AboutForm{
            get { return null; }
        }

        public Form OptionsForm{
            get {
                OptionsForm optForm = new OptionsForm(this);
                optForm.FileDropSettings = myOptions;

                return optForm;
            }
        }

        public Image PlugImage{
            get { return Properties.Resources.file; }
        }

        public void Init(){
            if (myOptions["PathStyle"] == null)
                myOptions.Add("PathStyle", PathStyle.Relative.ToString());

            if (myOptions["DeflateFiles"] == null)
                myOptions.Add("DeflateFiles", "True");

            if (myOptions["RecursiveSubDirectories"] == null)
                myOptions.Add("RecursiveSubDirectories", "True");

            if (myOptions["CompressionLevel"] == null)
                myOptions.Add("CompressionLevel", "5");

            if (myOptions["ZipComment"] == null)
                myOptions.Add("ZipComment", "");

            if (myOptions["ZipPassword"] == null)
                myOptions.Add("ZipPassword", "");

            if (myOptions["OutputDir"] == null)
                myOptions.Add("OutputDir", Application.StartupPath);

            if (myOptions["OutputNameType"] == null)
                myOptions.Add("OutputNameType", "0");

            if (myOptions["OutputName"] == null)
                myOptions.Add("OutputName", "");

            InitSettings();
        }

        public void Execute(object data){
            string[] files = (string[])data;
            string zipName = "";

            switch (outputNameType){
                case 0:
                    zipName = Path.GetFileNameWithoutExtension(files[0]);
                    break;

                case 1:
                    zipName = outputName;
                    break;
                
                default:
                    zipName = outputName;
                    break;
            }

            if (zipName == "")
                zipName = "NONAMESPECIFIED";

            try {
                ZipBuilder(outputDir + "\\" + zipName + ".zip", files);
            }
            catch (ZipException ze) {
                MessageBox.Show("Error processing zipfile.\n" + ze.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException fnfe) {
                MessageBox.Show("Error processing zipfile.\n" + fnfe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Unload() { }

        public void InitSettings(){
            try {
                switch (myOptions["PathStyle"]) {
                    case "None":
                        pathStyle = PathStyle.None;
                        break;

                    case "Relative":
                        pathStyle = PathStyle.Relative;
                        break;

                    case "Full":
                        pathStyle = PathStyle.Full;
                        break;

                    default:
                        pathStyle = PathStyle.Relative;
                        break;
                }

                deflateFiles = bool.Parse(myOptions["DeflateFiles"]);
                includeSubFolders = bool.Parse(myOptions["RecursiveSubDirectories"]);

                compressionLevel = int.Parse(myOptions["CompressionLevel"]);
                outputNameType = int.Parse(myOptions["OutputNameType"]);

                zipComment = myOptions["ZipComment"];
                zipPassword = myOptions["ZipPassword"];
                outputDir = myOptions["OutputDir"];
                outputName = myOptions["OutputName"];
            }
            catch (FormatException fe) {
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void ZipBuilder(string zipFileName, string[] zipDataPaths) {
            try {
                lock (thisLock) {
                    this.originalPath = Path.GetDirectoryName(zipFileName) + "\\";
                    this.zipFileName = Path.GetFileName(zipFileName);
                    this.baseDataPath = Path.GetDirectoryName(zipDataPaths[0]) + "\\";

                    outStream = new ZipOutputStream(File.Create(zipFileName));

                    if (zipPassword != string.Empty)
                        outStream.Password = zipPassword;
                    if (zipComment != string.Empty)
                        outStream.SetComment(zipComment);

                    outStream.SetLevel(compressionLevel);

                    crc = new Crc32();

                    foreach (string item in zipDataPaths) {
                        if (Directory.Exists(item))
                            buildZipFromPath(item, includeSubFolders);
                        else
                            addFileToZip(item);
                    }

                    outStream.Finish();
                    outStream.Close();
                }
            }
            catch (IOException ioe) {
                MessageBox.Show("Error processing zipfile.\n" + ioe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

        private void buildZipFromPath(string pathToZip, bool recurse) {
            foreach (string file in Directory.GetFiles(pathToZip))
                addFileToZip(file);

            if (recurse)
                foreach (string directory in Directory.GetDirectories(pathToZip))
                    buildZipFromPath(directory, true);
        }

        private void addFileToZip(string fileName) {
            string directory = (Path.GetDirectoryName(fileName) + "\\").Substring(baseDataPath.Length);
            string theFile = Path.GetFileName(fileName);

            if (fileName.ToUpper() != (originalPath + zipFileName).ToUpper()) {
                ZipEntry entry = null;
                
                if (pathStyle == PathStyle.Relative)
                    entry = new ZipEntry(directory + theFile);
                else if (pathStyle == PathStyle.Full)
                    entry = new ZipEntry(fileName.Substring(3));
                else if (pathStyle == PathStyle.None)
                    entry = new ZipEntry(theFile);

                bool compressedFileType = false;

                string fileType = fileName.ToUpper();
                if (fileType.EndsWith(".ZIP") || fileType.EndsWith(".RAR") || fileType.EndsWith(".GZ") || 
                    fileType.EndsWith(".LZH") || fileType.EndsWith(".PAK") || fileType.EndsWith(".CAB") ||
                    (new FileInfo(fileName)).Length < 48)

                    compressedFileType = true;
                
                if (deflateFiles && !compressedFileType)
                    entry.CompressionMethod = CompressionMethod.Deflated;
                else
                    entry.CompressionMethod = CompressionMethod.Stored;

                FileStream fs = File.OpenRead(fileName);

                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);

                entry.DateTime = DateTime.Now;
                entry.Size = fs.Length;
                fs.Close();
                
                crc.Reset();
                crc.Update(buffer);
                entry.Crc = crc.Value;
                
                outStream.PutNextEntry(entry);
                outStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
