namespace ClipboardManager
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.optionsTabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.removePluginDirButton = new System.Windows.Forms.Button();
            this.addPluginDirButton = new System.Windows.Forms.Button();
            this.pluginDirListBox = new System.Windows.Forms.ListBox();
            this.pluginDirLabel = new System.Windows.Forms.Label();
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.windowsTabPage = new System.Windows.Forms.TabPage();
            this.resetColorButton = new System.Windows.Forms.Button();
            this.opacityCheckBox = new System.Windows.Forms.CheckBox();
            this.opacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.savePosCheckBox = new System.Windows.Forms.CheckBox();
            this.onTopCheckBox = new System.Windows.Forms.CheckBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.hotKeysTabPage = new System.Windows.Forms.TabPage();
            this.noteLabel = new System.Windows.Forms.Label();
            this.nextEntryLabel = new System.Windows.Forms.Label();
            this.firstEntryLabel = new System.Windows.Forms.Label();
            this.previousEntryLabel = new System.Windows.Forms.Label();
            this.showWindowTextBox = new System.Windows.Forms.TextBox();
            this.selectedEntryLabel = new System.Windows.Forms.Label();
            this.upEntryTextBox = new System.Windows.Forms.TextBox();
            this.copyEntryTextBox = new System.Windows.Forms.TextBox();
            this.downEntryTextBox = new System.Windows.Forms.TextBox();
            this.pluginTabPage = new System.Windows.Forms.TabPage();
            this.enabledPluginCheckBox = new System.Windows.Forms.CheckBox();
            this.pluginImagePictureBox = new System.Windows.Forms.PictureBox();
            this.pluginAboutButton = new System.Windows.Forms.Button();
            this.pluginOptionsButton = new System.Windows.Forms.Button();
            this.pluginInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionPluginLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.descTitleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorTitleLabel = new System.Windows.Forms.Label();
            this.pluginsComboBox = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.applyButton = new System.Windows.Forms.Button();
            this.optionsTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.windowsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            this.hotKeysTabPage.SuspendLayout();
            this.pluginTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluginImagePictureBox)).BeginInit();
            this.pluginInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(61, 193);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(223, 193);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // optionsTabControl
            // 
            this.optionsTabControl.Controls.Add(this.generalTabPage);
            this.optionsTabControl.Controls.Add(this.windowsTabPage);
            this.optionsTabControl.Controls.Add(this.hotKeysTabPage);
            this.optionsTabControl.Controls.Add(this.pluginTabPage);
            this.optionsTabControl.Location = new System.Drawing.Point(0, 0);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(298, 191);
            this.optionsTabControl.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.removePluginDirButton);
            this.generalTabPage.Controls.Add(this.addPluginDirButton);
            this.generalTabPage.Controls.Add(this.pluginDirListBox);
            this.generalTabPage.Controls.Add(this.pluginDirLabel);
            this.generalTabPage.Controls.Add(this.startupCheckBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 21);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(290, 166);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // removePluginDirButton
            // 
            this.removePluginDirButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.removePluginDirButton.Location = new System.Drawing.Point(226, 120);
            this.removePluginDirButton.Name = "removePluginDirButton";
            this.removePluginDirButton.Size = new System.Drawing.Size(62, 22);
            this.removePluginDirButton.TabIndex = 2;
            this.removePluginDirButton.Text = "Remove";
            this.removePluginDirButton.UseVisualStyleBackColor = true;
            this.removePluginDirButton.Click += new System.EventHandler(this.removePluginDirButton_Click);
            // 
            // addPluginDirButton
            // 
            this.addPluginDirButton.Location = new System.Drawing.Point(165, 120);
            this.addPluginDirButton.Name = "addPluginDirButton";
            this.addPluginDirButton.Size = new System.Drawing.Size(62, 22);
            this.addPluginDirButton.TabIndex = 1;
            this.addPluginDirButton.Text = "Add";
            this.addPluginDirButton.UseVisualStyleBackColor = true;
            this.addPluginDirButton.Click += new System.EventHandler(this.addPluginDirButton_Click);
            // 
            // pluginDirListBox
            // 
            this.pluginDirListBox.FormattingEnabled = true;
            this.pluginDirListBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pluginDirListBox.Location = new System.Drawing.Point(3, 19);
            this.pluginDirListBox.Name = "pluginDirListBox";
            this.pluginDirListBox.Size = new System.Drawing.Size(284, 95);
            this.pluginDirListBox.TabIndex = 0;
            this.pluginDirListBox.DoubleClick += new System.EventHandler(this.pluginDirListBox_DoubleClick);
            this.pluginDirListBox.SelectedIndexChanged += new System.EventHandler(this.pluginDirListBox_SelectedIndexChanged);
            // 
            // pluginDirLabel
            // 
            this.pluginDirLabel.AutoSize = true;
            this.pluginDirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluginDirLabel.Location = new System.Drawing.Point(0, 3);
            this.pluginDirLabel.Name = "pluginDirLabel";
            this.pluginDirLabel.Size = new System.Drawing.Size(107, 13);
            this.pluginDirLabel.TabIndex = 1;
            this.pluginDirLabel.Text = "Plugin Directories";
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.AutoSize = true;
            this.startupCheckBox.Location = new System.Drawing.Point(6, 143);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(119, 17);
            this.startupCheckBox.TabIndex = 3;
            this.startupCheckBox.Text = "Load with Windows";
            this.startupCheckBox.UseVisualStyleBackColor = true;
            this.startupCheckBox.CheckedChanged += new System.EventHandler(this.startupCheckBox_CheckedChanged);
            // 
            // windowsTabPage
            // 
            this.windowsTabPage.Controls.Add(this.resetColorButton);
            this.windowsTabPage.Controls.Add(this.opacityCheckBox);
            this.windowsTabPage.Controls.Add(this.opacityNumericUpDown);
            this.windowsTabPage.Controls.Add(this.colorPictureBox);
            this.windowsTabPage.Controls.Add(this.savePosCheckBox);
            this.windowsTabPage.Controls.Add(this.onTopCheckBox);
            this.windowsTabPage.Controls.Add(this.colorLabel);
            this.windowsTabPage.Controls.Add(this.opacityLabel);
            this.windowsTabPage.Controls.Add(this.opacityTrackBar);
            this.windowsTabPage.Location = new System.Drawing.Point(4, 21);
            this.windowsTabPage.Name = "windowsTabPage";
            this.windowsTabPage.Size = new System.Drawing.Size(290, 166);
            this.windowsTabPage.TabIndex = 3;
            this.windowsTabPage.Text = "Window";
            this.windowsTabPage.UseVisualStyleBackColor = true;
            // 
            // resetColorButton
            // 
            this.resetColorButton.Location = new System.Drawing.Point(164, 119);
            this.resetColorButton.Name = "resetColorButton";
            this.resetColorButton.Size = new System.Drawing.Size(71, 23);
            this.resetColorButton.TabIndex = 8;
            this.resetColorButton.Text = "Reset Color";
            this.resetColorButton.UseVisualStyleBackColor = true;
            this.resetColorButton.Click += new System.EventHandler(this.resetColorButton_Click);
            // 
            // opacityCheckBox
            // 
            this.opacityCheckBox.AutoSize = true;
            this.opacityCheckBox.Location = new System.Drawing.Point(6, 54);
            this.opacityCheckBox.Name = "opacityCheckBox";
            this.opacityCheckBox.Size = new System.Drawing.Size(141, 17);
            this.opacityCheckBox.TabIndex = 2;
            this.opacityCheckBox.Text = "Semi-trasparent Window";
            this.opacityCheckBox.UseVisualStyleBackColor = true;
            this.opacityCheckBox.CheckedChanged += new System.EventHandler(this.opacityCheckBox_CheckedChanged);
            // 
            // opacityNumericUpDown
            // 
            this.opacityNumericUpDown.Enabled = false;
            this.opacityNumericUpDown.Location = new System.Drawing.Point(241, 84);
            this.opacityNumericUpDown.Name = "opacityNumericUpDown";
            this.opacityNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.opacityNumericUpDown.TabIndex = 4;
            this.opacityNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.opacityNumericUpDown.ValueChanged += new System.EventHandler(this.opacityNumericUpDown_ValueChanged);
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPictureBox.Location = new System.Drawing.Point(131, 121);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(24, 18);
            this.colorPictureBox.TabIndex = 7;
            this.colorPictureBox.TabStop = false;
            this.colorPictureBox.Click += new System.EventHandler(this.colorPictureBox_Click);
            // 
            // savePosCheckBox
            // 
            this.savePosCheckBox.AutoSize = true;
            this.savePosCheckBox.Location = new System.Drawing.Point(6, 31);
            this.savePosCheckBox.Name = "savePosCheckBox";
            this.savePosCheckBox.Size = new System.Drawing.Size(177, 17);
            this.savePosCheckBox.TabIndex = 1;
            this.savePosCheckBox.Text = "Save Window Position and Size";
            this.savePosCheckBox.UseVisualStyleBackColor = true;
            this.savePosCheckBox.CheckedChanged += new System.EventHandler(this.savePosCheckBox_CheckedChanged);
            // 
            // onTopCheckBox
            // 
            this.onTopCheckBox.AutoSize = true;
            this.onTopCheckBox.Location = new System.Drawing.Point(6, 8);
            this.onTopCheckBox.Name = "onTopCheckBox";
            this.onTopCheckBox.Size = new System.Drawing.Size(96, 17);
            this.onTopCheckBox.TabIndex = 0;
            this.onTopCheckBox.Text = "Always on Top";
            this.onTopCheckBox.UseVisualStyleBackColor = true;
            this.onTopCheckBox.CheckedChanged += new System.EventHandler(this.onTopCheckBox_CheckedChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(3, 123);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(122, 13);
            this.colorLabel.TabIndex = 4;
            this.colorLabel.Text = "Window Back Color:";
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opacityLabel.Location = new System.Drawing.Point(3, 86);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(43, 13);
            this.opacityLabel.TabIndex = 1;
            this.opacityLabel.Text = "Value:";
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.Enabled = false;
            this.opacityTrackBar.Location = new System.Drawing.Point(52, 77);
            this.opacityTrackBar.Maximum = 100;
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Size = new System.Drawing.Size(183, 34);
            this.opacityTrackBar.TabIndex = 3;
            this.opacityTrackBar.TickFrequency = 10;
            this.opacityTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.opacityTrackBar.Scroll += new System.EventHandler(this.opacityTrackBar_Scroll);
            // 
            // hotKeysTabPage
            // 
            this.hotKeysTabPage.Controls.Add(this.noteLabel);
            this.hotKeysTabPage.Controls.Add(this.nextEntryLabel);
            this.hotKeysTabPage.Controls.Add(this.firstEntryLabel);
            this.hotKeysTabPage.Controls.Add(this.previousEntryLabel);
            this.hotKeysTabPage.Controls.Add(this.showWindowTextBox);
            this.hotKeysTabPage.Controls.Add(this.selectedEntryLabel);
            this.hotKeysTabPage.Controls.Add(this.upEntryTextBox);
            this.hotKeysTabPage.Controls.Add(this.copyEntryTextBox);
            this.hotKeysTabPage.Controls.Add(this.downEntryTextBox);
            this.hotKeysTabPage.Location = new System.Drawing.Point(4, 21);
            this.hotKeysTabPage.Name = "hotKeysTabPage";
            this.hotKeysTabPage.Size = new System.Drawing.Size(290, 166);
            this.hotKeysTabPage.TabIndex = 2;
            this.hotKeysTabPage.Text = "Hotkeys";
            this.hotKeysTabPage.UseVisualStyleBackColor = true;
            // 
            // noteLabel
            // 
            this.noteLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(3, 120);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(284, 34);
            this.noteLabel.TabIndex = 17;
            this.noteLabel.Text = "Note: you can\'t assign hotkeys previously assigned to other programs. If an error" +
                " pops up, change your selection";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextEntryLabel
            // 
            this.nextEntryLabel.AutoSize = true;
            this.nextEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextEntryLabel.Location = new System.Drawing.Point(20, 87);
            this.nextEntryLabel.Name = "nextEntryLabel";
            this.nextEntryLabel.Size = new System.Drawing.Size(111, 13);
            this.nextEntryLabel.TabIndex = 16;
            this.nextEntryLabel.Text = "Copy to Clipboard:";
            // 
            // firstEntryLabel
            // 
            this.firstEntryLabel.AutoSize = true;
            this.firstEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstEntryLabel.Location = new System.Drawing.Point(8, 9);
            this.firstEntryLabel.Name = "firstEntryLabel";
            this.firstEntryLabel.Size = new System.Drawing.Size(123, 13);
            this.firstEntryLabel.TabIndex = 13;
            this.firstEntryLabel.Text = "Show/Hide Window:";
            // 
            // previousEntryLabel
            // 
            this.previousEntryLabel.AutoSize = true;
            this.previousEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousEntryLabel.Location = new System.Drawing.Point(31, 61);
            this.previousEntryLabel.Name = "previousEntryLabel";
            this.previousEntryLabel.Size = new System.Drawing.Size(100, 13);
            this.previousEntryLabel.TabIndex = 15;
            this.previousEntryLabel.Text = "Selection Down:";
            // 
            // showWindowTextBox
            // 
            this.showWindowTextBox.Location = new System.Drawing.Point(137, 6);
            this.showWindowTextBox.MaxLength = 1;
            this.showWindowTextBox.Name = "showWindowTextBox";
            this.showWindowTextBox.Size = new System.Drawing.Size(140, 20);
            this.showWindowTextBox.TabIndex = 0;
            this.showWindowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.showWindowTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.showWindowTextBox_KeyPress);
            this.showWindowTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.showWindowTextBox_KeyDown);
            // 
            // selectedEntryLabel
            // 
            this.selectedEntryLabel.AutoSize = true;
            this.selectedEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedEntryLabel.Location = new System.Drawing.Point(47, 35);
            this.selectedEntryLabel.Name = "selectedEntryLabel";
            this.selectedEntryLabel.Size = new System.Drawing.Size(84, 13);
            this.selectedEntryLabel.TabIndex = 14;
            this.selectedEntryLabel.Text = "Selection Up:";
            // 
            // upEntryTextBox
            // 
            this.upEntryTextBox.Location = new System.Drawing.Point(138, 32);
            this.upEntryTextBox.MaxLength = 1;
            this.upEntryTextBox.Name = "upEntryTextBox";
            this.upEntryTextBox.Size = new System.Drawing.Size(140, 20);
            this.upEntryTextBox.TabIndex = 1;
            this.upEntryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upEntryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.upEntryTextBox_KeyPress);
            this.upEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.upEntryTextBox_KeyDown);
            // 
            // copyEntryTextBox
            // 
            this.copyEntryTextBox.Location = new System.Drawing.Point(138, 84);
            this.copyEntryTextBox.MaxLength = 1;
            this.copyEntryTextBox.Name = "copyEntryTextBox";
            this.copyEntryTextBox.Size = new System.Drawing.Size(140, 20);
            this.copyEntryTextBox.TabIndex = 3;
            this.copyEntryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.copyEntryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.copyEntryTextBox_KeyPress);
            this.copyEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.copyEntryTextBox_KeyDown);
            // 
            // downEntryTextBox
            // 
            this.downEntryTextBox.Location = new System.Drawing.Point(138, 58);
            this.downEntryTextBox.MaxLength = 1;
            this.downEntryTextBox.Name = "downEntryTextBox";
            this.downEntryTextBox.Size = new System.Drawing.Size(140, 20);
            this.downEntryTextBox.TabIndex = 2;
            this.downEntryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.downEntryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.downEntryTextBox_KeyPress);
            this.downEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.downEntryTextBox_KeyDown);
            // 
            // pluginTabPage
            // 
            this.pluginTabPage.Controls.Add(this.enabledPluginCheckBox);
            this.pluginTabPage.Controls.Add(this.pluginImagePictureBox);
            this.pluginTabPage.Controls.Add(this.pluginAboutButton);
            this.pluginTabPage.Controls.Add(this.pluginOptionsButton);
            this.pluginTabPage.Controls.Add(this.pluginInfoGroupBox);
            this.pluginTabPage.Controls.Add(this.pluginsComboBox);
            this.pluginTabPage.Location = new System.Drawing.Point(4, 21);
            this.pluginTabPage.Name = "pluginTabPage";
            this.pluginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pluginTabPage.Size = new System.Drawing.Size(290, 166);
            this.pluginTabPage.TabIndex = 1;
            this.pluginTabPage.Text = "Plugins";
            this.pluginTabPage.UseVisualStyleBackColor = true;
            // 
            // enabledPluginCheckBox
            // 
            this.enabledPluginCheckBox.AutoSize = true;
            this.enabledPluginCheckBox.Location = new System.Drawing.Point(225, 90);
            this.enabledPluginCheckBox.Name = "enabledPluginCheckBox";
            this.enabledPluginCheckBox.Size = new System.Drawing.Size(65, 17);
            this.enabledPluginCheckBox.TabIndex = 1;
            this.enabledPluginCheckBox.Text = "Enabled";
            this.enabledPluginCheckBox.UseVisualStyleBackColor = true;
            this.enabledPluginCheckBox.CheckedChanged += new System.EventHandler(this.enabledPluginCheckBox_CheckedChanged);
            // 
            // pluginImagePictureBox
            // 
            this.pluginImagePictureBox.Location = new System.Drawing.Point(240, 42);
            this.pluginImagePictureBox.Name = "pluginImagePictureBox";
            this.pluginImagePictureBox.Size = new System.Drawing.Size(32, 32);
            this.pluginImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pluginImagePictureBox.TabIndex = 4;
            this.pluginImagePictureBox.TabStop = false;
            // 
            // pluginAboutButton
            // 
            this.pluginAboutButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.pluginAboutButton.Location = new System.Drawing.Point(225, 140);
            this.pluginAboutButton.Name = "pluginAboutButton";
            this.pluginAboutButton.Size = new System.Drawing.Size(62, 22);
            this.pluginAboutButton.TabIndex = 3;
            this.pluginAboutButton.Text = "About";
            this.pluginAboutButton.UseVisualStyleBackColor = true;
            this.pluginAboutButton.Click += new System.EventHandler(this.pluginAboutButton_Click);
            // 
            // pluginOptionsButton
            // 
            this.pluginOptionsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.pluginOptionsButton.Location = new System.Drawing.Point(225, 116);
            this.pluginOptionsButton.Name = "pluginOptionsButton";
            this.pluginOptionsButton.Size = new System.Drawing.Size(62, 22);
            this.pluginOptionsButton.TabIndex = 2;
            this.pluginOptionsButton.Text = "Options";
            this.pluginOptionsButton.UseVisualStyleBackColor = true;
            this.pluginOptionsButton.Click += new System.EventHandler(this.pluginOptionsButton_Click);
            // 
            // pluginInfoGroupBox
            // 
            this.pluginInfoGroupBox.Controls.Add(this.versionLabel);
            this.pluginInfoGroupBox.Controls.Add(this.versionPluginLabel);
            this.pluginInfoGroupBox.Controls.Add(this.descLabel);
            this.pluginInfoGroupBox.Controls.Add(this.descTitleLabel);
            this.pluginInfoGroupBox.Controls.Add(this.authorLabel);
            this.pluginInfoGroupBox.Controls.Add(this.authorTitleLabel);
            this.pluginInfoGroupBox.Location = new System.Drawing.Point(3, 33);
            this.pluginInfoGroupBox.Name = "pluginInfoGroupBox";
            this.pluginInfoGroupBox.Size = new System.Drawing.Size(213, 129);
            this.pluginInfoGroupBox.TabIndex = 1;
            this.pluginInfoGroupBox.TabStop = false;
            this.pluginInfoGroupBox.Text = "Plugin Info";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(84, 36);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 13);
            this.versionLabel.TabIndex = 5;
            // 
            // versionPluginLabel
            // 
            this.versionPluginLabel.AutoSize = true;
            this.versionPluginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionPluginLabel.Location = new System.Drawing.Point(25, 36);
            this.versionPluginLabel.Name = "versionPluginLabel";
            this.versionPluginLabel.Size = new System.Drawing.Size(53, 13);
            this.versionPluginLabel.TabIndex = 4;
            this.versionPluginLabel.Text = "Version:";
            // 
            // descLabel
            // 
            this.descLabel.Location = new System.Drawing.Point(84, 56);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(123, 64);
            this.descLabel.TabIndex = 3;
            // 
            // descTitleLabel
            // 
            this.descTitleLabel.AutoSize = true;
            this.descTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTitleLabel.Location = new System.Drawing.Point(3, 56);
            this.descTitleLabel.Name = "descTitleLabel";
            this.descTitleLabel.Size = new System.Drawing.Size(75, 13);
            this.descTitleLabel.TabIndex = 2;
            this.descTitleLabel.Text = "Description:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(84, 16);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(0, 13);
            this.authorLabel.TabIndex = 1;
            // 
            // authorTitleLabel
            // 
            this.authorTitleLabel.AutoSize = true;
            this.authorTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTitleLabel.Location = new System.Drawing.Point(30, 16);
            this.authorTitleLabel.Name = "authorTitleLabel";
            this.authorTitleLabel.Size = new System.Drawing.Size(48, 13);
            this.authorTitleLabel.TabIndex = 0;
            this.authorTitleLabel.Text = "Author:";
            // 
            // pluginsComboBox
            // 
            this.pluginsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pluginsComboBox.FormattingEnabled = true;
            this.pluginsComboBox.Location = new System.Drawing.Point(3, 6);
            this.pluginsComboBox.Name = "pluginsComboBox";
            this.pluginsComboBox.Size = new System.Drawing.Size(284, 21);
            this.pluginsComboBox.TabIndex = 0;
            this.pluginsComboBox.SelectedIndexChanged += new System.EventHandler(this.pluginsComboBox_SelectedIndexChanged);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select a Clipboard Manager Plugin Directory";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(142, 193);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "&Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // OptionForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(299, 220);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.optionsTabControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipboard Manager Options";
            this.Shown += new System.EventHandler(this.OptionForm_Shown);
            this.optionsTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.windowsTabPage.ResumeLayout(false);
            this.windowsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
            this.hotKeysTabPage.ResumeLayout(false);
            this.hotKeysTabPage.PerformLayout();
            this.pluginTabPage.ResumeLayout(false);
            this.pluginTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluginImagePictureBox)).EndInit();
            this.pluginInfoGroupBox.ResumeLayout(false);
            this.pluginInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabControl optionsTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage pluginTabPage;
        private System.Windows.Forms.GroupBox pluginInfoGroupBox;
        private System.Windows.Forms.ComboBox pluginsComboBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label descTitleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label authorTitleLabel;
        private System.Windows.Forms.Button pluginAboutButton;
        private System.Windows.Forms.Button pluginOptionsButton;
        private System.Windows.Forms.Label pluginDirLabel;
        private System.Windows.Forms.CheckBox startupCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.PictureBox pluginImagePictureBox;
        private System.Windows.Forms.Button removePluginDirButton;
        private System.Windows.Forms.Button addPluginDirButton;
        private System.Windows.Forms.ListBox pluginDirListBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label versionPluginLabel;
        private System.Windows.Forms.CheckBox enabledPluginCheckBox;
        private System.Windows.Forms.TabPage hotKeysTabPage;
        private System.Windows.Forms.TabPage windowsTabPage;
        private System.Windows.Forms.Label nextEntryLabel;
        private System.Windows.Forms.Label firstEntryLabel;
        private System.Windows.Forms.Label previousEntryLabel;
        private System.Windows.Forms.TextBox showWindowTextBox;
        private System.Windows.Forms.Label selectedEntryLabel;
        private System.Windows.Forms.TextBox upEntryTextBox;
        private System.Windows.Forms.TextBox copyEntryTextBox;
        private System.Windows.Forms.TextBox downEntryTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.CheckBox savePosCheckBox;
        private System.Windows.Forms.CheckBox onTopCheckBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.NumericUpDown opacityNumericUpDown;
        private System.Windows.Forms.CheckBox opacityCheckBox;
        private System.Windows.Forms.Button resetColorButton;
        private System.Windows.Forms.Button applyButton;
    }
}