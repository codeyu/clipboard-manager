using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ClipboardManager {
	public class FileListManager {
		private Hashtable extensionList = new Hashtable();
        private Hashtable typeList = new Hashtable();
		private ArrayList imageLists = new ArrayList();
		
        private FileReader.IconSize iconSize;

        bool ManageBothSizes = false;

		public FileListManager(ImageList imageList, FileReader.IconSize iconSize) {
            imageLists.Add( imageList );
			this.iconSize = iconSize;
		}
		
		public FileListManager(ImageList smallImageList, ImageList largeImageList) {
			imageLists.Add( smallImageList );
			imageLists.Add( largeImageList );

			ManageBothSizes = true;
		}

        public int AddFileIcon(string filePath) {
			if (!File.Exists(filePath)) throw new FileNotFoundException("File does not exist");

            string extension;

            if (filePath.EndsWith(".exe")) 
                extension = filePath;
            else {
                string[] splitPath = filePath.Split(new Char[] { '.' });
                extension = (string)splitPath.GetValue(splitPath.GetUpperBound(0));
            }

			if (extensionList.ContainsKey(extension.ToUpper()))
				return (int)extensionList[extension.ToUpper()];
			else {
				int pos = ((ImageList)imageLists[0]).Images.Count;

				if (ManageBothSizes == true){
                    ((ImageList)imageLists[0]).Images.Add(FileReader.GetFileIcon(filePath, FileReader.IconSize.Small));
                    ((ImageList)imageLists[1]).Images.Add(FileReader.GetFileIcon(filePath, FileReader.IconSize.Large));
				} 
				else
                    ((ImageList)imageLists[0]).Images.Add(FileReader.GetFileIcon(filePath, iconSize));

                extensionList.Add(extension.ToUpper(), pos);

                return pos;
			}
		}

        public string AddFileType(string filePath) {
            if (!File.Exists(filePath)) throw new FileNotFoundException("File does not exist");

            string[] splitPath = filePath.Split(new Char[] { '.' });
            string extension = "." + (string)splitPath.GetValue(splitPath.GetUpperBound(0));

            if (typeList.ContainsKey(extension.ToUpper()))
                return (string)typeList[extension.ToUpper()];
            else{
                string fileType = FileReader.GetFileType(extension);

                typeList.Add(extension.ToUpper(), fileType);

                return fileType;
            }
        }
        
        public void ClearLists(){
			foreach (ImageList imageList in imageLists)
				imageList.Images.Clear();
			
			extensionList.Clear();
            typeList.Clear();
		}
	}
}
