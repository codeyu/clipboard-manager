namespace ClipboardManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clipEntryListBox = new System.Windows.Forms.ListBox();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clipListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendToClipboardAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToPluginsAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.entryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToPluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipPropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.clipListContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Clipboard Manager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryListToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.pluginsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(128, 126);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // clipEntryListBox
            // 
            this.clipEntryListBox.BackColor = System.Drawing.SystemColors.Control;
            this.clipEntryListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clipEntryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipEntryListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.clipEntryListBox.FormattingEnabled = true;
            this.clipEntryListBox.ItemHeight = 45;
            this.clipEntryListBox.Location = new System.Drawing.Point(0, 0);
            this.clipEntryListBox.Name = "clipEntryListBox";
            this.clipEntryListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.clipEntryListBox.Size = new System.Drawing.Size(272, 492);
            this.clipEntryListBox.TabIndex = 1;
            this.clipEntryListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.clipEntryListBox_DrawItem);
            this.clipEntryListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clipEntryListBox_MouseUp);
            this.clipEntryListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clipEntryListBox_MouseMove);
            this.clipEntryListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clipEntryListBox_MouseDown);
            this.clipEntryListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clipEntryListBox_KeyPress);
            this.clipEntryListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clipEntryListBox_KeyDown);
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
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Formats of this Clip";
            // 
            // clipListContextMenuStrip
            // 
            this.clipListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToClipboardToolStripMenuItem,
            this.sendToClipboardAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.editImageToolStripMenuItem,
            this.sendToPluginsToolStripMenuItem,
            this.sendToPluginsAsToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteEntryToolStripMenuItem,
            this.toolStripSeparator3,
            this.clipPropertyToolStripMenuItem});
            this.clipListContextMenuStrip.Name = "clipListContextMenuStrip";
            this.clipListContextMenuStrip.Size = new System.Drawing.Size(206, 176);
            // 
            // sendToClipboardAsToolStripMenuItem
            // 
            this.sendToClipboardAsToolStripMenuItem.Name = "sendToClipboardAsToolStripMenuItem";
            this.sendToClipboardAsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sendToClipboardAsToolStripMenuItem.Text = "Send to Clipboard as Text";
            this.sendToClipboardAsToolStripMenuItem.Click += new System.EventHandler(this.sendToClipboardAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(202, 6);
            // 
            // sendToPluginsAsToolStripMenuItem
            // 
            this.sendToPluginsAsToolStripMenuItem.Name = "sendToPluginsAsToolStripMenuItem";
            this.sendToPluginsAsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sendToPluginsAsToolStripMenuItem.Text = "Send to Plugins as Text";
            this.sendToPluginsAsToolStripMenuItem.Click += new System.EventHandler(this.sendToPluginsAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(202, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // entryListToolStripMenuItem
            // 
            this.entryListToolStripMenuItem.Checked = true;
            this.entryListToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.entryListToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryListToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.entry;
            this.entryListToolStripMenuItem.Name = "entryListToolStripMenuItem";
            this.entryListToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.entryListToolStripMenuItem.Text = "Entry List";
            this.entryListToolStripMenuItem.Click += new System.EventHandler(this.entryListToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.options;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.Enabled = false;
            this.pluginsToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.plugins;
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.help;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sendToClipboardToolStripMenuItem
            // 
            this.sendToClipboardToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.sendclipboard;
            this.sendToClipboardToolStripMenuItem.Name = "sendToClipboardToolStripMenuItem";
            this.sendToClipboardToolStripMenuItem.ShortcutKeyDisplayString = "Enter";
            this.sendToClipboardToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sendToClipboardToolStripMenuItem.Text = "Send to Clipboard";
            this.sendToClipboardToolStripMenuItem.Click += new System.EventHandler(this.sendToClipboardToolStripMenuItem_Click);
            // 
            // editImageToolStripMenuItem
            // 
            this.editImageToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.edit;
            this.editImageToolStripMenuItem.Name = "editImageToolStripMenuItem";
            this.editImageToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.editImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editImageToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.editImageToolStripMenuItem.Text = "Edit Image";
            this.editImageToolStripMenuItem.Click += new System.EventHandler(this.editImageToolStripMenuItem_Click);
            // 
            // sendToPluginsToolStripMenuItem
            // 
            this.sendToPluginsToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.sendplugins;
            this.sendToPluginsToolStripMenuItem.Name = "sendToPluginsToolStripMenuItem";
            this.sendToPluginsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Enter";
            this.sendToPluginsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sendToPluginsToolStripMenuItem.Text = "Send to Plugins";
            this.sendToPluginsToolStripMenuItem.Click += new System.EventHandler(this.sendToPluginsToolStripMenuItem_Click);
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.delete;
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.ShortcutKeyDisplayString = "Delete";
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete Clip";
            this.deleteEntryToolStripMenuItem.Click += new System.EventHandler(this.deleteEntryToolStripMenuItem_Click);
            // 
            // clipPropertyToolStripMenuItem
            // 
            this.clipPropertyToolStripMenuItem.Image = global::ClipboardManager.Properties.Resources.properties;
            this.clipPropertyToolStripMenuItem.Name = "clipPropertyToolStripMenuItem";
            this.clipPropertyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.clipPropertyToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.clipPropertyToolStripMenuItem.Text = "Clip Property";
            this.clipPropertyToolStripMenuItem.Click += new System.EventHandler(this.clipPropertyToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 492);
            this.ControlBox = false;
            this.Controls.Add(this.clipEntryListBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.8;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.contextMenuStrip.ResumeLayout(false);
            this.clipListContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox clipEntryListBox;
        private System.Windows.Forms.ToolStripMenuItem entryListToolStripMenuItem;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip clipListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clipPropertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem sendToPluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sendToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToClipboardAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToPluginsAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editImageToolStripMenuItem;
    }
}

