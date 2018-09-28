namespace TextPlugin {
    partial class EntryListEdit {
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
            this.entryListListBox = new System.Windows.Forms.ListBox();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.entrySaveButton = new System.Windows.Forms.Button();
            this.entryDeleteButton = new System.Windows.Forms.Button();
            this.entryListGroupBox = new System.Windows.Forms.GroupBox();
            this.entryAtLastButton = new System.Windows.Forms.Button();
            this.entryAtBottomButton = new System.Windows.Forms.Button();
            this.entryAtUpButton = new System.Windows.Forms.Button();
            this.entryAtFirstButton = new System.Windows.Forms.Button();
            this.entryGroupBox = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.entryListGroupBox.SuspendLayout();
            this.entryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryListListBox
            // 
            this.entryListListBox.FormattingEnabled = true;
            this.entryListListBox.Location = new System.Drawing.Point(6, 19);
            this.entryListListBox.Name = "entryListListBox";
            this.entryListListBox.Size = new System.Drawing.Size(375, 134);
            this.entryListListBox.TabIndex = 0;
            this.entryListListBox.SelectedIndexChanged += new System.EventHandler(this.entryListListBox_SelectedIndexChanged);
            // 
            // entryTextBox
            // 
            this.entryTextBox.Enabled = false;
            this.entryTextBox.Location = new System.Drawing.Point(6, 19);
            this.entryTextBox.Multiline = true;
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.entryTextBox.Size = new System.Drawing.Size(352, 104);
            this.entryTextBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(343, 302);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(181, 302);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // entrySaveButton
            // 
            this.entrySaveButton.Location = new System.Drawing.Point(364, 19);
            this.entrySaveButton.Name = "entrySaveButton";
            this.entrySaveButton.Size = new System.Drawing.Size(46, 23);
            this.entrySaveButton.TabIndex = 1;
            this.entrySaveButton.Text = "Save ";
            this.entrySaveButton.UseVisualStyleBackColor = true;
            this.entrySaveButton.Click += new System.EventHandler(this.entrySaveButton_Click);
            // 
            // entryDeleteButton
            // 
            this.entryDeleteButton.Location = new System.Drawing.Point(364, 48);
            this.entryDeleteButton.Name = "entryDeleteButton";
            this.entryDeleteButton.Size = new System.Drawing.Size(46, 23);
            this.entryDeleteButton.TabIndex = 2;
            this.entryDeleteButton.Text = "Delete";
            this.entryDeleteButton.UseVisualStyleBackColor = true;
            this.entryDeleteButton.Click += new System.EventHandler(this.entryDeleteButton_Click);
            // 
            // entryListGroupBox
            // 
            this.entryListGroupBox.Controls.Add(this.entryAtLastButton);
            this.entryListGroupBox.Controls.Add(this.entryAtBottomButton);
            this.entryListGroupBox.Controls.Add(this.entryAtUpButton);
            this.entryListGroupBox.Controls.Add(this.entryAtFirstButton);
            this.entryListGroupBox.Controls.Add(this.entryListListBox);
            this.entryListGroupBox.Location = new System.Drawing.Point(2, 0);
            this.entryListGroupBox.Name = "entryListGroupBox";
            this.entryListGroupBox.Size = new System.Drawing.Size(416, 160);
            this.entryListGroupBox.TabIndex = 0;
            this.entryListGroupBox.TabStop = false;
            this.entryListGroupBox.Text = "Entry List";
            // 
            // entryAtLastButton
            // 
            this.entryAtLastButton.Image = global::TextPlugin.Properties.Resources.last;
            this.entryAtLastButton.Location = new System.Drawing.Point(387, 124);
            this.entryAtLastButton.Name = "entryAtLastButton";
            this.entryAtLastButton.Size = new System.Drawing.Size(23, 29);
            this.entryAtLastButton.TabIndex = 4;
            this.entryAtLastButton.UseVisualStyleBackColor = true;
            this.entryAtLastButton.Click += new System.EventHandler(this.entryAtLastButton_Click);
            // 
            // entryAtBottomButton
            // 
            this.entryAtBottomButton.Image = global::TextPlugin.Properties.Resources.down;
            this.entryAtBottomButton.Location = new System.Drawing.Point(387, 89);
            this.entryAtBottomButton.Name = "entryAtBottomButton";
            this.entryAtBottomButton.Size = new System.Drawing.Size(23, 29);
            this.entryAtBottomButton.TabIndex = 3;
            this.entryAtBottomButton.UseVisualStyleBackColor = true;
            this.entryAtBottomButton.Click += new System.EventHandler(this.entryAtBottomButton_Click);
            // 
            // entryAtUpButton
            // 
            this.entryAtUpButton.Image = global::TextPlugin.Properties.Resources.up;
            this.entryAtUpButton.Location = new System.Drawing.Point(387, 54);
            this.entryAtUpButton.Name = "entryAtUpButton";
            this.entryAtUpButton.Size = new System.Drawing.Size(23, 29);
            this.entryAtUpButton.TabIndex = 2;
            this.entryAtUpButton.UseVisualStyleBackColor = true;
            this.entryAtUpButton.Click += new System.EventHandler(this.entryAtUpButton_Click);
            // 
            // entryAtFirstButton
            // 
            this.entryAtFirstButton.Image = global::TextPlugin.Properties.Resources.first;
            this.entryAtFirstButton.Location = new System.Drawing.Point(387, 19);
            this.entryAtFirstButton.Name = "entryAtFirstButton";
            this.entryAtFirstButton.Size = new System.Drawing.Size(23, 29);
            this.entryAtFirstButton.TabIndex = 1;
            this.entryAtFirstButton.UseVisualStyleBackColor = true;
            this.entryAtFirstButton.Click += new System.EventHandler(this.entryAtFirstButton_Click);
            // 
            // entryGroupBox
            // 
            this.entryGroupBox.Controls.Add(this.entryTextBox);
            this.entryGroupBox.Controls.Add(this.entrySaveButton);
            this.entryGroupBox.Controls.Add(this.entryDeleteButton);
            this.entryGroupBox.Location = new System.Drawing.Point(2, 166);
            this.entryGroupBox.Name = "entryGroupBox";
            this.entryGroupBox.Size = new System.Drawing.Size(416, 130);
            this.entryGroupBox.TabIndex = 1;
            this.entryGroupBox.TabStop = false;
            this.entryGroupBox.Text = "Entry";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(2, 302);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(262, 302);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 12;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // EntryListEdit
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(419, 330);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.entryGroupBox);
            this.Controls.Add(this.entryListGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryListEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Entry List";
            this.entryListGroupBox.ResumeLayout(false);
            this.entryGroupBox.ResumeLayout(false);
            this.entryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox entryListListBox;
        private System.Windows.Forms.TextBox entryTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button entrySaveButton;
        private System.Windows.Forms.Button entryDeleteButton;
        private System.Windows.Forms.GroupBox entryListGroupBox;
        private System.Windows.Forms.GroupBox entryGroupBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button entryAtLastButton;
        private System.Windows.Forms.Button entryAtBottomButton;
        private System.Windows.Forms.Button entryAtUpButton;
        private System.Windows.Forms.Button entryAtFirstButton;
    }
}