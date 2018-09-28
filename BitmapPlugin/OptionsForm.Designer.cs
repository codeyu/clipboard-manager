namespace BitmapPlugin
{
    partial class OptionsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.formatGroupBox = new System.Windows.Forms.GroupBox();
            this.animatedGifPanel = new System.Windows.Forms.Panel();
            this.anigifPanelAnimationGroupBox = new System.Windows.Forms.GroupBox();
            this.anigifPanelFrameNumberTextBox = new System.Windows.Forms.TextBox();
            this.anigifPanelFrameNumberLabel = new System.Windows.Forms.Label();
            this.anigifPanelRepeatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.anigifPanelRepeatLabel = new System.Windows.Forms.Label();
            this.anigifPanelFrameRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.anigifPanelFrameRateLabel = new System.Windows.Forms.Label();
            this.anigifPanelImageGroupBox = new System.Windows.Forms.GroupBox();
            this.anigifPanelNoTrasparentCheckBox = new System.Windows.Forms.CheckBox();
            this.anigifPanelTrasparentPictureBox = new System.Windows.Forms.PictureBox();
            this.anigifPanelTrasparentLabel = new System.Windows.Forms.Label();
            this.anigifPanelQualityTrackBar = new System.Windows.Forms.TrackBar();
            this.anigifPanelQualityLabel = new System.Windows.Forms.Label();
            this.jpegPanel = new System.Windows.Forms.Panel();
            this.jpegPanelEncodingGroupBox = new System.Windows.Forms.GroupBox();
            this.jpegPanelEncodingCheckBox = new System.Windows.Forms.CheckBox();
            this.jpegPanelQualityGroupBox = new System.Windows.Forms.GroupBox();
            this.jpegPanelQualityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.jpegPanelQualityLabel = new System.Windows.Forms.Label();
            this.jpegPanelCompressionLabel = new System.Windows.Forms.Label();
            this.jpegPanelQualityTrackBar = new System.Windows.Forms.TrackBar();
            this.bmpGifPanel = new System.Windows.Forms.Panel();
            this.bmgGifLabel = new System.Windows.Forms.Label();
            this.pngPanel = new System.Windows.Forms.Panel();
            this.pngPanelEncodingGroupBox = new System.Windows.Forms.GroupBox();
            this.pngPanelInterlacedCheckBox = new System.Windows.Forms.CheckBox();
            this.tiffPanel = new System.Windows.Forms.Panel();
            this.tiffPanelCompressionGroupBox = new System.Windows.Forms.GroupBox();
            this.tiffPanelCompressionComboBox = new System.Windows.Forms.ComboBox();
            this.saveFormatLabel = new System.Windows.Forms.Label();
            this.saveFormatComboBox = new System.Windows.Forms.ComboBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outExampleNameLabel = new System.Windows.Forms.Label();
            this.outExampleLabel = new System.Windows.Forms.Label();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.outSuffixLabel = new System.Windows.Forms.Label();
            this.outPrefixLabel = new System.Windows.Forms.Label();
            this.outDirButton = new System.Windows.Forms.Button();
            this.outDirTextBox = new System.Windows.Forms.TextBox();
            this.outDirLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.formatGroupBox.SuspendLayout();
            this.animatedGifPanel.SuspendLayout();
            this.anigifPanelAnimationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anigifPanelRepeatNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anigifPanelFrameRateNumericUpDown)).BeginInit();
            this.anigifPanelImageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anigifPanelTrasparentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anigifPanelQualityTrackBar)).BeginInit();
            this.jpegPanel.SuspendLayout();
            this.jpegPanelEncodingGroupBox.SuspendLayout();
            this.jpegPanelQualityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jpegPanelQualityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jpegPanelQualityTrackBar)).BeginInit();
            this.bmpGifPanel.SuspendLayout();
            this.pngPanel.SuspendLayout();
            this.pngPanelEncodingGroupBox.SuspendLayout();
            this.tiffPanel.SuspendLayout();
            this.tiffPanelCompressionGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(134, 326);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(215, 326);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select the output directory for the image files";
            // 
            // formatGroupBox
            // 
            this.formatGroupBox.Controls.Add(this.animatedGifPanel);
            this.formatGroupBox.Controls.Add(this.jpegPanel);
            this.formatGroupBox.Controls.Add(this.bmpGifPanel);
            this.formatGroupBox.Controls.Add(this.pngPanel);
            this.formatGroupBox.Controls.Add(this.tiffPanel);
            this.formatGroupBox.Controls.Add(this.saveFormatLabel);
            this.formatGroupBox.Controls.Add(this.saveFormatComboBox);
            this.formatGroupBox.Location = new System.Drawing.Point(3, 2);
            this.formatGroupBox.Name = "formatGroupBox";
            this.formatGroupBox.Size = new System.Drawing.Size(287, 182);
            this.formatGroupBox.TabIndex = 12;
            this.formatGroupBox.TabStop = false;
            this.formatGroupBox.Text = "Format Options";
            // 
            // animatedGifPanel
            // 
            this.animatedGifPanel.Controls.Add(this.anigifPanelAnimationGroupBox);
            this.animatedGifPanel.Controls.Add(this.anigifPanelImageGroupBox);
            this.animatedGifPanel.Location = new System.Drawing.Point(9, 40);
            this.animatedGifPanel.Name = "animatedGifPanel";
            this.animatedGifPanel.Size = new System.Drawing.Size(271, 136);
            this.animatedGifPanel.TabIndex = 12;
            // 
            // anigifPanelAnimationGroupBox
            // 
            this.anigifPanelAnimationGroupBox.Controls.Add(this.anigifPanelFrameNumberTextBox);
            this.anigifPanelAnimationGroupBox.Controls.Add(this.anigifPanelFrameNumberLabel);
            this.anigifPanelAnimationGroupBox.Controls.Add(this.anigifPanelRepeatNumericUpDown);
            this.anigifPanelAnimationGroupBox.Controls.Add(this.anigifPanelRepeatLabel);
            this.anigifPanelAnimationGroupBox.Controls.Add(this.anigifPanelFrameRateNumericUpDown);
            this.anigifPanelAnimationGroupBox.Controls.Add(this.anigifPanelFrameRateLabel);
            this.anigifPanelAnimationGroupBox.Location = new System.Drawing.Point(3, 85);
            this.anigifPanelAnimationGroupBox.Name = "anigifPanelAnimationGroupBox";
            this.anigifPanelAnimationGroupBox.Size = new System.Drawing.Size(265, 48);
            this.anigifPanelAnimationGroupBox.TabIndex = 18;
            this.anigifPanelAnimationGroupBox.TabStop = false;
            this.anigifPanelAnimationGroupBox.Text = "Animation Options";
            // 
            // anigifPanelFrameNumberTextBox
            // 
            this.anigifPanelFrameNumberTextBox.Location = new System.Drawing.Point(226, 16);
            this.anigifPanelFrameNumberTextBox.Name = "anigifPanelFrameNumberTextBox";
            this.anigifPanelFrameNumberTextBox.Size = new System.Drawing.Size(33, 20);
            this.anigifPanelFrameNumberTextBox.TabIndex = 23;
            this.anigifPanelFrameNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anigifPanelFrameNumberTextBox_KeyPress);
            // 
            // anigifPanelFrameNumberLabel
            // 
            this.anigifPanelFrameNumberLabel.AutoSize = true;
            this.anigifPanelFrameNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anigifPanelFrameNumberLabel.Location = new System.Drawing.Point(176, 19);
            this.anigifPanelFrameNumberLabel.Name = "anigifPanelFrameNumberLabel";
            this.anigifPanelFrameNumberLabel.Size = new System.Drawing.Size(53, 13);
            this.anigifPanelFrameNumberLabel.TabIndex = 22;
            this.anigifPanelFrameNumberLabel.Text = "#Frame:";
            // 
            // anigifPanelRepeatNumericUpDown
            // 
            this.anigifPanelRepeatNumericUpDown.Location = new System.Drawing.Point(132, 17);
            this.anigifPanelRepeatNumericUpDown.Name = "anigifPanelRepeatNumericUpDown";
            this.anigifPanelRepeatNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.anigifPanelRepeatNumericUpDown.TabIndex = 21;
            // 
            // anigifPanelRepeatLabel
            // 
            this.anigifPanelRepeatLabel.AutoSize = true;
            this.anigifPanelRepeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anigifPanelRepeatLabel.Location = new System.Drawing.Point(83, 19);
            this.anigifPanelRepeatLabel.Name = "anigifPanelRepeatLabel";
            this.anigifPanelRepeatLabel.Size = new System.Drawing.Size(52, 13);
            this.anigifPanelRepeatLabel.TabIndex = 7;
            this.anigifPanelRepeatLabel.Text = "Repeat:";
            // 
            // anigifPanelFrameRateNumericUpDown
            // 
            this.anigifPanelFrameRateNumericUpDown.Location = new System.Drawing.Point(36, 17);
            this.anigifPanelFrameRateNumericUpDown.Name = "anigifPanelFrameRateNumericUpDown";
            this.anigifPanelFrameRateNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.anigifPanelFrameRateNumericUpDown.TabIndex = 20;
            // 
            // anigifPanelFrameRateLabel
            // 
            this.anigifPanelFrameRateLabel.AutoSize = true;
            this.anigifPanelFrameRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anigifPanelFrameRateLabel.Location = new System.Drawing.Point(6, 19);
            this.anigifPanelFrameRateLabel.Name = "anigifPanelFrameRateLabel";
            this.anigifPanelFrameRateLabel.Size = new System.Drawing.Size(34, 13);
            this.anigifPanelFrameRateLabel.TabIndex = 5;
            this.anigifPanelFrameRateLabel.Text = "FPS:";
            // 
            // anigifPanelImageGroupBox
            // 
            this.anigifPanelImageGroupBox.Controls.Add(this.anigifPanelNoTrasparentCheckBox);
            this.anigifPanelImageGroupBox.Controls.Add(this.anigifPanelTrasparentPictureBox);
            this.anigifPanelImageGroupBox.Controls.Add(this.anigifPanelTrasparentLabel);
            this.anigifPanelImageGroupBox.Controls.Add(this.anigifPanelQualityTrackBar);
            this.anigifPanelImageGroupBox.Controls.Add(this.anigifPanelQualityLabel);
            this.anigifPanelImageGroupBox.Location = new System.Drawing.Point(3, 0);
            this.anigifPanelImageGroupBox.Name = "anigifPanelImageGroupBox";
            this.anigifPanelImageGroupBox.Size = new System.Drawing.Size(265, 79);
            this.anigifPanelImageGroupBox.TabIndex = 17;
            this.anigifPanelImageGroupBox.TabStop = false;
            this.anigifPanelImageGroupBox.Text = "Image Options";
            // 
            // anigifPanelNoTrasparentCheckBox
            // 
            this.anigifPanelNoTrasparentCheckBox.AutoSize = true;
            this.anigifPanelNoTrasparentCheckBox.Location = new System.Drawing.Point(121, 19);
            this.anigifPanelNoTrasparentCheckBox.Name = "anigifPanelNoTrasparentCheckBox";
            this.anigifPanelNoTrasparentCheckBox.Size = new System.Drawing.Size(121, 17);
            this.anigifPanelNoTrasparentCheckBox.TabIndex = 22;
            this.anigifPanelNoTrasparentCheckBox.Text = "No Trasparent Color";
            this.anigifPanelNoTrasparentCheckBox.UseVisualStyleBackColor = true;
            this.anigifPanelNoTrasparentCheckBox.CheckedChanged += new System.EventHandler(this.anigifPanelNoTrasparentCheckBox_CheckedChanged);
            // 
            // anigifPanelTrasparentPictureBox
            // 
            this.anigifPanelTrasparentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anigifPanelTrasparentPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anigifPanelTrasparentPictureBox.Location = new System.Drawing.Point(84, 17);
            this.anigifPanelTrasparentPictureBox.Name = "anigifPanelTrasparentPictureBox";
            this.anigifPanelTrasparentPictureBox.Size = new System.Drawing.Size(24, 18);
            this.anigifPanelTrasparentPictureBox.TabIndex = 21;
            this.anigifPanelTrasparentPictureBox.TabStop = false;
            this.anigifPanelTrasparentPictureBox.Click += new System.EventHandler(this.anigifPanelTrasparentPictureBox_Click);
            // 
            // anigifPanelTrasparentLabel
            // 
            this.anigifPanelTrasparentLabel.AutoSize = true;
            this.anigifPanelTrasparentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anigifPanelTrasparentLabel.Location = new System.Drawing.Point(6, 19);
            this.anigifPanelTrasparentLabel.Name = "anigifPanelTrasparentLabel";
            this.anigifPanelTrasparentLabel.Size = new System.Drawing.Size(72, 13);
            this.anigifPanelTrasparentLabel.TabIndex = 20;
            this.anigifPanelTrasparentLabel.Text = "Trasparent:";
            // 
            // anigifPanelQualityTrackBar
            // 
            this.anigifPanelQualityTrackBar.Location = new System.Drawing.Point(79, 42);
            this.anigifPanelQualityTrackBar.Maximum = 20;
            this.anigifPanelQualityTrackBar.Minimum = 1;
            this.anigifPanelQualityTrackBar.Name = "anigifPanelQualityTrackBar";
            this.anigifPanelQualityTrackBar.Size = new System.Drawing.Size(175, 34);
            this.anigifPanelQualityTrackBar.TabIndex = 23;
            this.anigifPanelQualityTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.anigifPanelQualityTrackBar.Value = 20;
            // 
            // anigifPanelQualityLabel
            // 
            this.anigifPanelQualityLabel.AutoSize = true;
            this.anigifPanelQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anigifPanelQualityLabel.Location = new System.Drawing.Point(28, 51);
            this.anigifPanelQualityLabel.Name = "anigifPanelQualityLabel";
            this.anigifPanelQualityLabel.Size = new System.Drawing.Size(50, 13);
            this.anigifPanelQualityLabel.TabIndex = 17;
            this.anigifPanelQualityLabel.Text = "Quality:";
            // 
            // jpegPanel
            // 
            this.jpegPanel.Controls.Add(this.jpegPanelEncodingGroupBox);
            this.jpegPanel.Controls.Add(this.jpegPanelQualityGroupBox);
            this.jpegPanel.Location = new System.Drawing.Point(9, 40);
            this.jpegPanel.Name = "jpegPanel";
            this.jpegPanel.Size = new System.Drawing.Size(271, 136);
            this.jpegPanel.TabIndex = 10;
            // 
            // jpegPanelEncodingGroupBox
            // 
            this.jpegPanelEncodingGroupBox.Controls.Add(this.jpegPanelEncodingCheckBox);
            this.jpegPanelEncodingGroupBox.Location = new System.Drawing.Point(3, 88);
            this.jpegPanelEncodingGroupBox.Name = "jpegPanelEncodingGroupBox";
            this.jpegPanelEncodingGroupBox.Size = new System.Drawing.Size(265, 45);
            this.jpegPanelEncodingGroupBox.TabIndex = 1;
            this.jpegPanelEncodingGroupBox.TabStop = false;
            this.jpegPanelEncodingGroupBox.Text = "Encoding";
            // 
            // jpegPanelEncodingCheckBox
            // 
            this.jpegPanelEncodingCheckBox.AutoSize = true;
            this.jpegPanelEncodingCheckBox.Location = new System.Drawing.Point(6, 19);
            this.jpegPanelEncodingCheckBox.Name = "jpegPanelEncodingCheckBox";
            this.jpegPanelEncodingCheckBox.Size = new System.Drawing.Size(81, 17);
            this.jpegPanelEncodingCheckBox.TabIndex = 3;
            this.jpegPanelEncodingCheckBox.Text = "Progressive";
            this.jpegPanelEncodingCheckBox.UseVisualStyleBackColor = true;
            // 
            // jpegPanelQualityGroupBox
            // 
            this.jpegPanelQualityGroupBox.Controls.Add(this.jpegPanelQualityNumericUpDown);
            this.jpegPanelQualityGroupBox.Controls.Add(this.jpegPanelQualityLabel);
            this.jpegPanelQualityGroupBox.Controls.Add(this.jpegPanelCompressionLabel);
            this.jpegPanelQualityGroupBox.Controls.Add(this.jpegPanelQualityTrackBar);
            this.jpegPanelQualityGroupBox.Location = new System.Drawing.Point(3, 0);
            this.jpegPanelQualityGroupBox.Name = "jpegPanelQualityGroupBox";
            this.jpegPanelQualityGroupBox.Size = new System.Drawing.Size(265, 82);
            this.jpegPanelQualityGroupBox.TabIndex = 0;
            this.jpegPanelQualityGroupBox.TabStop = false;
            this.jpegPanelQualityGroupBox.Text = "Image Quality";
            // 
            // jpegPanelQualityNumericUpDown
            // 
            this.jpegPanelQualityNumericUpDown.Location = new System.Drawing.Point(114, 54);
            this.jpegPanelQualityNumericUpDown.Name = "jpegPanelQualityNumericUpDown";
            this.jpegPanelQualityNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.jpegPanelQualityNumericUpDown.TabIndex = 3;
            this.jpegPanelQualityNumericUpDown.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.jpegPanelQualityNumericUpDown.ValueChanged += new System.EventHandler(this.jpegPanelQualityNumericUpDown_ValueChanged);
            // 
            // jpegPanelQualityLabel
            // 
            this.jpegPanelQualityLabel.AutoSize = true;
            this.jpegPanelQualityLabel.Location = new System.Drawing.Point(220, 56);
            this.jpegPanelQualityLabel.Name = "jpegPanelQualityLabel";
            this.jpegPanelQualityLabel.Size = new System.Drawing.Size(39, 13);
            this.jpegPanelQualityLabel.TabIndex = 2;
            this.jpegPanelQualityLabel.Text = "Quality";
            // 
            // jpegPanelCompressionLabel
            // 
            this.jpegPanelCompressionLabel.AutoSize = true;
            this.jpegPanelCompressionLabel.Location = new System.Drawing.Point(6, 56);
            this.jpegPanelCompressionLabel.Name = "jpegPanelCompressionLabel";
            this.jpegPanelCompressionLabel.Size = new System.Drawing.Size(67, 13);
            this.jpegPanelCompressionLabel.TabIndex = 1;
            this.jpegPanelCompressionLabel.Text = "Compression";
            // 
            // jpegPanelQualityTrackBar
            // 
            this.jpegPanelQualityTrackBar.LargeChange = 10;
            this.jpegPanelQualityTrackBar.Location = new System.Drawing.Point(9, 19);
            this.jpegPanelQualityTrackBar.Maximum = 100;
            this.jpegPanelQualityTrackBar.Name = "jpegPanelQualityTrackBar";
            this.jpegPanelQualityTrackBar.Size = new System.Drawing.Size(250, 34);
            this.jpegPanelQualityTrackBar.TabIndex = 0;
            this.jpegPanelQualityTrackBar.TickFrequency = 10;
            this.jpegPanelQualityTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.jpegPanelQualityTrackBar.Value = 80;
            this.jpegPanelQualityTrackBar.Scroll += new System.EventHandler(this.jpegPanelQualityTrackBar_Scroll);
            // 
            // bmpGifPanel
            // 
            this.bmpGifPanel.Controls.Add(this.bmgGifLabel);
            this.bmpGifPanel.Location = new System.Drawing.Point(9, 40);
            this.bmpGifPanel.Name = "bmpGifPanel";
            this.bmpGifPanel.Size = new System.Drawing.Size(271, 136);
            this.bmpGifPanel.TabIndex = 9;
            // 
            // bmgGifLabel
            // 
            this.bmgGifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmgGifLabel.Location = new System.Drawing.Point(0, 0);
            this.bmgGifLabel.Name = "bmgGifLabel";
            this.bmgGifLabel.Size = new System.Drawing.Size(271, 136);
            this.bmgGifLabel.TabIndex = 0;
            this.bmgGifLabel.Text = "Nothing to set";
            this.bmgGifLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pngPanel
            // 
            this.pngPanel.Controls.Add(this.pngPanelEncodingGroupBox);
            this.pngPanel.Location = new System.Drawing.Point(9, 40);
            this.pngPanel.Name = "pngPanel";
            this.pngPanel.Size = new System.Drawing.Size(271, 48);
            this.pngPanel.TabIndex = 11;
            // 
            // pngPanelEncodingGroupBox
            // 
            this.pngPanelEncodingGroupBox.Controls.Add(this.pngPanelInterlacedCheckBox);
            this.pngPanelEncodingGroupBox.Location = new System.Drawing.Point(3, 0);
            this.pngPanelEncodingGroupBox.Name = "pngPanelEncodingGroupBox";
            this.pngPanelEncodingGroupBox.Size = new System.Drawing.Size(265, 45);
            this.pngPanelEncodingGroupBox.TabIndex = 3;
            this.pngPanelEncodingGroupBox.TabStop = false;
            this.pngPanelEncodingGroupBox.Text = "Encoding";
            // 
            // pngPanelInterlacedCheckBox
            // 
            this.pngPanelInterlacedCheckBox.AutoSize = true;
            this.pngPanelInterlacedCheckBox.Location = new System.Drawing.Point(6, 19);
            this.pngPanelInterlacedCheckBox.Name = "pngPanelInterlacedCheckBox";
            this.pngPanelInterlacedCheckBox.Size = new System.Drawing.Size(140, 17);
            this.pngPanelInterlacedCheckBox.TabIndex = 2;
            this.pngPanelInterlacedCheckBox.Text = "Scan Method Interlaced";
            this.pngPanelInterlacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // tiffPanel
            // 
            this.tiffPanel.Controls.Add(this.tiffPanelCompressionGroupBox);
            this.tiffPanel.Location = new System.Drawing.Point(9, 40);
            this.tiffPanel.Name = "tiffPanel";
            this.tiffPanel.Size = new System.Drawing.Size(271, 53);
            this.tiffPanel.TabIndex = 13;
            // 
            // tiffPanelCompressionGroupBox
            // 
            this.tiffPanelCompressionGroupBox.Controls.Add(this.tiffPanelCompressionComboBox);
            this.tiffPanelCompressionGroupBox.Location = new System.Drawing.Point(3, 0);
            this.tiffPanelCompressionGroupBox.Name = "tiffPanelCompressionGroupBox";
            this.tiffPanelCompressionGroupBox.Size = new System.Drawing.Size(265, 51);
            this.tiffPanelCompressionGroupBox.TabIndex = 1;
            this.tiffPanelCompressionGroupBox.TabStop = false;
            this.tiffPanelCompressionGroupBox.Text = "Compression";
            // 
            // tiffPanelCompressionComboBox
            // 
            this.tiffPanelCompressionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiffPanelCompressionComboBox.FormattingEnabled = true;
            this.tiffPanelCompressionComboBox.Items.AddRange(new object[] {
            "None",
            "CCITT Group 3",
            "CCITT Group 4",
            "LZW",
            "RLE"});
            this.tiffPanelCompressionComboBox.Location = new System.Drawing.Point(6, 19);
            this.tiffPanelCompressionComboBox.Name = "tiffPanelCompressionComboBox";
            this.tiffPanelCompressionComboBox.Size = new System.Drawing.Size(121, 21);
            this.tiffPanelCompressionComboBox.TabIndex = 0;
            // 
            // saveFormatLabel
            // 
            this.saveFormatLabel.AutoSize = true;
            this.saveFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFormatLabel.Location = new System.Drawing.Point(6, 16);
            this.saveFormatLabel.Name = "saveFormatLabel";
            this.saveFormatLabel.Size = new System.Drawing.Size(82, 13);
            this.saveFormatLabel.TabIndex = 8;
            this.saveFormatLabel.Text = "Save Format:";
            // 
            // saveFormatComboBox
            // 
            this.saveFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saveFormatComboBox.FormattingEnabled = true;
            this.saveFormatComboBox.Location = new System.Drawing.Point(94, 13);
            this.saveFormatComboBox.Name = "saveFormatComboBox";
            this.saveFormatComboBox.Size = new System.Drawing.Size(186, 21);
            this.saveFormatComboBox.TabIndex = 7;
            this.saveFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.saveFormatComboBox_SelectedIndexChanged);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outExampleNameLabel);
            this.outputGroupBox.Controls.Add(this.outExampleLabel);
            this.outputGroupBox.Controls.Add(this.prefixTextBox);
            this.outputGroupBox.Controls.Add(this.suffixTextBox);
            this.outputGroupBox.Controls.Add(this.outSuffixLabel);
            this.outputGroupBox.Controls.Add(this.outPrefixLabel);
            this.outputGroupBox.Controls.Add(this.outDirButton);
            this.outputGroupBox.Controls.Add(this.outDirTextBox);
            this.outputGroupBox.Controls.Add(this.outDirLabel);
            this.outputGroupBox.Location = new System.Drawing.Point(3, 190);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(287, 130);
            this.outputGroupBox.TabIndex = 0;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output Options";
            // 
            // outExampleNameLabel
            // 
            this.outExampleNameLabel.AutoSize = true;
            this.outExampleNameLabel.Location = new System.Drawing.Point(78, 103);
            this.outExampleNameLabel.Name = "outExampleNameLabel";
            this.outExampleNameLabel.Size = new System.Drawing.Size(45, 13);
            this.outExampleNameLabel.TabIndex = 20;
            this.outExampleNameLabel.Text = "###.ext";
            // 
            // outExampleLabel
            // 
            this.outExampleLabel.AutoSize = true;
            this.outExampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outExampleLabel.Location = new System.Drawing.Point(17, 103);
            this.outExampleLabel.Name = "outExampleLabel";
            this.outExampleLabel.Size = new System.Drawing.Size(58, 13);
            this.outExampleLabel.TabIndex = 19;
            this.outExampleLabel.Text = "Example:";
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(81, 48);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(173, 20);
            this.prefixTextBox.TabIndex = 15;
            this.prefixTextBox.TextChanged += new System.EventHandler(this.prefixTextBox_TextChanged);
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Location = new System.Drawing.Point(81, 74);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(173, 20);
            this.suffixTextBox.TabIndex = 16;
            this.suffixTextBox.TextChanged += new System.EventHandler(this.suffixTextBox_TextChanged);
            // 
            // outSuffixLabel
            // 
            this.outSuffixLabel.AutoSize = true;
            this.outSuffixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outSuffixLabel.Location = new System.Drawing.Point(32, 77);
            this.outSuffixLabel.Name = "outSuffixLabel";
            this.outSuffixLabel.Size = new System.Drawing.Size(43, 13);
            this.outSuffixLabel.TabIndex = 16;
            this.outSuffixLabel.Text = "Suffix:";
            // 
            // outPrefixLabel
            // 
            this.outPrefixLabel.AutoSize = true;
            this.outPrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outPrefixLabel.Location = new System.Drawing.Point(32, 51);
            this.outPrefixLabel.Name = "outPrefixLabel";
            this.outPrefixLabel.Size = new System.Drawing.Size(43, 13);
            this.outPrefixLabel.TabIndex = 15;
            this.outPrefixLabel.Text = "Prefix:";
            // 
            // outDirButton
            // 
            this.outDirButton.Location = new System.Drawing.Point(255, 13);
            this.outDirButton.Name = "outDirButton";
            this.outDirButton.Size = new System.Drawing.Size(25, 20);
            this.outDirButton.TabIndex = 14;
            this.outDirButton.Text = "...";
            this.outDirButton.UseVisualStyleBackColor = true;
            this.outDirButton.Click += new System.EventHandler(this.outDirButton_Click);
            // 
            // outDirTextBox
            // 
            this.outDirTextBox.Location = new System.Drawing.Point(81, 13);
            this.outDirTextBox.Name = "outDirTextBox";
            this.outDirTextBox.Size = new System.Drawing.Size(173, 20);
            this.outDirTextBox.TabIndex = 13;
            // 
            // outDirLabel
            // 
            this.outDirLabel.AutoSize = true;
            this.outDirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outDirLabel.Location = new System.Drawing.Point(6, 16);
            this.outDirLabel.Name = "outDirLabel";
            this.outDirLabel.Size = new System.Drawing.Size(69, 13);
            this.outDirLabel.TabIndex = 12;
            this.outDirLabel.Text = "Output Dir:";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(293, 351);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.formatGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Plugin Options";
            this.formatGroupBox.ResumeLayout(false);
            this.formatGroupBox.PerformLayout();
            this.animatedGifPanel.ResumeLayout(false);
            this.anigifPanelAnimationGroupBox.ResumeLayout(false);
            this.anigifPanelAnimationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anigifPanelRepeatNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anigifPanelFrameRateNumericUpDown)).EndInit();
            this.anigifPanelImageGroupBox.ResumeLayout(false);
            this.anigifPanelImageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anigifPanelTrasparentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anigifPanelQualityTrackBar)).EndInit();
            this.jpegPanel.ResumeLayout(false);
            this.jpegPanelEncodingGroupBox.ResumeLayout(false);
            this.jpegPanelEncodingGroupBox.PerformLayout();
            this.jpegPanelQualityGroupBox.ResumeLayout(false);
            this.jpegPanelQualityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jpegPanelQualityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jpegPanelQualityTrackBar)).EndInit();
            this.bmpGifPanel.ResumeLayout(false);
            this.pngPanel.ResumeLayout(false);
            this.pngPanelEncodingGroupBox.ResumeLayout(false);
            this.pngPanelEncodingGroupBox.PerformLayout();
            this.tiffPanel.ResumeLayout(false);
            this.tiffPanelCompressionGroupBox.ResumeLayout(false);
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox formatGroupBox;
        private System.Windows.Forms.Panel animatedGifPanel;
        private System.Windows.Forms.Panel jpegPanel;
        private System.Windows.Forms.GroupBox jpegPanelEncodingGroupBox;
        private System.Windows.Forms.CheckBox jpegPanelEncodingCheckBox;
        private System.Windows.Forms.GroupBox jpegPanelQualityGroupBox;
        private System.Windows.Forms.NumericUpDown jpegPanelQualityNumericUpDown;
        private System.Windows.Forms.Label jpegPanelQualityLabel;
        private System.Windows.Forms.Label jpegPanelCompressionLabel;
        private System.Windows.Forms.TrackBar jpegPanelQualityTrackBar;
        private System.Windows.Forms.Panel pngPanel;
        private System.Windows.Forms.GroupBox pngPanelEncodingGroupBox;
        private System.Windows.Forms.CheckBox pngPanelInterlacedCheckBox;
        private System.Windows.Forms.Panel tiffPanel;
        private System.Windows.Forms.GroupBox tiffPanelCompressionGroupBox;
        private System.Windows.Forms.ComboBox tiffPanelCompressionComboBox;
        private System.Windows.Forms.Panel bmpGifPanel;
        private System.Windows.Forms.Label bmgGifLabel;
        private System.Windows.Forms.Label saveFormatLabel;
        private System.Windows.Forms.ComboBox saveFormatComboBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button outDirButton;
        private System.Windows.Forms.TextBox outDirTextBox;
        private System.Windows.Forms.Label outDirLabel;
        private System.Windows.Forms.Label outExampleLabel;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.TextBox suffixTextBox;
        private System.Windows.Forms.Label outSuffixLabel;
        private System.Windows.Forms.Label outPrefixLabel;
        private System.Windows.Forms.Label outExampleNameLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox anigifPanelAnimationGroupBox;
        private System.Windows.Forms.GroupBox anigifPanelImageGroupBox;
        private System.Windows.Forms.Label anigifPanelTrasparentLabel;
        private System.Windows.Forms.TrackBar anigifPanelQualityTrackBar;
        private System.Windows.Forms.Label anigifPanelQualityLabel;
        private System.Windows.Forms.NumericUpDown anigifPanelRepeatNumericUpDown;
        private System.Windows.Forms.Label anigifPanelRepeatLabel;
        private System.Windows.Forms.NumericUpDown anigifPanelFrameRateNumericUpDown;
        private System.Windows.Forms.Label anigifPanelFrameRateLabel;
        private System.Windows.Forms.PictureBox anigifPanelTrasparentPictureBox;
        private System.Windows.Forms.CheckBox anigifPanelNoTrasparentCheckBox;
        private System.Windows.Forms.TextBox anigifPanelFrameNumberTextBox;
        private System.Windows.Forms.Label anigifPanelFrameNumberLabel;


    }
}