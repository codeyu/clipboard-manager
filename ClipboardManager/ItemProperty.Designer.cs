namespace ClipboardManager {
    partial class ItemProperty {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemProperty));
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.clipTypeLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.line2PictureBox = new System.Windows.Forms.PictureBox();
            this.clipTypePictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.htmlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.htmlLabel = new System.Windows.Forms.Label();
            this.htmlPropertyLabel = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.imageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clipImageLabel = new System.Windows.Forms.Label();
            this.clipImagePictureBox = new System.Windows.Forms.PictureBox();
            this.clipImagePropertyLabel = new System.Windows.Forms.Label();
            this.filesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clipFilesLabel = new System.Windows.Forms.Label();
            this.clipFilesPropertyLabel = new System.Windows.Forms.Label();
            this.clipFileListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.dimColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.typeColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.lastAccessColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.lastWriteColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.rtfTextTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clipTextLabel = new System.Windows.Forms.Label();
            this.clipTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.textLengthLabel = new System.Windows.Forms.Label();
            this.linePictureBox = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipTypePictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.htmlTableLayoutPanel.SuspendLayout();
            this.imageTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipImagePictureBox)).BeginInit();
            this.filesTableLayoutPanel.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.rtfTextTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "text.ICO");
            this.IconList.Images.SetKeyName(1, "bitmap.ICO");
            this.IconList.Images.SetKeyName(2, "files.ICO");
            this.IconList.Images.SetKeyName(3, "html.ICO");
            this.IconList.Images.SetKeyName(4, "rtf.ICO");
            this.IconList.Images.SetKeyName(5, "special.png");
            // 
            // clipTypeLabel
            // 
            this.clipTypeLabel.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.clipTypeLabel, 2);
            this.clipTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipTypeLabel.Location = new System.Drawing.Point(42, 11);
            this.clipTypeLabel.Name = "clipTypeLabel";
            this.clipTypeLabel.Size = new System.Drawing.Size(41, 13);
            this.clipTypeLabel.TabIndex = 1;
            this.clipTypeLabel.Text = "label1";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.mainTableLayoutPanel.Controls.Add(this.line2PictureBox, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.clipTypePictureBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.closeButton, 2, 5);
            this.mainTableLayoutPanel.Controls.Add(this.clipTypeLabel, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.mainPanel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.linePictureBox, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 6;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(321, 396);
            this.mainTableLayoutPanel.TabIndex = 3;
            // 
            // line2PictureBox
            // 
            this.line2PictureBox.BackgroundImage = global::ClipboardManager.Properties.Resources.line;
            this.line2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTableLayoutPanel.SetColumnSpan(this.line2PictureBox, 3);
            this.line2PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.line2PictureBox.Location = new System.Drawing.Point(3, 363);
            this.line2PictureBox.Name = "line2PictureBox";
            this.line2PictureBox.Size = new System.Drawing.Size(315, 2);
            this.line2PictureBox.TabIndex = 7;
            this.line2PictureBox.TabStop = false;
            // 
            // clipTypePictureBox
            // 
            this.clipTypePictureBox.Location = new System.Drawing.Point(3, 3);
            this.clipTypePictureBox.Name = "clipTypePictureBox";
            this.mainTableLayoutPanel.SetRowSpan(this.clipTypePictureBox, 2);
            this.clipTypePictureBox.Size = new System.Drawing.Size(32, 32);
            this.clipTypePictureBox.TabIndex = 0;
            this.clipTypePictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(258, 371);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 22);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mainPanel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.mainPanel, 3);
            this.mainPanel.Controls.Add(this.htmlTableLayoutPanel);
            this.mainPanel.Controls.Add(this.imageTableLayoutPanel);
            this.mainPanel.Controls.Add(this.filesTableLayoutPanel);
            this.mainPanel.Controls.Add(this.rtfTextTableLayoutPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 51);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(315, 306);
            this.mainPanel.TabIndex = 5;
            // 
            // htmlTableLayoutPanel
            // 
            this.htmlTableLayoutPanel.ColumnCount = 1;
            this.htmlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlTableLayoutPanel.Controls.Add(this.htmlLabel, 0, 0);
            this.htmlTableLayoutPanel.Controls.Add(this.htmlPropertyLabel, 0, 2);
            this.htmlTableLayoutPanel.Controls.Add(this.webBrowser, 0, 1);
            this.htmlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.htmlTableLayoutPanel.Name = "htmlTableLayoutPanel";
            this.htmlTableLayoutPanel.RowCount = 3;
            this.htmlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.htmlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.htmlTableLayoutPanel.Size = new System.Drawing.Size(315, 306);
            this.htmlTableLayoutPanel.TabIndex = 9;
            // 
            // htmlLabel
            // 
            this.htmlLabel.AutoSize = true;
            this.htmlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel.Location = new System.Drawing.Point(3, 0);
            this.htmlLabel.Name = "htmlLabel";
            this.htmlLabel.Size = new System.Drawing.Size(70, 13);
            this.htmlLabel.TabIndex = 6;
            this.htmlLabel.Text = "Clip HTML:";
            // 
            // htmlPropertyLabel
            // 
            this.htmlPropertyLabel.AutoSize = true;
            this.htmlPropertyLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.htmlPropertyLabel.Location = new System.Drawing.Point(277, 278);
            this.htmlPropertyLabel.Name = "htmlPropertyLabel";
            this.htmlPropertyLabel.Size = new System.Drawing.Size(35, 28);
            this.htmlPropertyLabel.TabIndex = 8;
            this.htmlPropertyLabel.Text = "label2";
            this.htmlPropertyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // webBrowser
            // 
            this.webBrowser.AllowNavigation = false;
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(3, 18);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(309, 257);
            this.webBrowser.TabIndex = 9;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // imageTableLayoutPanel
            // 
            this.imageTableLayoutPanel.ColumnCount = 1;
            this.imageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.imageTableLayoutPanel.Controls.Add(this.clipImageLabel, 0, 0);
            this.imageTableLayoutPanel.Controls.Add(this.clipImagePictureBox, 0, 1);
            this.imageTableLayoutPanel.Controls.Add(this.clipImagePropertyLabel, 0, 2);
            this.imageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.imageTableLayoutPanel.Name = "imageTableLayoutPanel";
            this.imageTableLayoutPanel.RowCount = 3;
            this.imageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.imageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.imageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.imageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.imageTableLayoutPanel.Size = new System.Drawing.Size(315, 306);
            this.imageTableLayoutPanel.TabIndex = 7;
            // 
            // clipImageLabel
            // 
            this.clipImageLabel.AutoSize = true;
            this.clipImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipImageLabel.Location = new System.Drawing.Point(3, 0);
            this.clipImageLabel.Name = "clipImageLabel";
            this.clipImageLabel.Size = new System.Drawing.Size(70, 13);
            this.clipImageLabel.TabIndex = 0;
            this.clipImageLabel.Text = "Clip Image:";
            // 
            // clipImagePictureBox
            // 
            this.clipImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clipImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipImagePictureBox.Location = new System.Drawing.Point(3, 18);
            this.clipImagePictureBox.Name = "clipImagePictureBox";
            this.clipImagePictureBox.Size = new System.Drawing.Size(309, 257);
            this.clipImagePictureBox.TabIndex = 2;
            this.clipImagePictureBox.TabStop = false;
            // 
            // clipImagePropertyLabel
            // 
            this.clipImagePropertyLabel.AutoSize = true;
            this.clipImagePropertyLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.clipImagePropertyLabel.Location = new System.Drawing.Point(277, 278);
            this.clipImagePropertyLabel.Name = "clipImagePropertyLabel";
            this.clipImagePropertyLabel.Size = new System.Drawing.Size(35, 28);
            this.clipImagePropertyLabel.TabIndex = 1;
            this.clipImagePropertyLabel.Text = "label2";
            this.clipImagePropertyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // filesTableLayoutPanel
            // 
            this.filesTableLayoutPanel.ColumnCount = 1;
            this.filesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filesTableLayoutPanel.Controls.Add(this.clipFilesLabel, 0, 0);
            this.filesTableLayoutPanel.Controls.Add(this.clipFilesPropertyLabel, 0, 2);
            this.filesTableLayoutPanel.Controls.Add(this.clipFileListView, 0, 1);
            this.filesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.filesTableLayoutPanel.Name = "filesTableLayoutPanel";
            this.filesTableLayoutPanel.RowCount = 3;
            this.filesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.filesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.filesTableLayoutPanel.Size = new System.Drawing.Size(315, 306);
            this.filesTableLayoutPanel.TabIndex = 8;
            // 
            // clipFilesLabel
            // 
            this.clipFilesLabel.AutoSize = true;
            this.clipFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipFilesLabel.Location = new System.Drawing.Point(3, 0);
            this.clipFilesLabel.Name = "clipFilesLabel";
            this.clipFilesLabel.Size = new System.Drawing.Size(62, 13);
            this.clipFilesLabel.TabIndex = 0;
            this.clipFilesLabel.Text = "Clip Files:";
            // 
            // clipFilesPropertyLabel
            // 
            this.clipFilesPropertyLabel.AutoSize = true;
            this.clipFilesPropertyLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.clipFilesPropertyLabel.Location = new System.Drawing.Point(277, 278);
            this.clipFilesPropertyLabel.Name = "clipFilesPropertyLabel";
            this.clipFilesPropertyLabel.Size = new System.Drawing.Size(35, 28);
            this.clipFilesPropertyLabel.TabIndex = 1;
            this.clipFilesPropertyLabel.Text = "label2";
            this.clipFilesPropertyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // clipFileListView
            // 
            this.clipFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.dimColumnHeader,
            this.typeColumnHeader,
            this.lastAccessColumnHeader,
            this.lastWriteColumnHeader});
            this.clipFileListView.ContextMenuStrip = this.contextMenuStrip;
            this.clipFileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipFileListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.clipFileListView.LargeImageList = this.largeImageList;
            this.clipFileListView.Location = new System.Drawing.Point(3, 18);
            this.clipFileListView.MultiSelect = false;
            this.clipFileListView.Name = "clipFileListView";
            this.clipFileListView.ShowItemToolTips = true;
            this.clipFileListView.Size = new System.Drawing.Size(309, 257);
            this.clipFileListView.SmallImageList = this.smallImageList;
            this.clipFileListView.TabIndex = 2;
            this.clipFileListView.UseCompatibleStateImageBehavior = false;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 200;
            // 
            // dimColumnHeader
            // 
            this.dimColumnHeader.Text = "Dimension";
            this.dimColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dimColumnHeader.Width = 75;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.Width = 100;
            // 
            // lastAccessColumnHeader
            // 
            this.lastAccessColumnHeader.Text = "Last Access";
            this.lastAccessColumnHeader.Width = 100;
            // 
            // lastWriteColumnHeader
            // 
            this.lastWriteColumnHeader.Text = "Last Write";
            this.lastWriteColumnHeader.Width = 100;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(126, 92);
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Checked = true;
            this.largeIconsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.largeIconsToolStripMenuItem.Text = "Large Icon";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.smallIconsToolStripMenuItem.Text = "Small Icon";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.detailToolStripMenuItem.Text = "Details";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // largeImageList
            // 
            this.largeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.largeImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallImageList
            // 
            this.smallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.smallImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rtfTextTableLayoutPanel
            // 
            this.rtfTextTableLayoutPanel.ColumnCount = 1;
            this.rtfTextTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rtfTextTableLayoutPanel.Controls.Add(this.clipTextLabel, 0, 0);
            this.rtfTextTableLayoutPanel.Controls.Add(this.clipTextRichTextBox, 0, 1);
            this.rtfTextTableLayoutPanel.Controls.Add(this.textLengthLabel, 0, 2);
            this.rtfTextTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfTextTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.rtfTextTableLayoutPanel.Name = "rtfTextTableLayoutPanel";
            this.rtfTextTableLayoutPanel.RowCount = 3;
            this.rtfTextTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.rtfTextTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rtfTextTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.rtfTextTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rtfTextTableLayoutPanel.Size = new System.Drawing.Size(315, 306);
            this.rtfTextTableLayoutPanel.TabIndex = 6;
            // 
            // clipTextLabel
            // 
            this.clipTextLabel.AutoSize = true;
            this.clipTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipTextLabel.Location = new System.Drawing.Point(3, 0);
            this.clipTextLabel.Name = "clipTextLabel";
            this.clipTextLabel.Size = new System.Drawing.Size(61, 13);
            this.clipTextLabel.TabIndex = 6;
            this.clipTextLabel.Text = "Clip Text:";
            // 
            // clipTextRichTextBox
            // 
            this.clipTextRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipTextRichTextBox.Location = new System.Drawing.Point(3, 18);
            this.clipTextRichTextBox.Name = "clipTextRichTextBox";
            this.clipTextRichTextBox.ReadOnly = true;
            this.clipTextRichTextBox.Size = new System.Drawing.Size(309, 257);
            this.clipTextRichTextBox.TabIndex = 7;
            this.clipTextRichTextBox.Text = "";
            // 
            // textLengthLabel
            // 
            this.textLengthLabel.AutoSize = true;
            this.textLengthLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.textLengthLabel.Location = new System.Drawing.Point(277, 278);
            this.textLengthLabel.Name = "textLengthLabel";
            this.textLengthLabel.Size = new System.Drawing.Size(35, 28);
            this.textLengthLabel.TabIndex = 8;
            this.textLengthLabel.Text = "label2";
            this.textLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // linePictureBox
            // 
            this.linePictureBox.BackgroundImage = global::ClipboardManager.Properties.Resources.line;
            this.linePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTableLayoutPanel.SetColumnSpan(this.linePictureBox, 3);
            this.linePictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linePictureBox.Location = new System.Drawing.Point(3, 43);
            this.linePictureBox.Name = "linePictureBox";
            this.linePictureBox.Size = new System.Drawing.Size(315, 2);
            this.linePictureBox.TabIndex = 6;
            this.linePictureBox.TabStop = false;
            // 
            // ItemProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(321, 396);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemProperty";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Clip Property";
            this.SizeChanged += new System.EventHandler(this.ItemProperty_SizeChanged);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipTypePictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.htmlTableLayoutPanel.ResumeLayout(false);
            this.htmlTableLayoutPanel.PerformLayout();
            this.imageTableLayoutPanel.ResumeLayout(false);
            this.imageTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipImagePictureBox)).EndInit();
            this.filesTableLayoutPanel.ResumeLayout(false);
            this.filesTableLayoutPanel.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.rtfTextTableLayoutPanel.ResumeLayout(false);
            this.rtfTextTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.PictureBox clipTypePictureBox;
        private System.Windows.Forms.Label clipTypeLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel rtfTextTableLayoutPanel;
        private System.Windows.Forms.Label clipTextLabel;
        private System.Windows.Forms.RichTextBox clipTextRichTextBox;
        private System.Windows.Forms.Label textLengthLabel;
        private System.Windows.Forms.PictureBox linePictureBox;
        private System.Windows.Forms.PictureBox line2PictureBox;
        private System.Windows.Forms.TableLayoutPanel imageTableLayoutPanel;
        private System.Windows.Forms.Label clipImageLabel;
        private System.Windows.Forms.PictureBox clipImagePictureBox;
        private System.Windows.Forms.Label clipImagePropertyLabel;
        private System.Windows.Forms.TableLayoutPanel filesTableLayoutPanel;
        private System.Windows.Forms.Label clipFilesLabel;
        private System.Windows.Forms.Label clipFilesPropertyLabel;
        private System.Windows.Forms.ListView clipFileListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader dimColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader lastWriteColumnHeader;
        private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ColumnHeader lastAccessColumnHeader;
        private System.Windows.Forms.TableLayoutPanel htmlTableLayoutPanel;
        private System.Windows.Forms.Label htmlLabel;
        private System.Windows.Forms.Label htmlPropertyLabel;
        private System.Windows.Forms.WebBrowser webBrowser;


    }
}