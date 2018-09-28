using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ClipboardManager {
    public partial class ItemProperty : Form {
        public ItemProperty(ClipEntry clip) {
            InitializeComponent();

            clipTypePictureBox.Image = IconList.Images[(int)clip.MessageType];
            clipTypeLabel.Text = clip.MessageHeader;

            switch (clip.MessageType) { 
                case ClipEntryType.Rtf:
                    htmlTableLayoutPanel.Visible = false;
                    imageTableLayoutPanel.Visible = false;
                    filesTableLayoutPanel.Visible = false;

                    rtfTextTableLayoutPanel.Visible = true;

                    clipTextRichTextBox.Rtf = (string)clip.PluginData;
                    textLengthLabel.Text = "Length: " + clipTextRichTextBox.TextLength + " chars\nText's lines: " + 
                                           clipTextRichTextBox.Lines.Length;

                    break;

                case ClipEntryType.Text:
                    htmlTableLayoutPanel.Visible = false;
                    imageTableLayoutPanel.Visible = false;
                    filesTableLayoutPanel.Visible = false;

                    rtfTextTableLayoutPanel.Visible = true;

                    clipTextRichTextBox.Text = (string)clip.PluginData;
                    textLengthLabel.Text = "Length: " + clipTextRichTextBox.TextLength + " chars\nText's lines: " + 
                                           clipTextRichTextBox.Lines.Length;

                    break;

                case ClipEntryType.Html:
                    imageTableLayoutPanel.Visible = false;
                    filesTableLayoutPanel.Visible = false;
                    rtfTextTableLayoutPanel.Visible = false;

                    htmlTableLayoutPanel.Visible = true;

                    string documentText = (string)clip.PluginData;

                    int startHtml = documentText.IndexOf("StartHTML:") + 10;
                    int endHtml = documentText.IndexOf("\r\nEndHTML:");
                    int startFragment = documentText.IndexOf("\r\nStartFragment:");

                    int start = int.Parse(documentText.Substring(startHtml, endHtml - startHtml));
                    int end = int.Parse(documentText.Substring(endHtml + 12, startFragment - endHtml - 12));

                    webBrowser.DocumentText = documentText.Substring(start, end - start).Replace("?", "&nbsp");
                    htmlPropertyLabel.Text = "Length: " + clip.SecondaryPluginData.ToString().Length + 
                                             "\nEncoding: " + webBrowser.Document.Encoding;

                    break;

                case ClipEntryType.Bitmap:
                    htmlTableLayoutPanel.Visible = false;
                    rtfTextTableLayoutPanel.Visible = false;
                    filesTableLayoutPanel.Visible = false;

                    imageTableLayoutPanel.Visible = true;

                    Image img = (Image)clip.PluginData;
                    
                    clipImagePictureBox.BackgroundImage = img;
                    clipImagePropertyLabel.Text = "Size: " + img.Width + "x" + img.Height + 
                                                  "\nColor Depth: " + Image.GetPixelFormatSize(img.PixelFormat).ToString();

                    if ((clipImagePictureBox.Width > clipImagePictureBox.BackgroundImage.Width) &&
                        (clipImagePictureBox.Height > clipImagePictureBox.BackgroundImage.Height))

                        clipImagePictureBox.BackgroundImageLayout = ImageLayout.Center;
                    else
                        clipImagePictureBox.BackgroundImageLayout = ImageLayout.Zoom;

                    break;

                case ClipEntryType.FileDrop:
                    htmlTableLayoutPanel.Visible = false;
                    rtfTextTableLayoutPanel.Visible = false;
                    imageTableLayoutPanel.Visible = false;

                    filesTableLayoutPanel.Visible = true;

                    smallImageList.Images.Add(FileReader.GetFolderIcon(FileReader.IconSize.Small, FileReader.FolderType.Closed));
                    largeImageList.Images.Add(FileReader.GetFolderIcon(FileReader.IconSize.Large, FileReader.FolderType.Closed));
                    
                    FileListManager fileListManager = new FileListManager(smallImageList, largeImageList);

                    ArrayList dirs = new ArrayList();
                    ArrayList files = new ArrayList();

                    string[] paths = (string[])clip.PluginData;

                    foreach (string path in paths) {
                        if (Directory.Exists(path))
                            dirs.Add(path);
                        else if (File.Exists(path))
                            files.Add(path);
                    }

                    dirs.Sort();
                    files.Sort();

                    foreach (string dir in dirs){
                        int relativePath = Directory.GetParent(dir).FullName.Length;

                        clipFileListView.Items.Add(new ListViewItem(new string[] { dir.Substring(relativePath + 1), "", "Folder",
                                                                                   Directory.GetLastAccessTime(dir).ToString("g"),
                                                                                   Directory.GetLastWriteTime(dir).ToString("g") }, 0));
                    }

                    foreach (string file in files) {
                        string relativeFile = Path.GetFileName(file);

                        FileInfo fileInfo = new FileInfo(file);

                        string fileLastAccess = fileInfo.LastAccessTime.ToString("g");
                        string fileLastWrite = fileInfo.LastWriteTime.ToString("g");
                        string fileDimension = (fileInfo.Length / 1024).ToString();
                        string fileDimensionDotted = "";
                        int dot = 0;

                        for (int i = fileDimension.Length - 3; i > 0; i = i - 3) {
                            fileDimensionDotted = "." + fileDimension.Substring(i, 3) + fileDimensionDotted;
                            dot++;
                        }

                        fileDimensionDotted = fileDimension.Substring(0, fileDimension.Length - (dot * 3)) + fileDimensionDotted + " KB";

                        clipFileListView.Items.Add(new ListViewItem(new string[] { relativeFile, fileDimensionDotted, 
                                                                                   fileListManager.AddFileType(file), fileLastAccess,
                                                                                   fileLastWrite }, fileListManager.AddFileIcon(file)));
                    }
                    
                    clipFilesPropertyLabel.Text = "# Directory: " + dirs.Count + "\n# Files: " + files.Count;

                    break;
            }
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            largeIconsToolStripMenuItem.Checked = true;

            smallIconsToolStripMenuItem.Checked = false;
            listToolStripMenuItem.Checked = false;
            detailToolStripMenuItem.Checked = false;
            
            clipFileListView.View = View.LargeIcon;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            smallIconsToolStripMenuItem.Checked = true;

            largeIconsToolStripMenuItem.Checked = false;
            listToolStripMenuItem.Checked = false;
            detailToolStripMenuItem.Checked = false;

            clipFileListView.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e) {
            listToolStripMenuItem.Checked = true;

            largeIconsToolStripMenuItem.Checked = false;
            smallIconsToolStripMenuItem.Checked = false;
            detailToolStripMenuItem.Checked = false;

            clipFileListView.View = View.List;
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e) {
            detailToolStripMenuItem.Checked = true;

            largeIconsToolStripMenuItem.Checked = false;
            smallIconsToolStripMenuItem.Checked = false;
            listToolStripMenuItem.Checked = false;

            clipFileListView.View = View.Details;
        }

        private void ItemProperty_SizeChanged(object sender, EventArgs e) {
            if (imageTableLayoutPanel.Visible) {
                if ((clipImagePictureBox.Width > clipImagePictureBox.BackgroundImage.Width) &&
                    (clipImagePictureBox.Height > clipImagePictureBox.BackgroundImage.Height))

                    clipImagePictureBox.BackgroundImageLayout = ImageLayout.Center;
                else
                    clipImagePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }
    }
}