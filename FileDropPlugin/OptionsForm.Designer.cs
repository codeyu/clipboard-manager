namespace FileDropPlugin {
    partial class OptionsForm {
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.zipOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.zipPasswordLabel = new System.Windows.Forms.Label();
            this.zipCommentLabel = new System.Windows.Forms.Label();
            this.zipCommentTextBox = new System.Windows.Forms.TextBox();
            this.zipPasswordTextBox = new System.Windows.Forms.TextBox();
            this.pathStyleLabel = new System.Windows.Forms.Label();
            this.pathStyleComboBox = new System.Windows.Forms.ComboBox();
            this.recursiveSubdirCheckBox = new System.Windows.Forms.CheckBox();
            this.outputOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.outDirButton = new System.Windows.Forms.Button();
            this.outDirTextBox = new System.Windows.Forms.TextBox();
            this.outDirLabel = new System.Windows.Forms.Label();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.nameTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.nameTypeLabel = new System.Windows.Forms.Label();
            this.compressionLevelLabel = new System.Windows.Forms.Label();
            this.compressionLevelTrackBar = new System.Windows.Forms.TrackBar();
            this.compressionMethodComboBox = new System.Windows.Forms.ComboBox();
            this.compressionMethodLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.compressionSettingsgroupBox = new System.Windows.Forms.GroupBox();
            this.zipOptionsGroupBox.SuspendLayout();
            this.outputOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compressionLevelTrackBar)).BeginInit();
            this.compressionSettingsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(203, 371);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(122, 371);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // zipOptionsGroupBox
            // 
            this.zipOptionsGroupBox.Controls.Add(this.zipPasswordLabel);
            this.zipOptionsGroupBox.Controls.Add(this.zipCommentLabel);
            this.zipOptionsGroupBox.Controls.Add(this.zipCommentTextBox);
            this.zipOptionsGroupBox.Controls.Add(this.zipPasswordTextBox);
            this.zipOptionsGroupBox.Controls.Add(this.pathStyleLabel);
            this.zipOptionsGroupBox.Controls.Add(this.pathStyleComboBox);
            this.zipOptionsGroupBox.Controls.Add(this.recursiveSubdirCheckBox);
            this.zipOptionsGroupBox.Location = new System.Drawing.Point(0, 84);
            this.zipOptionsGroupBox.Name = "zipOptionsGroupBox";
            this.zipOptionsGroupBox.Size = new System.Drawing.Size(278, 182);
            this.zipOptionsGroupBox.TabIndex = 2;
            this.zipOptionsGroupBox.TabStop = false;
            this.zipOptionsGroupBox.Text = "Zip Settings";
            // 
            // zipPasswordLabel
            // 
            this.zipPasswordLabel.AutoSize = true;
            this.zipPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipPasswordLabel.Location = new System.Drawing.Point(8, 66);
            this.zipPasswordLabel.Name = "zipPasswordLabel";
            this.zipPasswordLabel.Size = new System.Drawing.Size(65, 13);
            this.zipPasswordLabel.TabIndex = 11;
            this.zipPasswordLabel.Text = "Password:";
            // 
            // zipCommentLabel
            // 
            this.zipCommentLabel.AutoSize = true;
            this.zipCommentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCommentLabel.Location = new System.Drawing.Point(11, 92);
            this.zipCommentLabel.Name = "zipCommentLabel";
            this.zipCommentLabel.Size = new System.Drawing.Size(62, 13);
            this.zipCommentLabel.TabIndex = 10;
            this.zipCommentLabel.Text = "Comment:";
            // 
            // zipCommentTextBox
            // 
            this.zipCommentTextBox.Location = new System.Drawing.Point(83, 89);
            this.zipCommentTextBox.Multiline = true;
            this.zipCommentTextBox.Name = "zipCommentTextBox";
            this.zipCommentTextBox.Size = new System.Drawing.Size(185, 85);
            this.zipCommentTextBox.TabIndex = 4;
            // 
            // zipPasswordTextBox
            // 
            this.zipPasswordTextBox.Location = new System.Drawing.Point(83, 63);
            this.zipPasswordTextBox.Name = "zipPasswordTextBox";
            this.zipPasswordTextBox.PasswordChar = '*';
            this.zipPasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.zipPasswordTextBox.TabIndex = 3;
            // 
            // pathStyleLabel
            // 
            this.pathStyleLabel.AutoSize = true;
            this.pathStyleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathStyleLabel.Location = new System.Drawing.Point(4, 16);
            this.pathStyleLabel.Name = "pathStyleLabel";
            this.pathStyleLabel.Size = new System.Drawing.Size(69, 13);
            this.pathStyleLabel.TabIndex = 7;
            this.pathStyleLabel.Text = "Path Style:";
            // 
            // pathStyleComboBox
            // 
            this.pathStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pathStyleComboBox.FormattingEnabled = true;
            this.pathStyleComboBox.Items.AddRange(new object[] {
            "None",
            "Full",
            "Relative"});
            this.pathStyleComboBox.Location = new System.Drawing.Point(83, 13);
            this.pathStyleComboBox.Name = "pathStyleComboBox";
            this.pathStyleComboBox.Size = new System.Drawing.Size(68, 21);
            this.pathStyleComboBox.TabIndex = 1;
            // 
            // recursiveSubdirCheckBox
            // 
            this.recursiveSubdirCheckBox.AutoSize = true;
            this.recursiveSubdirCheckBox.Location = new System.Drawing.Point(83, 40);
            this.recursiveSubdirCheckBox.Name = "recursiveSubdirCheckBox";
            this.recursiveSubdirCheckBox.Size = new System.Drawing.Size(144, 17);
            this.recursiveSubdirCheckBox.TabIndex = 2;
            this.recursiveSubdirCheckBox.Text = "Recursive Subdirectories";
            this.recursiveSubdirCheckBox.UseVisualStyleBackColor = true;
            // 
            // outputOptionsGroupBox
            // 
            this.outputOptionsGroupBox.Controls.Add(this.outDirButton);
            this.outputOptionsGroupBox.Controls.Add(this.outDirTextBox);
            this.outputOptionsGroupBox.Controls.Add(this.outDirLabel);
            this.outputOptionsGroupBox.Controls.Add(this.filenameTextBox);
            this.outputOptionsGroupBox.Controls.Add(this.nameTypeComboBox);
            this.outputOptionsGroupBox.Controls.Add(this.filenameLabel);
            this.outputOptionsGroupBox.Controls.Add(this.nameTypeLabel);
            this.outputOptionsGroupBox.Location = new System.Drawing.Point(0, 272);
            this.outputOptionsGroupBox.Name = "outputOptionsGroupBox";
            this.outputOptionsGroupBox.Size = new System.Drawing.Size(278, 93);
            this.outputOptionsGroupBox.TabIndex = 3;
            this.outputOptionsGroupBox.TabStop = false;
            this.outputOptionsGroupBox.Text = "Output Settings";
            // 
            // outDirButton
            // 
            this.outDirButton.Location = new System.Drawing.Point(249, 66);
            this.outDirButton.Name = "outDirButton";
            this.outDirButton.Size = new System.Drawing.Size(25, 20);
            this.outDirButton.TabIndex = 4;
            this.outDirButton.Text = "...";
            this.outDirButton.UseVisualStyleBackColor = true;
            this.outDirButton.Click += new System.EventHandler(this.outDirButton_Click);
            // 
            // outDirTextBox
            // 
            this.outDirTextBox.Location = new System.Drawing.Point(93, 66);
            this.outDirTextBox.Name = "outDirTextBox";
            this.outDirTextBox.Size = new System.Drawing.Size(150, 20);
            this.outDirTextBox.TabIndex = 3;
            // 
            // outDirLabel
            // 
            this.outDirLabel.AutoSize = true;
            this.outDirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outDirLabel.Location = new System.Drawing.Point(18, 69);
            this.outDirLabel.Name = "outDirLabel";
            this.outDirLabel.Size = new System.Drawing.Size(69, 13);
            this.outDirLabel.TabIndex = 15;
            this.outDirLabel.Text = "Output Dir:";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(93, 40);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(121, 20);
            this.filenameTextBox.TabIndex = 2;
            // 
            // nameTypeComboBox
            // 
            this.nameTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameTypeComboBox.FormattingEnabled = true;
            this.nameTypeComboBox.Items.AddRange(new object[] {
            "First filename",
            "User specified"});
            this.nameTypeComboBox.Location = new System.Drawing.Point(93, 13);
            this.nameTypeComboBox.Name = "nameTypeComboBox";
            this.nameTypeComboBox.Size = new System.Drawing.Size(91, 21);
            this.nameTypeComboBox.TabIndex = 1;
            this.nameTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.nameTypeComboBox_SelectedIndexChanged);
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLabel.Location = new System.Drawing.Point(26, 43);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(61, 13);
            this.filenameLabel.TabIndex = 1;
            this.filenameLabel.Text = "Filename:";
            // 
            // nameTypeLabel
            // 
            this.nameTypeLabel.AutoSize = true;
            this.nameTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTypeLabel.Location = new System.Drawing.Point(12, 16);
            this.nameTypeLabel.Name = "nameTypeLabel";
            this.nameTypeLabel.Size = new System.Drawing.Size(75, 13);
            this.nameTypeLabel.TabIndex = 0;
            this.nameTypeLabel.Text = "Name Type:";
            // 
            // compressionLevelLabel
            // 
            this.compressionLevelLabel.AutoSize = true;
            this.compressionLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressionLevelLabel.Location = new System.Drawing.Point(21, 40);
            this.compressionLevelLabel.Name = "compressionLevelLabel";
            this.compressionLevelLabel.Size = new System.Drawing.Size(42, 13);
            this.compressionLevelLabel.TabIndex = 0;
            this.compressionLevelLabel.Text = "Level:";
            // 
            // compressionLevelTrackBar
            // 
            this.compressionLevelTrackBar.Location = new System.Drawing.Point(64, 40);
            this.compressionLevelTrackBar.Maximum = 9;
            this.compressionLevelTrackBar.Name = "compressionLevelTrackBar";
            this.compressionLevelTrackBar.Size = new System.Drawing.Size(205, 34);
            this.compressionLevelTrackBar.TabIndex = 2;
            // 
            // compressionMethodComboBox
            // 
            this.compressionMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compressionMethodComboBox.FormattingEnabled = true;
            this.compressionMethodComboBox.Items.AddRange(new object[] {
            "Deflated",
            "Stored"});
            this.compressionMethodComboBox.Location = new System.Drawing.Point(69, 13);
            this.compressionMethodComboBox.Name = "compressionMethodComboBox";
            this.compressionMethodComboBox.Size = new System.Drawing.Size(68, 21);
            this.compressionMethodComboBox.TabIndex = 1;
            // 
            // compressionMethodLabel
            // 
            this.compressionMethodLabel.AutoSize = true;
            this.compressionMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressionMethodLabel.Location = new System.Drawing.Point(10, 16);
            this.compressionMethodLabel.Name = "compressionMethodLabel";
            this.compressionMethodLabel.Size = new System.Drawing.Size(53, 13);
            this.compressionMethodLabel.TabIndex = 6;
            this.compressionMethodLabel.Text = "Method:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select the output directory for the new zip files";
            // 
            // compressionSettingsgroupBox
            // 
            this.compressionSettingsgroupBox.Controls.Add(this.compressionMethodLabel);
            this.compressionSettingsgroupBox.Controls.Add(this.compressionLevelLabel);
            this.compressionSettingsgroupBox.Controls.Add(this.compressionLevelTrackBar);
            this.compressionSettingsgroupBox.Controls.Add(this.compressionMethodComboBox);
            this.compressionSettingsgroupBox.Location = new System.Drawing.Point(0, 0);
            this.compressionSettingsgroupBox.Name = "compressionSettingsgroupBox";
            this.compressionSettingsgroupBox.Size = new System.Drawing.Size(274, 78);
            this.compressionSettingsgroupBox.TabIndex = 1;
            this.compressionSettingsgroupBox.TabStop = false;
            this.compressionSettingsgroupBox.Text = "Compression Settings";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(280, 397);
            this.Controls.Add(this.compressionSettingsgroupBox);
            this.Controls.Add(this.outputOptionsGroupBox);
            this.Controls.Add(this.zipOptionsGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileDrop Plugin Options";
            this.zipOptionsGroupBox.ResumeLayout(false);
            this.zipOptionsGroupBox.PerformLayout();
            this.outputOptionsGroupBox.ResumeLayout(false);
            this.outputOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compressionLevelTrackBar)).EndInit();
            this.compressionSettingsgroupBox.ResumeLayout(false);
            this.compressionSettingsgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox zipOptionsGroupBox;
        private System.Windows.Forms.CheckBox recursiveSubdirCheckBox;
        private System.Windows.Forms.Label compressionLevelLabel;
        private System.Windows.Forms.GroupBox outputOptionsGroupBox;
        private System.Windows.Forms.TrackBar compressionLevelTrackBar;
        private System.Windows.Forms.ComboBox pathStyleComboBox;
        private System.Windows.Forms.ComboBox compressionMethodComboBox;
        private System.Windows.Forms.Label pathStyleLabel;
        private System.Windows.Forms.Label compressionMethodLabel;
        private System.Windows.Forms.Label zipPasswordLabel;
        private System.Windows.Forms.Label zipCommentLabel;
        private System.Windows.Forms.TextBox zipCommentTextBox;
        private System.Windows.Forms.TextBox zipPasswordTextBox;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.ComboBox nameTypeComboBox;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.Label nameTypeLabel;
        private System.Windows.Forms.Button outDirButton;
        private System.Windows.Forms.TextBox outDirTextBox;
        private System.Windows.Forms.Label outDirLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox compressionSettingsgroupBox;
    }
}