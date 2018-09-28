using System;
using System.Collections;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Gif.Components;
using PluginInterface;

namespace BitmapPlugin{
    public class BitmapPlugin : IPlugin{
        string myName = "Bitmap Plugin";
        string myDescription = "Plugin to manage Bitmap copied in the clipboard";
        string myAuthor = "Francesco Ielpi";
        string myVersion = "1.0.0";

        Object thisLock = new Object();

        int myID;
        int fileNum = 0;
        int anigifFrameNum = 0;
        int anigifTotalFrameNum = 0;

        bool hasIcon = true;
        bool isAboutFormPresent = false;
        bool isOptionsFormPresent = true;

        ArrayList myFormats = new ArrayList();
        NameValueCollection myOptions = new NameValueCollection();
        AnimatedGifEncoder aniGifEnc = new AnimatedGifEncoder();

        IPluginHost myHost = null;

        public BitmapPlugin(){
            myFormats.Add(DataFormats.Bitmap);
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
                optForm.FormatSettings = myOptions;

                return optForm;
            }
        }

        public Image PlugImage {
            get { return Properties.Resources.bitmap; }
        }

        public void Init(){
            if (myOptions["AniGIFTrasparent"] == null)
                myOptions.Add("AniGIFTrasparent", "NULL");

            if (myOptions["AniGIFQuality"] == null)
                myOptions.Add("AniGIFQuality", "10");

            if (myOptions["AniGIFFrameRate"] == null)
                myOptions.Add("AniGIFFrameRate", "25");

            if (myOptions["AniGIFRepeat"] == null)
                myOptions.Add("AniGIFRepeat", "0");

            if (myOptions["AniGIFNumFrames"] == null)
                myOptions.Add("AniGIFNumFrames", "5");

            if (myOptions["JPEGQuality"] == null)
                myOptions.Add("JPEGQuality", "80");

            if (myOptions["JPEGEncoding"] == null)
                myOptions.Add("JPEGEncoding", "false");

            if (myOptions["PNGEncoding"] == null)
                myOptions.Add("PNGEncoding", "false");

            if (myOptions["TIFFCompression"] == null)
                myOptions.Add("TIFFCompression", "0");

            if (myOptions["SelectedFormat"] == null)
                myOptions.Add("SelectedFormat", "2");

            if (myOptions["OutputDir"] == null)
                myOptions.Add("OutputDir", Application.StartupPath);

            if (myOptions["PrefixOutputName"] == null)
                myOptions.Add("PrefixOutputName", "");

            if (myOptions["SuffixOutputName"] == null)
                myOptions.Add("SuffixOutputName", "");
        }

        public void Execute(object data){
            try {
                lock (thisLock) {
                    Bitmap clipImage = (Bitmap)data;

                    ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

                    string strCodecToUse = null;
                    ImageCodecInfo codecToUse = null;
                    EncoderParameters encParams = null;

                    switch (int.Parse(myOptions["SelectedFormat"])) {
                        case 0:
                            anigifTotalFrameNum = int.Parse(myOptions["AniGIFNumFrames"]);
                            strCodecToUse = "AniGIF";

                            break;
                        case 1:
                            strCodecToUse = "BMP";

                            break;
                        case 2:
                            encParams = new EncoderParameters(2);

                            encParams.Param[0] = new EncoderParameter(Encoder.Quality, long.Parse(myOptions["JPEGQuality"]));

                            if (bool.Parse(myOptions["JPEGEncoding"]))
                                encParams.Param[1] = new EncoderParameter(Encoder.RenderMethod, (long)EncoderValue.RenderProgressive);
                            else
                                encParams.Param[1] = new EncoderParameter(Encoder.RenderMethod, (long)EncoderValue.RenderNonProgressive);

                            strCodecToUse = "JPEG";

                            break;
                        case 3:
                            strCodecToUse = "GIF";

                            break;
                        case 4:
                            switch (int.Parse(myOptions["TIFFCompression"])) {
                                case 0:
                                    encParams = new EncoderParameters(1);

                                    encParams.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionNone);
                                    break;
                                case 1:
                                    encParams = new EncoderParameters(2);

                                    encParams.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionCCITT3);
                                    encParams.Param[1] = new EncoderParameter(Encoder.ColorDepth, 1L);
                                    break;
                                case 2:
                                    encParams = new EncoderParameters(2);

                                    encParams.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionCCITT4);
                                    encParams.Param[1] = new EncoderParameter(Encoder.ColorDepth, 1L);
                                    break;
                                case 3:
                                    encParams = new EncoderParameters(1);

                                    encParams.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionLZW);
                                    break;
                                case 4:
                                    encParams = new EncoderParameters(2);

                                    encParams.Param[0] = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionRle);
                                    encParams.Param[1] = new EncoderParameter(Encoder.ColorDepth, 1L);
                                    break;
                            }

                            strCodecToUse = "TIFF";

                            break;
                        case 5:
                            encParams = new EncoderParameters(1);

                            if (bool.Parse(myOptions["PNGEncoding"]))
                                encParams.Param[0] = new EncoderParameter(Encoder.ScanMethod, (long)EncoderValue.ScanMethodInterlaced);
                            else
                                encParams.Param[0] = new EncoderParameter(Encoder.ScanMethod, (long)EncoderValue.ScanMethodNonInterlaced);

                            strCodecToUse = "PNG";

                            break;
                    }

                    if (!strCodecToUse.Equals("AniGIF")) {
                        foreach (ImageCodecInfo codec in codecs) {
                            if (codec.FormatDescription.Equals(strCodecToUse)) {
                                codecToUse = codec;
                                break;
                            }
                        }

                        if (codecToUse != null) {
                            string filename = myOptions["PrefixOutputName"] + fileNum + myOptions["SuffixOutputName"] +
                                            (codecToUse.FilenameExtension.Split(new char[] { ';' }))[0].Substring(1);

                            clipImage.Save(filename, codecToUse, encParams);

                            fileNum++;
                        }
                    }
                    else {
                        if (!aniGifEnc.IsStarted) {
                            anigifFrameNum = 0;

                            aniGifEnc.Start(myOptions["PrefixOutputName"] + fileNum + myOptions["SuffixOutputName"] + ".gif");

                            aniGifEnc.SetFrameRate(float.Parse(myOptions["AniGIFFrameRate"]));
                            aniGifEnc.SetRepeat(int.Parse(myOptions["AniGIFRepeat"]));
                            aniGifEnc.SetQuality(int.Parse(myOptions["AniGIFQuality"]));

                            if (!myOptions["AniGIFTrasparent"].Equals("NULL"))
                                aniGifEnc.SetTransparent(Color.FromArgb(int.Parse(myOptions["AniGIFTrasparent"])));
                        }

                        aniGifEnc.AddFrame((Image)clipImage);
                        anigifFrameNum++;
                        MessageBox.Show("Frame " + anigifFrameNum.ToString() + " of " + anigifTotalFrameNum + " added.", "AniGIF Creation",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (anigifFrameNum >= anigifTotalFrameNum) {
                            aniGifEnc.Finish();
                            fileNum++;
                        }
                    }
                }
            }
            catch (System.Runtime.InteropServices.ExternalException ee) {
                MessageBox.Show("Error writing file.\n" + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fe) {
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Unload() { }
    }
}
