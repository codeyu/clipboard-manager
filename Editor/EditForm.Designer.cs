namespace Editor {
    partial class EditForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.backImageItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.reloadMenuItem = new System.Windows.Forms.MenuItem();
            this.saveMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.closeMenuItem = new System.Windows.Forms.MenuItem();
            this.imageItem = new System.Windows.Forms.MenuItem();
            this.flipImageItem = new System.Windows.Forms.MenuItem();
            this.mirrorItem = new System.Windows.Forms.MenuItem();
            this.rotateImageItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.cropImageItem = new System.Windows.Forms.MenuItem();
            this.resizeFiltersItem = new System.Windows.Forms.MenuItem();
            this.textMenuItem = new System.Windows.Forms.MenuItem();
            this.insertTextMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.fontMenuItem = new System.Windows.Forms.MenuItem();
            this.colorMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.z10ImageItem = new System.Windows.Forms.MenuItem();
            this.z25ImageItem = new System.Windows.Forms.MenuItem();
            this.z50ImageItem = new System.Windows.Forms.MenuItem();
            this.z75ImageItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.z100ImageItem = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.z150ImageItem = new System.Windows.Forms.MenuItem();
            this.z200ImageItem = new System.Windows.Forms.MenuItem();
            this.z400ImageItem = new System.Windows.Forms.MenuItem();
            this.z500ImageItem = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.zoomInImageItem = new System.Windows.Forms.MenuItem();
            this.zoomOutImageItem = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.zoomFitImageItem = new System.Windows.Forms.MenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.imageItem,
            this.textMenuItem,
            this.menuItem5});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.backImageItem,
            this.menuItem4,
            this.reloadMenuItem,
            this.saveMenuItem,
            this.menuItem14,
            this.closeMenuItem});
            this.fileMenuItem.Text = "&File";
            this.fileMenuItem.Popup += new System.EventHandler(this.fileMenuItem_Popup);
            // 
            // backImageItem
            // 
            this.backImageItem.Index = 0;
            this.backImageItem.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.backImageItem.Text = "&Undo";
            this.backImageItem.Click += new System.EventHandler(this.backImageItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // reloadMenuItem
            // 
            this.reloadMenuItem.Index = 2;
            this.reloadMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.reloadMenuItem.Text = "R&eload";
            this.reloadMenuItem.Click += new System.EventHandler(this.reloadMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Index = 3;
            this.saveMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.saveMenuItem.Text = "&Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 4;
            this.menuItem14.Text = "-";
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Index = 5;
            this.closeMenuItem.Text = "&Close";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // imageItem
            // 
            this.imageItem.Index = 1;
            this.imageItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.flipImageItem,
            this.mirrorItem,
            this.rotateImageItem,
            this.menuItem3,
            this.cropImageItem,
            this.resizeFiltersItem});
            this.imageItem.MergeOrder = 1;
            this.imageItem.Text = "&Image";
            this.imageItem.Popup += new System.EventHandler(this.imageItem_Popup);
            // 
            // flipImageItem
            // 
            this.flipImageItem.Index = 0;
            this.flipImageItem.Text = "&Flip";
            this.flipImageItem.Click += new System.EventHandler(this.flipImageItem_Click);
            // 
            // mirrorItem
            // 
            this.mirrorItem.Index = 1;
            this.mirrorItem.Text = "&Mirror";
            this.mirrorItem.Click += new System.EventHandler(this.mirrorItem_Click);
            // 
            // rotateImageItem
            // 
            this.rotateImageItem.Index = 2;
            this.rotateImageItem.Text = "&Rotate 90 degree";
            this.rotateImageItem.Click += new System.EventHandler(this.rotateImageItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "-";
            // 
            // cropImageItem
            // 
            this.cropImageItem.Index = 4;
            this.cropImageItem.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.cropImageItem.Text = "Cro&p";
            this.cropImageItem.Click += new System.EventHandler(this.cropImageItem_Click);
            // 
            // resizeFiltersItem
            // 
            this.resizeFiltersItem.Index = 5;
            this.resizeFiltersItem.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.resizeFiltersItem.Text = "&Resize";
            this.resizeFiltersItem.Click += new System.EventHandler(this.resizeFiltersItem_Click);
            // 
            // textMenuItem
            // 
            this.textMenuItem.Index = 2;
            this.textMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.insertTextMenuItem,
            this.menuItem10,
            this.fontMenuItem,
            this.colorMenuItem});
            this.textMenuItem.Text = "&Text";
            this.textMenuItem.Popup += new System.EventHandler(this.textMenuItem_Popup);
            // 
            // insertTextMenuItem
            // 
            this.insertTextMenuItem.Index = 0;
            this.insertTextMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
            this.insertTextMenuItem.Text = "&Insert";
            this.insertTextMenuItem.Click += new System.EventHandler(this.insertTextMenuItem_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "-";
            // 
            // fontMenuItem
            // 
            this.fontMenuItem.Index = 2;
            this.fontMenuItem.Text = "&Font";
            this.fontMenuItem.Click += new System.EventHandler(this.fontMenuItem_Click);
            // 
            // colorMenuItem
            // 
            this.colorMenuItem.Index = 3;
            this.colorMenuItem.Text = "&Color";
            this.colorMenuItem.Click += new System.EventHandler(this.colorMenuItem_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.z10ImageItem,
            this.z25ImageItem,
            this.z50ImageItem,
            this.z75ImageItem,
            this.menuItem7,
            this.z100ImageItem,
            this.menuItem6,
            this.z150ImageItem,
            this.z200ImageItem,
            this.z400ImageItem,
            this.z500ImageItem,
            this.menuItem8,
            this.zoomInImageItem,
            this.zoomOutImageItem,
            this.menuItem11,
            this.zoomFitImageItem});
            this.menuItem5.Text = "&Zoom";
            // 
            // z10ImageItem
            // 
            this.z10ImageItem.Index = 0;
            this.z10ImageItem.Text = "10%";
            this.z10ImageItem.Click += new System.EventHandler(this.zoomItem_Click);
            // 
            // z25ImageItem
            // 
            this.z25ImageItem.Index = 1;
            this.z25ImageItem.Text = "25%";
            this.z25ImageItem.Click += new System.EventHandler(this.zoomItem_Click);
            // 
            // z50ImageItem
            // 
            this.z50ImageItem.Index = 2;
            this.z50ImageItem.Text = "50%";
            this.z50ImageItem.Click += new System.EventHandler(this.zoomItem_Click);
            // 
            // z75ImageItem
            // 
            this.z75ImageItem.Index = 3;
            this.z75ImageItem.Text = "75%";
            this.z75ImageItem.Click += new System.EventHandler(this.zoomItem_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            this.menuItem7.Text = "-";
            // 
            // z100ImageItem
            // 
            this.z100ImageItem.Index = 5;
            this.z100ImageItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl0;
            this.z100ImageItem.Text = "100%";
            this.z100ImageItem.Click += new System.EventHandler(this.zoomItem_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 6;
            this.menuItem6.Text = "-";
            // 
            // z150ImageItem
            // 
            this.z150ImageItem.Index = 7;
            this.z150ImageItem.Text = "150%";
            this.z150ImageItem.Click += new System.EventHandler(this.zoomItem_Click);
            // 
            // z200ImageItem
            // 
            this.z200ImageItem.Index = 8;
            this.z200ImageItem.Text = "200%";
            this.z200ImageItem.Click += new System.EventHandler(this.zoomItem_Click);
            // 
            // z400ImageItem
            // 
            this.z400ImageItem.Index = 9;
            this.z400ImageItem.Text = "400%";
            this.z400ImageItem.Click += new System.EventHandler(this.zoomItem_Click);
            // 
            // z500ImageItem
            // 
            this.z500ImageItem.Index = 10;
            this.z500ImageItem.Text = "500%";
            this.z500ImageItem.Click += new System.EventHandler(this.zoomItem_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 11;
            this.menuItem8.Text = "-";
            // 
            // zoomInImageItem
            // 
            this.zoomInImageItem.Index = 12;
            this.zoomInImageItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl8;
            this.zoomInImageItem.Text = "Zoom &In";
            this.zoomInImageItem.Click += new System.EventHandler(this.zoomInImageItem_Click);
            // 
            // zoomOutImageItem
            // 
            this.zoomOutImageItem.Index = 13;
            this.zoomOutImageItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl7;
            this.zoomOutImageItem.Text = "Zoom &Out";
            this.zoomOutImageItem.Click += new System.EventHandler(this.zoomOutImageItem_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 14;
            this.menuItem11.Text = "-";
            // 
            // zoomFitImageItem
            // 
            this.zoomFitImageItem.Index = 15;
            this.zoomFitImageItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl9;
            this.zoomFitImageItem.Text = "Fit to screen";
            this.zoomFitImageItem.Click += new System.EventHandler(this.zoomFitImageItem_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.FontMustExist = true;
            // 
            // EditForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(509, 420);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "EditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Editor";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageDoc_MouseUp);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditForm_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageDoc_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageDoc_MouseDown);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem imageItem;
        private System.Windows.Forms.MenuItem backImageItem;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem z10ImageItem;
        private System.Windows.Forms.MenuItem z25ImageItem;
        private System.Windows.Forms.MenuItem z50ImageItem;
        private System.Windows.Forms.MenuItem z75ImageItem;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem z100ImageItem;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem z150ImageItem;
        private System.Windows.Forms.MenuItem z200ImageItem;
        private System.Windows.Forms.MenuItem z400ImageItem;
        private System.Windows.Forms.MenuItem z500ImageItem;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem zoomInImageItem;
        private System.Windows.Forms.MenuItem zoomOutImageItem;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem zoomFitImageItem;
        private System.Windows.Forms.MenuItem flipImageItem;
        private System.Windows.Forms.MenuItem mirrorItem;
        private System.Windows.Forms.MenuItem rotateImageItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem cropImageItem;
        private System.Windows.Forms.MenuItem resizeFiltersItem;
        private System.Windows.Forms.MenuItem textMenuItem;
        private System.Windows.Forms.MenuItem insertTextMenuItem;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem fontMenuItem;
        private System.Windows.Forms.MenuItem colorMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem reloadMenuItem;
        private System.Windows.Forms.MenuItem saveMenuItem;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem closeMenuItem;



    }
}