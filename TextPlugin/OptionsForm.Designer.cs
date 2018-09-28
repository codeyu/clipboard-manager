namespace TextPlugin
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
            this.firstEntryTextBox = new System.Windows.Forms.TextBox();
            this.hotKeysGroupBox = new System.Windows.Forms.GroupBox();
            this.pasteOnComboBox = new System.Windows.Forms.ComboBox();
            this.pasteOnLabel = new System.Windows.Forms.Label();
            this.nextEntryLabel = new System.Windows.Forms.Label();
            this.previousEntryLabel = new System.Windows.Forms.Label();
            this.selectedEntryLabel = new System.Windows.Forms.Label();
            this.firstEntryLabel = new System.Windows.Forms.Label();
            this.selectedEntryTextBox = new System.Windows.Forms.TextBox();
            this.previousEntryTextBox = new System.Windows.Forms.TextBox();
            this.nextEntryTextBox = new System.Windows.Forms.TextBox();
            this.emailUrlGroupBox = new System.Windows.Forms.GroupBox();
            this.urlToClientCheckBox = new System.Windows.Forms.CheckBox();
            this.urlToEntryListCheckBox = new System.Windows.Forms.CheckBox();
            this.emailToClientCheckBox = new System.Windows.Forms.CheckBox();
            this.emailToEntryListCheckBox = new System.Windows.Forms.CheckBox();
            this.entryListGroupBox = new System.Windows.Forms.GroupBox();
            this.entryListEditButton = new System.Windows.Forms.Button();
            this.entryListMaxLengthTextBox = new System.Windows.Forms.TextBox();
            this.entryListMaxLengthLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.hotKeysGroupBox.SuspendLayout();
            this.emailUrlGroupBox.SuspendLayout();
            this.entryListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstEntryTextBox
            // 
            this.firstEntryTextBox.Location = new System.Drawing.Point(73, 19);
            this.firstEntryTextBox.MaxLength = 1;
            this.firstEntryTextBox.Name = "firstEntryTextBox";
            this.firstEntryTextBox.Size = new System.Drawing.Size(140, 20);
            this.firstEntryTextBox.TabIndex = 1;
            this.firstEntryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstEntryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstEntryTextBox_KeyPress);
            this.firstEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstEntryTextBox_KeyDown);
            // 
            // hotKeysGroupBox
            // 
            this.hotKeysGroupBox.Controls.Add(this.pasteOnComboBox);
            this.hotKeysGroupBox.Controls.Add(this.pasteOnLabel);
            this.hotKeysGroupBox.Controls.Add(this.nextEntryLabel);
            this.hotKeysGroupBox.Controls.Add(this.previousEntryLabel);
            this.hotKeysGroupBox.Controls.Add(this.selectedEntryLabel);
            this.hotKeysGroupBox.Controls.Add(this.firstEntryLabel);
            this.hotKeysGroupBox.Controls.Add(this.selectedEntryTextBox);
            this.hotKeysGroupBox.Controls.Add(this.previousEntryTextBox);
            this.hotKeysGroupBox.Controls.Add(this.nextEntryTextBox);
            this.hotKeysGroupBox.Controls.Add(this.firstEntryTextBox);
            this.hotKeysGroupBox.Location = new System.Drawing.Point(208, 0);
            this.hotKeysGroupBox.Name = "hotKeysGroupBox";
            this.hotKeysGroupBox.Size = new System.Drawing.Size(221, 161);
            this.hotKeysGroupBox.TabIndex = 2;
            this.hotKeysGroupBox.TabStop = false;
            this.hotKeysGroupBox.Text = "Entry List Hotkeys";
            // 
            // pasteOnComboBox
            // 
            this.pasteOnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pasteOnComboBox.FormattingEnabled = true;
            this.pasteOnComboBox.Items.AddRange(new object[] {
            "Mouse Pointed",
            "Foreground"});
            this.pasteOnComboBox.Location = new System.Drawing.Point(119, 134);
            this.pasteOnComboBox.Name = "pasteOnComboBox";
            this.pasteOnComboBox.Size = new System.Drawing.Size(94, 21);
            this.pasteOnComboBox.TabIndex = 5;
            // 
            // pasteOnLabel
            // 
            this.pasteOnLabel.AutoSize = true;
            this.pasteOnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteOnLabel.Location = new System.Drawing.Point(5, 137);
            this.pasteOnLabel.Name = "pasteOnLabel";
            this.pasteOnLabel.Size = new System.Drawing.Size(107, 13);
            this.pasteOnLabel.TabIndex = 9;
            this.pasteOnLabel.Text = "Paste on window:";
            // 
            // nextEntryLabel
            // 
            this.nextEntryLabel.AutoSize = true;
            this.nextEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextEntryLabel.Location = new System.Drawing.Point(28, 100);
            this.nextEntryLabel.Name = "nextEntryLabel";
            this.nextEntryLabel.Size = new System.Drawing.Size(37, 13);
            this.nextEntryLabel.TabIndex = 8;
            this.nextEntryLabel.Text = "Next:";
            // 
            // previousEntryLabel
            // 
            this.previousEntryLabel.AutoSize = true;
            this.previousEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousEntryLabel.Location = new System.Drawing.Point(5, 74);
            this.previousEntryLabel.Name = "previousEntryLabel";
            this.previousEntryLabel.Size = new System.Drawing.Size(60, 13);
            this.previousEntryLabel.TabIndex = 7;
            this.previousEntryLabel.Text = "Previous:";
            // 
            // selectedEntryLabel
            // 
            this.selectedEntryLabel.AutoSize = true;
            this.selectedEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedEntryLabel.Location = new System.Drawing.Point(4, 48);
            this.selectedEntryLabel.Name = "selectedEntryLabel";
            this.selectedEntryLabel.Size = new System.Drawing.Size(61, 13);
            this.selectedEntryLabel.TabIndex = 6;
            this.selectedEntryLabel.Text = "Selected:";
            // 
            // firstEntryLabel
            // 
            this.firstEntryLabel.AutoSize = true;
            this.firstEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstEntryLabel.Location = new System.Drawing.Point(30, 22);
            this.firstEntryLabel.Name = "firstEntryLabel";
            this.firstEntryLabel.Size = new System.Drawing.Size(35, 13);
            this.firstEntryLabel.TabIndex = 5;
            this.firstEntryLabel.Text = "First:";
            // 
            // selectedEntryTextBox
            // 
            this.selectedEntryTextBox.Location = new System.Drawing.Point(73, 45);
            this.selectedEntryTextBox.MaxLength = 1;
            this.selectedEntryTextBox.Name = "selectedEntryTextBox";
            this.selectedEntryTextBox.Size = new System.Drawing.Size(140, 20);
            this.selectedEntryTextBox.TabIndex = 2;
            this.selectedEntryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectedEntryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.selectedEntryTextBox_KeyPress);
            this.selectedEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selectedEntryTextBox_KeyDown);
            // 
            // previousEntryTextBox
            // 
            this.previousEntryTextBox.Location = new System.Drawing.Point(73, 71);
            this.previousEntryTextBox.MaxLength = 1;
            this.previousEntryTextBox.Name = "previousEntryTextBox";
            this.previousEntryTextBox.Size = new System.Drawing.Size(140, 20);
            this.previousEntryTextBox.TabIndex = 3;
            this.previousEntryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.previousEntryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.previousEntryTextBox_KeyPress);
            this.previousEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.previousEntryTextBox_KeyDown);
            // 
            // nextEntryTextBox
            // 
            this.nextEntryTextBox.Location = new System.Drawing.Point(73, 97);
            this.nextEntryTextBox.MaxLength = 1;
            this.nextEntryTextBox.Name = "nextEntryTextBox";
            this.nextEntryTextBox.Size = new System.Drawing.Size(140, 20);
            this.nextEntryTextBox.TabIndex = 4;
            this.nextEntryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nextEntryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nextEntryTextBox_KeyPress);
            this.nextEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextEntryTextBox_KeyDown);
            // 
            // emailUrlGroupBox
            // 
            this.emailUrlGroupBox.Controls.Add(this.urlToClientCheckBox);
            this.emailUrlGroupBox.Controls.Add(this.urlToEntryListCheckBox);
            this.emailUrlGroupBox.Controls.Add(this.emailToClientCheckBox);
            this.emailUrlGroupBox.Controls.Add(this.emailToEntryListCheckBox);
            this.emailUrlGroupBox.Location = new System.Drawing.Point(2, 0);
            this.emailUrlGroupBox.Name = "emailUrlGroupBox";
            this.emailUrlGroupBox.Size = new System.Drawing.Size(200, 111);
            this.emailUrlGroupBox.TabIndex = 0;
            this.emailUrlGroupBox.TabStop = false;
            this.emailUrlGroupBox.Text = "Emails && Urls";
            // 
            // urlToClientCheckBox
            // 
            this.urlToClientCheckBox.AutoSize = true;
            this.urlToClientCheckBox.Location = new System.Drawing.Point(6, 84);
            this.urlToClientCheckBox.Name = "urlToClientCheckBox";
            this.urlToClientCheckBox.Size = new System.Drawing.Size(143, 17);
            this.urlToClientCheckBox.TabIndex = 4;
            this.urlToClientCheckBox.Text = "Open new Url in Browser";
            this.urlToClientCheckBox.UseVisualStyleBackColor = true;
            // 
            // urlToEntryListCheckBox
            // 
            this.urlToEntryListCheckBox.AutoSize = true;
            this.urlToEntryListCheckBox.Location = new System.Drawing.Point(6, 38);
            this.urlToEntryListCheckBox.Name = "urlToEntryListCheckBox";
            this.urlToEntryListCheckBox.Size = new System.Drawing.Size(124, 17);
            this.urlToEntryListCheckBox.TabIndex = 2;
            this.urlToEntryListCheckBox.Text = "Add Urls to Entry List";
            this.urlToEntryListCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailToClientCheckBox
            // 
            this.emailToClientCheckBox.AutoSize = true;
            this.emailToClientCheckBox.Location = new System.Drawing.Point(6, 61);
            this.emailToClientCheckBox.Name = "emailToClientCheckBox";
            this.emailToClientCheckBox.Size = new System.Drawing.Size(171, 17);
            this.emailToClientCheckBox.TabIndex = 3;
            this.emailToClientCheckBox.Text = "Open new Email in Email Client";
            this.emailToClientCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailToEntryListCheckBox
            // 
            this.emailToEntryListCheckBox.AutoSize = true;
            this.emailToEntryListCheckBox.Location = new System.Drawing.Point(6, 15);
            this.emailToEntryListCheckBox.Name = "emailToEntryListCheckBox";
            this.emailToEntryListCheckBox.Size = new System.Drawing.Size(136, 17);
            this.emailToEntryListCheckBox.TabIndex = 1;
            this.emailToEntryListCheckBox.Text = "Add Emails to Entry List";
            this.emailToEntryListCheckBox.UseVisualStyleBackColor = true;
            // 
            // entryListGroupBox
            // 
            this.entryListGroupBox.Controls.Add(this.entryListEditButton);
            this.entryListGroupBox.Controls.Add(this.entryListMaxLengthTextBox);
            this.entryListGroupBox.Controls.Add(this.entryListMaxLengthLabel);
            this.entryListGroupBox.Location = new System.Drawing.Point(2, 117);
            this.entryListGroupBox.Name = "entryListGroupBox";
            this.entryListGroupBox.Size = new System.Drawing.Size(200, 44);
            this.entryListGroupBox.TabIndex = 0;
            this.entryListGroupBox.TabStop = false;
            this.entryListGroupBox.Text = "Entry List";
            // 
            // entryListEditButton
            // 
            this.entryListEditButton.Location = new System.Drawing.Point(137, 15);
            this.entryListEditButton.Name = "entryListEditButton";
            this.entryListEditButton.Size = new System.Drawing.Size(57, 23);
            this.entryListEditButton.TabIndex = 2;
            this.entryListEditButton.Text = "Edit List";
            this.entryListEditButton.UseVisualStyleBackColor = true;
            this.entryListEditButton.Click += new System.EventHandler(this.entryListEditButton_Click);
            // 
            // entryListMaxLengthTextBox
            // 
            this.entryListMaxLengthTextBox.Location = new System.Drawing.Point(86, 17);
            this.entryListMaxLengthTextBox.Name = "entryListMaxLengthTextBox";
            this.entryListMaxLengthTextBox.Size = new System.Drawing.Size(35, 20);
            this.entryListMaxLengthTextBox.TabIndex = 1;
            this.entryListMaxLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entryListMaxLengthTextBox_KeyPress);
            // 
            // entryListMaxLengthLabel
            // 
            this.entryListMaxLengthLabel.AutoSize = true;
            this.entryListMaxLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryListMaxLengthLabel.Location = new System.Drawing.Point(3, 20);
            this.entryListMaxLengthLabel.Name = "entryListMaxLengthLabel";
            this.entryListMaxLengthLabel.Size = new System.Drawing.Size(77, 13);
            this.entryListMaxLengthLabel.TabIndex = 0;
            this.entryListMaxLengthLabel.Text = "Max Length:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(354, 167);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(273, 167);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(431, 195);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.emailUrlGroupBox);
            this.Controls.Add(this.entryListGroupBox);
            this.Controls.Add(this.hotKeysGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Plugin Options";
            this.hotKeysGroupBox.ResumeLayout(false);
            this.hotKeysGroupBox.PerformLayout();
            this.emailUrlGroupBox.ResumeLayout(false);
            this.emailUrlGroupBox.PerformLayout();
            this.entryListGroupBox.ResumeLayout(false);
            this.entryListGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstEntryTextBox;
        private System.Windows.Forms.GroupBox hotKeysGroupBox;
        private System.Windows.Forms.GroupBox emailUrlGroupBox;
        private System.Windows.Forms.GroupBox entryListGroupBox;
        private System.Windows.Forms.CheckBox urlToClientCheckBox;
        private System.Windows.Forms.CheckBox urlToEntryListCheckBox;
        private System.Windows.Forms.CheckBox emailToClientCheckBox;
        private System.Windows.Forms.CheckBox emailToEntryListCheckBox;
        private System.Windows.Forms.TextBox entryListMaxLengthTextBox;
        private System.Windows.Forms.Label entryListMaxLengthLabel;
        private System.Windows.Forms.Button entryListEditButton;
        private System.Windows.Forms.TextBox selectedEntryTextBox;
        private System.Windows.Forms.TextBox previousEntryTextBox;
        private System.Windows.Forms.TextBox nextEntryTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label nextEntryLabel;
        private System.Windows.Forms.Label previousEntryLabel;
        private System.Windows.Forms.Label selectedEntryLabel;
        private System.Windows.Forms.Label firstEntryLabel;
        private System.Windows.Forms.ComboBox pasteOnComboBox;
        private System.Windows.Forms.Label pasteOnLabel;
    }
}