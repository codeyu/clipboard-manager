namespace Editor {
    partial class ResizeForm {
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
            this.factorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.ratioCheck = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.factorGroupBox = new System.Windows.Forms.GroupBox();
            this.factorLabel = new System.Windows.Forms.Label();
            this.resizeGroupBox = new System.Windows.Forms.GroupBox();
            this.factorGroupBox.SuspendLayout();
            this.resizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // factorBox
            // 
            this.factorBox.Location = new System.Drawing.Point(53, 19);
            this.factorBox.Name = "factorBox";
            this.factorBox.Size = new System.Drawing.Size(100, 20);
            this.factorBox.TabIndex = 0;
            this.factorBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.factorBox_KeyPress);
            this.factorBox.TextChanged += new System.EventHandler(this.factorBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width:";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(53, 19);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 0;
            this.widthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthBox_KeyPress);
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height:";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(53, 45);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 1;
            this.heightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightBox_KeyPress);
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // ratioCheck
            // 
            this.ratioCheck.Checked = true;
            this.ratioCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ratioCheck.Location = new System.Drawing.Point(6, 71);
            this.ratioCheck.Name = "ratioCheck";
            this.ratioCheck.Size = new System.Drawing.Size(112, 20);
            this.ratioCheck.TabIndex = 2;
            this.ratioCheck.Text = "Keep aspect ratio";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 162);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(90, 162);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            // 
            // factorGroupBox
            // 
            this.factorGroupBox.Controls.Add(this.factorLabel);
            this.factorGroupBox.Controls.Add(this.factorBox);
            this.factorGroupBox.Location = new System.Drawing.Point(3, 2);
            this.factorGroupBox.Name = "factorGroupBox";
            this.factorGroupBox.Size = new System.Drawing.Size(162, 51);
            this.factorGroupBox.TabIndex = 0;
            this.factorGroupBox.TabStop = false;
            this.factorGroupBox.Text = "Resize Factor";
            // 
            // factorLabel
            // 
            this.factorLabel.AutoSize = true;
            this.factorLabel.Location = new System.Drawing.Point(7, 22);
            this.factorLabel.Name = "factorLabel";
            this.factorLabel.Size = new System.Drawing.Size(40, 13);
            this.factorLabel.TabIndex = 2;
            this.factorLabel.Text = "Factor:";
            // 
            // resizeGroupBox
            // 
            this.resizeGroupBox.Controls.Add(this.label1);
            this.resizeGroupBox.Controls.Add(this.widthBox);
            this.resizeGroupBox.Controls.Add(this.label2);
            this.resizeGroupBox.Controls.Add(this.heightBox);
            this.resizeGroupBox.Controls.Add(this.ratioCheck);
            this.resizeGroupBox.Location = new System.Drawing.Point(3, 59);
            this.resizeGroupBox.Name = "resizeGroupBox";
            this.resizeGroupBox.Size = new System.Drawing.Size(162, 97);
            this.resizeGroupBox.TabIndex = 1;
            this.resizeGroupBox.TabStop = false;
            this.resizeGroupBox.Text = "Resize To";
            // 
            // ResizeForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(167, 189);
            this.Controls.Add(this.resizeGroupBox);
            this.Controls.Add(this.factorGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize image";
            this.Load += new System.EventHandler(this.ResizeForm_Load);
            this.factorGroupBox.ResumeLayout(false);
            this.factorGroupBox.PerformLayout();
            this.resizeGroupBox.ResumeLayout(false);
            this.resizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TextBox factorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox ratioCheck;
        private System.Windows.Forms.GroupBox factorGroupBox;
        private System.Windows.Forms.GroupBox resizeGroupBox;
        private System.Windows.Forms.Label factorLabel;
    }
}