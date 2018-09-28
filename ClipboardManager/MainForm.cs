using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Editor;

namespace ClipboardManager {
    public partial class MainForm : Form {
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("kernel32.dll", EntryPoint = "GlobalAddAtomA", SetLastError = true)]
        static extern Int16 GlobalAddAtom(string lpString);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern Int16 GlobalDeleteAtom(Int16 nAtom);

        [DllImport("user32.dll", SetLastError = true)]
        static extern Int32 RegisterHotKey(IntPtr hwnd, Int32 id, Int32 fsModifiers, Int32 vk);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool UnregisterHotKey(IntPtr hWnd, Int32 id);

        const int MOD_ALT = 0x0001;
        const int MOD_CONTROL = 0x0002;
        const int MOD_SHIFT = 0x0004;

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int WM_DRAWCLIPBOARD = 0x308;
        const int WM_CHANGECBCHAIN = 0x030D;
        const int WM_HOTKEY = 0x0312;

        const int HT_CAPTION = 0x2;

        Object thisObject = new Object();

        bool editFormOpen = false;

        Int16 downAtomID;
        Int16 upAtomID;
        Int16 showAtomID;
        Int16 copyAtomID;

        IntPtr nextClipboardViewer;
        PluginHost plugins = new PluginHost();
        NameValueCollection genSettings = new NameValueCollection();
        ClipEntry editingClip = null;
        const string PlugPath = "Plugins";
        public PluginHost PlugHost {
            get { return plugins; }
        }

        public MainForm() : this("ClipboardManager.xml") { }

        public MainForm(string configFile){
            plugins.GeneralConfig = genSettings;
            plugins.ConfigFilename = configFile;

            InitializeComponent();

            plugins.PluginConfig.Clear();

            if (System.IO.File.Exists(configFile))
                ReadOptions(configFile);
            else
                MessageBox.Show("Error opening the configuration file " + configFile + "\nUsing default settings.",
                                "Error during startup", MessageBoxButtons.OK, MessageBoxIcon.Error);

            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);

            InitClipMan(true, true);
        }

        public void InitClipMan(bool loadPlugins, bool registerHotKeys) {
            CheckOptionsFile();

            try {
                Opacity = (double.Parse(genSettings["WindowOpacity"])) / 100;
                TopMost = bool.Parse(genSettings["WindowOnTop"]);
            }
            catch (FormatException fe){
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clipEntryListBox.BackColor = Color.FromArgb(int.Parse(genSettings["WindowBackColor"]));

            if (loadPlugins) {
                if (plugins.LoadedPlugins.Count > 0)
                    plugins.RemovePlugins();

                plugins.LoadedPlugins.Clear();
                plugins.FormatRegisteredPlugins.Clear();

                if (genSettings["PluginDir"] != null)
                    foreach (string path in genSettings["PluginDir"].Split(new char[] { ',' }))
                        plugins.LoadPlugins(path, ".dll");
                else
                    plugins.LoadPlugins(Application.StartupPath, ".dll");

                pluginsToolStripMenuItem.DropDownItems.Clear();

                pluginsToolStripMenuItem.Enabled = false;
                sendToPluginsToolStripMenuItem.Enabled = false;

                if (plugins.LoadedPlugins.Count > 0) {
                    pluginsToolStripMenuItem.Enabled = true;
                    sendToPluginsToolStripMenuItem.Enabled = true;
                }

                foreach (int plugID in plugins.LoadedPlugins.Keys)
                    pluginsToolStripMenuItem.DropDownItems.Add(new PluginMenuItem(((PluginInstance)plugins.LoadedPlugins[plugID]).Instance));
            }

            if (registerHotKeys) {
                try {
                    RegisterHotKeys();
                }
                catch (Win32Exception w3e) {
                    MessageBox.Show("Error registering selected hotkeys:\n" + w3e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckOptionsFile() {
            if (genSettings["PluginDir"] == null)
                genSettings.Add("PluginDir", $"{Application.StartupPath}/{PlugPath}");

            if (genSettings["LoadOnWindows"] == null)
                genSettings.Add("LoadOnWindows", "false");

            if (genSettings["DownEntryCtrlMod"] == null)
                genSettings.Add("DownEntryCtrlMod", "true");
            if (genSettings["DownEntryAltMod"] == null)
                genSettings.Add("DownEntryAltMod", "false");
            if (genSettings["DownEntryShiftMod"] == null)
                genSettings.Add("DownEntryShiftMod", "false");
            if (genSettings["DownEntryHotKey"] == null)
                genSettings.Add("DownEntryHotKey", Keys.D.ToString());

            if (genSettings["UpEntryCtrlMod"] == null)
                genSettings.Add("UpEntryCtrlMod", "true");
            if (genSettings["UpEntryAltMod"] == null)
                genSettings.Add("UpEntryAltMod", "false");
            if (genSettings["UpEntryShiftMod"] == null)
                genSettings.Add("UpEntryShiftMod", "false");
            if (genSettings["UpEntryHotKey"] == null)
                genSettings.Add("UpEntryHotKey", Keys.U.ToString());

            if (genSettings["ShowEntryCtrlMod"] == null)
                genSettings.Add("ShowEntryCtrlMod", "true");
            if (genSettings["ShowEntryAltMod"] == null)
                genSettings.Add("ShowEntryAltMod", "false");
            if (genSettings["ShowEntryShiftMod"] == null)
                genSettings.Add("ShowEntryShiftMod", "false");
            if (genSettings["ShowEntryHotKey"] == null)
                genSettings.Add("ShowEntryHotKey", Keys.S.ToString());

            if (genSettings["CopyEntryCtrlMod"] == null)
                genSettings.Add("CopyEntryCtrlMod", "true");
            if (genSettings["CopyEntryAltMod"] == null)
                genSettings.Add("CopyEntryAltMod", "false");
            if (genSettings["CopyEntryShiftMod"] == null)
                genSettings.Add("CopyEntryShiftMod", "false");
            if (genSettings["CopyEntryHotKey"] == null)
                genSettings.Add("CopyEntryHotKey", Keys.J.ToString());

            if (genSettings["WindowOpacity"] == null)
                genSettings.Add("WindowOpacity", (80).ToString());

            if (genSettings["WindowBackColor"] == null)
                genSettings.Add("WindowBackColor", SystemColors.Control.ToArgb().ToString());

            if (genSettings["WindowOnTop"] == null)
                genSettings.Add("WindowOnTop", "true");

            if (genSettings["SaveWindowPos"] == null)
                genSettings.Add("SaveWindowPos", "true");

            if (genSettings["WindowPosX"] == null)
                genSettings.Add("WindowPosX", (Screen.PrimaryScreen.WorkingArea.Size.Width - 280).ToString());
            if (genSettings["WindowPosY"] == null)
                genSettings.Add("WindowPosY", (Screen.PrimaryScreen.WorkingArea.Size.Height - 500).ToString());
            if (genSettings["WindowSizeHeight"] == null)
                genSettings.Add("WindowSizeHeight", (500).ToString());
            if (genSettings["WindowSizeWidth"] == null)
                genSettings.Add("WindowSizeWidth", (280).ToString());
        }

        protected override void OnLoad(EventArgs e){
            base.OnLoad(e);

            try {
                Size = new Size(int.Parse(genSettings["WindowSizeWidth"]), int.Parse(genSettings["WindowSizeHeight"]));
                DesktopLocation = new Point(int.Parse(genSettings["WindowPosX"]), int.Parse(genSettings["WindowPosY"]));
            }
            catch (FormatException fe) {
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnClosed(EventArgs e) {
            try {
                if (bool.Parse(genSettings["SaveWindowPos"])) {
                    if (genSettings["WindowSizeWidth"] != null)
                        genSettings.Remove("WindowSizeWidth");
                    if (genSettings["WindowSizeHeight"] != null)
                        genSettings.Remove("WindowSizeHeight");

                    if (genSettings["WindowPosX"] != null)
                        genSettings.Remove("WindowPosX");
                    if (genSettings["WindowPosY"] != null)
                        genSettings.Remove("WindowPosY");

                    genSettings.Add("WindowSizeWidth", Size.Width.ToString());
                    genSettings.Add("WindowSizeHeight", Size.Height.ToString());

                    genSettings.Add("WindowPosX", DesktopLocation.X.ToString());
                    genSettings.Add("WindowPosY", DesktopLocation.Y.ToString());
                }
            }
            catch (FormatException fe) {
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                plugins.RemovePlugins();
                plugins.WriteOptions();
                ChangeClipboardChain(this.Handle, nextClipboardViewer);
                UnregisterHotKeys();

                base.OnClosed(e);
            }
        }

        protected override void WndProc(ref Message m){
            switch (m.Msg){
                case WM_DRAWCLIPBOARD:
                    ManageClipboardData();
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);

                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);

                    break;

                case WM_HOTKEY:
                    if ((Int16)m.WParam == downAtomID)
                        EntryListDown();
                    else if ((Int16)m.WParam == upAtomID)
                        EntryListUp();
                    else if ((Int16)m.WParam == showAtomID)
                        EntryListShow();
                    else if ((Int16)m.WParam == copyAtomID)
                        sendToClipboardToolStripMenuItem_Click(this, new EventArgs());

                    break;

                default:
                    base.WndProc(ref m);

                    break;
            }
        }

        private void ManageClipboardData(){
            try {
                lock (thisObject) {
                    IDataObject iData = Clipboard.GetDataObject();

                    if (iData.GetDataPresent(DataFormats.Html)) {
                        ClipEntry clip = new ClipEntry(ClipEntryType.Html, "HTML",
                                                       "Text Length: " + iData.GetData(DataFormats.Text).ToString().Length.ToString()
                                                       + " chars", iData.GetFormats(), iData, iData.GetData(DataFormats.Html),
                                                       DataFormats.Html, iData.GetData(DataFormats.Text));

                        bool entryPresent = false;
                        int entryIndex = -1;

                        foreach (object entry in clipEntryListBox.Items) {
                            if ((((ClipEntry)entry).MessageText.Equals(clip.MessageText)) && (((ClipEntry)entry).MessageType.Equals(clip.MessageType))) {
                                entryPresent = true;
                                entryIndex = clipEntryListBox.Items.IndexOf(entry);
                            }
                        }

                        if (!entryPresent)
                            clipEntryListBox.Items.Insert(0, clip);
                        else {
                            clipEntryListBox.Items.RemoveAt(entryIndex);
                            clipEntryListBox.Items.Insert(0, clip);
                        }
                    }
                    else if (iData.GetDataPresent(DataFormats.Rtf)) {
                        ClipEntry clip = new ClipEntry(ClipEntryType.Rtf, "Rich Text Format",
                                                       "Text Length: " + iData.GetData(DataFormats.Text).ToString().Length.ToString()
                                                       + " chars", iData.GetFormats(), iData, iData.GetData(DataFormats.Rtf),
                                                       DataFormats.Rtf, iData.GetData(DataFormats.Text));

                        bool entryPresent = false;
                        int entryIndex = -1;

                        foreach (object entry in clipEntryListBox.Items) {
                            if ((((ClipEntry)entry).MessageText.Equals(clip.MessageText)) && (((ClipEntry)entry).MessageType.Equals(clip.MessageType))) {
                                entryPresent = true;
                                entryIndex = clipEntryListBox.Items.IndexOf(entry);
                            }
                        }

                        if (!entryPresent)
                            clipEntryListBox.Items.Insert(0, clip);
                        else {
                            clipEntryListBox.Items.RemoveAt(entryIndex);
                            clipEntryListBox.Items.Insert(0, clip);
                        }
                    }
                    else if (iData.GetDataPresent(DataFormats.Text)) {
                        ClipEntry clip = new ClipEntry(ClipEntryType.Text, "Text", iData.GetData(DataFormats.Text).ToString(), iData.GetFormats(),
                                                       iData.GetData(DataFormats.Text), iData.GetData(DataFormats.Text), DataFormats.Text, null);

                        bool entryPresent = false;
                        int entryIndex = -1;

                        foreach (object entry in clipEntryListBox.Items) {
                            if ((((ClipEntry)entry).MessageText.Equals(clip.MessageText)) && (((ClipEntry)entry).MessageType.Equals(clip.MessageType))) {
                                entryPresent = true;
                                entryIndex = clipEntryListBox.Items.IndexOf(entry);
                            }
                        }

                        if (!entryPresent)
                            clipEntryListBox.Items.Insert(0, clip);
                        else {
                            clipEntryListBox.Items.RemoveAt(entryIndex);
                            clipEntryListBox.Items.Insert(0, clip);
                        }
                    }
                    else if (iData.GetDataPresent(DataFormats.FileDrop)) {
                        string[] files = (string[])iData.GetData(DataFormats.FileDrop);

                        ClipEntry clip = new ClipEntry(ClipEntryType.FileDrop, "Files", "Quantity: " + files.Length, iData.GetFormats(), iData,
                                                       iData.GetData(DataFormats.FileDrop), DataFormats.FileDrop, null);

                        bool entryPresent = false;
                        int entryIndex = -1;

                        foreach (object entry in clipEntryListBox.Items) {
                            ClipEntry clipToCheck = (ClipEntry)entry;

                            if (clipToCheck.PrincipalFormat == DataFormats.FileDrop) {
                                if (((string[])clipToCheck.PluginData).Length == files.Length) {
                                    for (int i = 0; i < files.Length; i++) {
                                        entryPresent = true;

                                        if (((string[])clipToCheck.PluginData)[i] != files[i]) {
                                            entryPresent = false;
                                            break;
                                        }
                                    }

                                    if (entryPresent)
                                        entryIndex = clipEntryListBox.Items.IndexOf(entry);
                                }
                            }
                        }

                        if (!entryPresent)
                            clipEntryListBox.Items.Insert(0, clip);
                        else {
                            clipEntryListBox.Items.RemoveAt(entryIndex);
                            clipEntryListBox.Items.Insert(0, clip);
                        }
                    }
                    else if (iData.GetDataPresent(DataFormats.Bitmap)) {
                        Bitmap bmp = (Bitmap)iData.GetData(DataFormats.Bitmap);
                        string messageText = "Size: " + bmp.Width + "x" + bmp.Height + " - Color Depth: " + Image.GetPixelFormatSize(bmp.PixelFormat).ToString();

                        ClipEntry clip = new ClipEntry(ClipEntryType.Bitmap, "Image", messageText, iData.GetFormats(), bmp,
                                                       iData.GetData(DataFormats.Bitmap), DataFormats.Bitmap, null);

                        clipEntryListBox.Items.Insert(0, clip);
                    }
                    else {
                        if (iData.GetFormats().Length > 0)
                            clipEntryListBox.Items.Insert(0, new ClipEntry(ClipEntryType.Special, "Special", "Special Data",
                                                                           iData.GetFormats(), iData, null, null, null));
                    }
                }
            }
            catch (ExternalException ee) {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Threading.ThreadStateException tse) {
                MessageBox.Show(tse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException) {
                MessageBox.Show("Error in retrieving the data from the clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException) {
                MessageBox.Show("Error in retrieving the data from the clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendToPluginsAsFormat(object iData, string DataFormat) {
            ArrayList registeredPlugins = (ArrayList)plugins.FormatRegisteredPlugins[DataFormat];

            if (registeredPlugins != null) {
                foreach (int pluginID in registeredPlugins) {
                    PluginInstance selectedPlugin = (PluginInstance)plugins.LoadedPlugins[pluginID];

                    if ((selectedPlugin != null) && (selectedPlugin.Enabled))
                        new Thread(new ParameterizedThreadStart(selectedPlugin.Instance.Execute)).Start(iData);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e){
            if (MessageBox.Show("Do you really want to exit Clipboard Manager?", "Clipboard Manager", MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) 
                Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e){
            MessageBox.Show("Clipboard Manager\n\nCI Project, 2005-2006\nFrancesco Ielpi", "About...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e){
            OptionForm optForm = new OptionForm(this);

            optForm.PluginsRegistered = plugins.LoadedPlugins;
            optForm.GeneralSettings = genSettings;

            optForm.Show();
            optForm.Focus();
        }

        private void entryListToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!Visible) {
                Visible = true;
                entryListToolStripMenuItem.Checked = true;
            }
            else {
                Visible = false;
                entryListToolStripMenuItem.Checked = false;
            }
        }

        private void clipEntryListBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Escape) {
                Visible = false;
                entryListToolStripMenuItem.Checked = false;
            }
        }

        private void clipEntryListBox_DrawItem(object sender, DrawItemEventArgs e) {
            e.DrawBackground();

            if ((clipEntryListBox.Items.Count > 0) && (e.Index < clipEntryListBox.Items.Count)) {
                ClipEntry item = (ClipEntry)clipEntryListBox.Items[e.Index];

                Color textColor = System.Drawing.SystemColors.ControlText;
                Font headerFont = new Font(this.Font, FontStyle.Bold);

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) {
                    using (Pen p = new Pen(Color.Black, -1)) {
                        e.Graphics.DrawRectangle(p, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 30, e.Bounds.Height - 1);
                        e.Graphics.DrawRectangle(p, e.Bounds.Width - 28, e.Bounds.Y, 27, e.Bounds.Height - 1);
                    }

                    textColor = SystemColors.HighlightText;
                }

                if (!IconList.Images.Empty)
                    IconList.Draw(e.Graphics, e.Bounds.Left + 1, (e.Bounds.Top + e.Bounds.Height / 6), (int)item.MessageType);

                using (SolidBrush textBrush = new SolidBrush(textColor)) {
                    StringFormat strFormat = new StringFormat();
                    strFormat.Trimming = StringTrimming.EllipsisCharacter;

                    string textMessage = item.MessageText.Replace("\n", " ").Replace("\t", " ").Replace("  ", ""); ;

                    int textHeaderHeight = e.Graphics.MeasureString(item.MessageHeader, headerFont).ToSize().Height;
                    int textMessageHeight = e.Graphics.MeasureString(textMessage, this.Font).ToSize().Height;

                    int textIndexHeight = e.Graphics.MeasureString((e.Index + 1).ToString(), headerFont).ToSize().Height;
                    int textIndexWidth = e.Graphics.MeasureString((e.Index + 1).ToString(), headerFont).ToSize().Width;

                    Rectangle textHeaderRect = new Rectangle(e.Bounds.Left + IconList.ImageSize.Width + 7,
                                                             e.Bounds.Top + e.Bounds.Height / 6,
                                                             e.Bounds.Width - e.Bounds.Left - IconList.ImageSize.Width - 37, 
                                                             textHeaderHeight);

                    Rectangle textMessageRect = new Rectangle(e.Bounds.Left + IconList.ImageSize.Width + 15, 
                                                              textHeaderRect.Y + textHeaderRect.Height + 5,
                                                              e.Bounds.Width - e.Bounds.Left - IconList.ImageSize.Width - 45, 
                                                              textMessageHeight);

                    Rectangle textIndex = new Rectangle(e.Bounds.Width - (textIndexWidth / 2) - 15,
                                                        e.Bounds.Top + (e.Bounds.Height - textIndexHeight) / 2,
                                                        15 + (textIndexWidth / 2), textIndexHeight);

                    e.Graphics.DrawString(item.MessageHeader, headerFont, textBrush, textHeaderRect, strFormat);
                    e.Graphics.DrawString(textMessage, this.Font, textBrush, textMessageRect, strFormat);
                    e.Graphics.DrawString((e.Index + 1).ToString(), headerFont, textBrush, textIndex);

                    strFormat.Dispose();
                }
            }
        }

        private void clipEntryListBox_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
            else if ((e.Button == MouseButtons.Right) || (e.Button == MouseButtons.Middle)) {
                if (clipEntryListBox.Items.Count > 0) {
                    clipEntryListBox.SelectedIndices.Clear();
                    clipEntryListBox.SelectedIndex = clipEntryListBox.IndexFromPoint(PointToClient(Control.MousePosition));
                }
            }
        }

        private void clipEntryListBox_MouseMove(object sender, MouseEventArgs e) {
            clipEntryListBox_MouseDown(sender, e);
        }

        private void clipEntryListBox_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Middle) {
                if (clipEntryListBox.SelectedIndex > -1) {
                    ClipEntry clip = (ClipEntry)clipEntryListBox.Items[clipEntryListBox.SelectedIndex];

                    string formats = "";
                    foreach (string format in clip.Formats)
                        formats += format + "\n";

                    if (formats.LastIndexOf("\n") != -1)
                        formats = formats.Remove(formats.Length - 1);

                    toolTip.ToolTipTitle = "Formats of this Clip: " + clip.FormatNumber.ToString();
                    toolTip.SetToolTip(clipEntryListBox, formats);
                }
            }
            else if (e.Button == MouseButtons.Right) {
                int indexPointed = clipEntryListBox.IndexFromPoint(PointToClient(Control.MousePosition));

                if ((indexPointed > -1) && (clipEntryListBox.Items.Count > 0)) {
                    ClipEntry clip = (ClipEntry)clipEntryListBox.Items[indexPointed];

                    sendToClipboardAsToolStripMenuItem.Enabled = false;
                    sendToPluginsAsToolStripMenuItem.Enabled = false;

                    if ((clip.PrincipalFormat == DataFormats.Rtf) || (clip.PrincipalFormat == DataFormats.Html)) {
                        sendToClipboardAsToolStripMenuItem.Enabled = true;

                        if (plugins.LoadedPlugins.Count > 0)
                            sendToPluginsAsToolStripMenuItem.Enabled = true;
                    }

                    if (clip.PrincipalFormat == DataFormats.Bitmap)
                        editImageToolStripMenuItem.Enabled = true;
                    else
                        editImageToolStripMenuItem.Enabled = false;

                    if (clip.MessageType == ClipEntryType.Special)
                        clipPropertyToolStripMenuItem.Enabled = false;
                    else
                        clipPropertyToolStripMenuItem.Enabled = true;

                    clipListContextMenuStrip.Show(clipEntryListBox, PointToClient(Control.MousePosition));
                }
            }
        }

        private void clipEntryListBox_KeyDown(object sender, KeyEventArgs e) {
            if ((!e.Control) && (!e.Shift) && (!e.Alt) && (e.KeyCode == Keys.Delete))
                deleteEntryToolStripMenuItem_Click(sender, (EventArgs)e);
            else if ((!e.Control) && (!e.Shift) && (!e.Alt) && (e.KeyCode == Keys.Enter))
                sendToClipboardToolStripMenuItem_Click(sender, (EventArgs)e);
            else if ((!e.Control) && (!e.Shift) && (!e.Alt) && (e.KeyCode == Keys.Enter))
                sendToClipboardToolStripMenuItem_Click(sender, (EventArgs)e);
            else if ((sendToPluginsToolStripMenuItem.Enabled) && (e.Control) && (!e.Shift) && (!e.Alt) && (e.KeyCode == Keys.Enter))
                sendToPluginsToolStripMenuItem_Click(sender, (EventArgs)e);
            else if ((clipPropertyToolStripMenuItem.Enabled) && (e.Control) && (!e.Shift) && (!e.Alt) && (e.KeyCode == Keys.P))
                clipPropertyToolStripMenuItem_Click(sender, (EventArgs)e);
            else if ((editImageToolStripMenuItem.Enabled) && (e.Control) && (!e.Shift) && (!e.Alt) && (e.KeyCode == Keys.E))
                editImageToolStripMenuItem_Click(sender, (EventArgs)e);
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                if (!Visible) {
                    Visible = true;
                    entryListToolStripMenuItem.Checked = true;
                }
                else {
                    Visible = false;
                    entryListToolStripMenuItem.Checked = false;
                }
            }
        }

        private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e) {
            if (clipEntryListBox.SelectedIndices.Count > 0) {
                string msg;
                if (clipEntryListBox.SelectedIndices.Count == 1)
                    msg = "Do you really want to remove the selected clip?";
                else
                    msg = String.Format("Do you really want to remove the {0} selected clips?", clipEntryListBox.SelectedIndices.Count);

                if (MessageBox.Show(msg, "Clipboard Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                    MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                    ListBox.SelectedIndexCollection indices = clipEntryListBox.SelectedIndices;
                    for (int i = indices.Count - 1; i >= 0; i--)
                        clipEntryListBox.Items.RemoveAt(indices[i]);
                }
            }
        }

        private void sendToClipboardToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (clipEntryListBox.SelectedItems.Count == 1) {
                    clipEntryListBox.BeginUpdate();

                    ClipEntry clip = (ClipEntry)clipEntryListBox.SelectedItem;
                    clipEntryListBox.Items.RemoveAt(clipEntryListBox.SelectedIndex);

                    if (clip.MessageType == ClipEntryType.Special) {
                        DataObject pasteObj = new DataObject();

                        foreach (string format in clip.Formats)
                            pasteObj.SetData(format, ((DataObject)clip.FormattedData).GetData(format));

                        Clipboard.SetDataObject(pasteObj);
                    }
                    else
                        Clipboard.SetDataObject(clip.FormattedData);

                    clipEntryListBox.EndUpdate();
                }
                else if (clipEntryListBox.SelectedItems.Count > 1)
                    MessageBox.Show("Only one element can be copied to clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExternalException ee) {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Threading.ThreadStateException tse) {
                MessageBox.Show(tse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException) {
                MessageBox.Show("Error in sending the data to clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendToPluginsToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (int i in clipEntryListBox.SelectedIndices) {
                ClipEntry clip = (ClipEntry)clipEntryListBox.Items[i];

                SendToPluginsAsFormat(clip.PluginData, clip.PrincipalFormat);
            }
        }

        private void clipPropertyToolStripMenuItem_Click(object sender, EventArgs e) {
            if (clipEntryListBox.SelectedItem != null) {
                ClipEntry clip = (ClipEntry)clipEntryListBox.SelectedItem;
                ItemProperty propertyForm = new ItemProperty(clip);

                propertyForm.Show();
            }
        }

        private void editImageToolStripMenuItem_Click(object sender, EventArgs e) {
            if ((clipEntryListBox.SelectedItem != null) && (!editFormOpen)) {
                editingClip = (ClipEntry)clipEntryListBox.SelectedItem;

                if (editingClip.PrincipalFormat == DataFormats.Bitmap) {
                    EditForm editForm = new EditForm((Bitmap)editingClip.PluginData);

                    editForm.Show();
                    editFormOpen = true;

                    editForm.ImageSaved += new EditForm.SaveEventHandler(editForm_ImageSaved);
                    editForm.FormClosed += delegate {
                        editFormOpen = false;
                    };
                }
            }
        }

        void editForm_ImageSaved(object sender, SaveEventArgs e) {
            if (editFormOpen) {
                editingClip.FormattedData = e.Image;
                editingClip.PluginData = e.Image;

                editingClip.MessageText = "Size: " + e.Image.Width + "x" + e.Image.Height + " - Color Depth: "
                                          + Image.GetPixelFormatSize(e.Image.PixelFormat).ToString();

                clipEntryListBox.Invalidate();
            }
        }

        private void sendToClipboardAsToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                Clipboard.SetDataObject(((ClipEntry)clipEntryListBox.SelectedItem).SecondaryPluginData);
            }
            catch (ExternalException ee) {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Threading.ThreadStateException tse) {
                MessageBox.Show(tse.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException) {
                MessageBox.Show("Error in sending the data to clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendToPluginsAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SendToPluginsAsFormat(((ClipEntry)clipEntryListBox.SelectedItem).SecondaryPluginData, DataFormats.Text);
        }

        private void ReadOptions(string configFile) {
            try {
                plugins.PluginConfig.Clear();
                genSettings.Clear();

                XmlDocument settingsToBeParsed = new XmlDocument();

                settingsToBeParsed.Load(configFile);

                foreach (XmlNode xmlGenSetting in settingsToBeParsed.SelectSingleNode("/ClipManSettings/General").ChildNodes)
                    foreach (XmlAttribute setting in xmlGenSetting.Attributes)
                        genSettings.Add(setting.Name, setting.Value);

                foreach (XmlNode plugID in settingsToBeParsed.SelectSingleNode("/ClipManSettings/Plugin").ChildNodes) {
                    NameValueCollection pluginOptions = new NameValueCollection();

                    foreach (XmlNode pluginSetting in plugID.ChildNodes)
                        foreach (XmlAttribute setting in pluginSetting.Attributes)
                            pluginOptions.Add(setting.Name, setting.Value);

                    plugins.PluginConfig.Add(plugID.Name, pluginOptions);
                }
            }
            catch (XmlException xe) {
                MessageBox.Show("Error parsing the configuration file.\n" + xe.Message,
                                "Error during startup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException nre) {
                MessageBox.Show("Configuration File Corrupted!\n" + nre.Message,
                                "Error during startup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.FileNotFoundException fnfe) {
                MessageBox.Show("Configuration File not Found!\n" + fnfe.FileName,
                                "Error during startup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EntryListUp() {
            if (clipEntryListBox.Items.Count > 0) {
                if (clipEntryListBox.SelectedIndex > -1) {
                    if (clipEntryListBox.SelectedIndex != 0) {
                        int selIndex = clipEntryListBox.SelectedIndex;
                        clipEntryListBox.SelectedIndices.Clear();
                        clipEntryListBox.SelectedIndex =  selIndex - 1;
                    }
                }
                else
                    clipEntryListBox.SelectedIndex = 0;
            }
        }

        private void EntryListDown() {
            if (clipEntryListBox.Items.Count > 0) {
                if (clipEntryListBox.SelectedIndex > -1) {
                    if (clipEntryListBox.SelectedIndex != clipEntryListBox.Items.Count - 1) {
                        int selIndex = clipEntryListBox.SelectedIndex;
                        clipEntryListBox.SelectedIndices.Clear();
                        clipEntryListBox.SelectedIndex = selIndex + 1;
                    }
                }
                else
                    clipEntryListBox.SelectedIndex = 0;
            }
        }

        private void EntryListShow() {
            if (!Visible) {
                Visible = true;
                entryListToolStripMenuItem.Checked = true;
            }
            else {
                Visible = false;
                entryListToolStripMenuItem.Checked = false;
            }
        }

        public void RegisterHotKeys() {
            int downModifiers = 0;
            int upModifiers = 0;
            int showModifiers = 0;
            int copyModifiers = 0;

            try {
                if (bool.Parse(genSettings["DownEntryCtrlMod"]))
                    downModifiers |= MOD_CONTROL;

                if (bool.Parse(genSettings["DownEntryAltMod"]))
                    downModifiers |= MOD_ALT;

                if (bool.Parse(genSettings["DownEntryShiftMod"]))
                    downModifiers |= MOD_SHIFT;

                if (bool.Parse(genSettings["UpEntryCtrlMod"]))
                    upModifiers |= MOD_CONTROL;

                if (bool.Parse(genSettings["UpEntryAltMod"]))
                    upModifiers |= MOD_ALT;

                if (bool.Parse(genSettings["UpEntryShiftMod"]))
                    upModifiers |= MOD_SHIFT;

                if (bool.Parse(genSettings["ShowEntryCtrlMod"]))
                    showModifiers |= MOD_CONTROL;

                if (bool.Parse(genSettings["ShowEntryAltMod"]))
                    showModifiers |= MOD_ALT;

                if (bool.Parse(genSettings["ShowEntryShiftMod"]))
                    showModifiers |= MOD_SHIFT;

                if (bool.Parse(genSettings["CopyEntryCtrlMod"]))
                    copyModifiers |= MOD_CONTROL;

                if (bool.Parse(genSettings["CopyEntryAltMod"]))
                    copyModifiers |= MOD_ALT;

                if (bool.Parse(genSettings["CopyEntryShiftMod"]))
                    copyModifiers |= MOD_SHIFT;

                int downKeys = (int)(new KeysConverter()).ConvertFromString(genSettings["DownEntryHotKey"]);
                int upKeys = (int)(new KeysConverter()).ConvertFromString(genSettings["UpEntryHotKey"]);
                int showKeys = (int)(new KeysConverter()).ConvertFromString(genSettings["ShowEntryHotKey"]);
                int copyKeys = (int)(new KeysConverter()).ConvertFromString(genSettings["CopyEntryHotKey"]);

                downAtomID = GlobalAddAtom(DateTime.Now.ToString());
                upAtomID = GlobalAddAtom(DateTime.Now.AddHours(2).ToString());
                showAtomID = GlobalAddAtom(DateTime.Now.AddHours(4).ToString());
                copyAtomID = GlobalAddAtom(DateTime.Now.AddHours(6).ToString());

                if ((downAtomID == 0) || (upAtomID == 0) || (showAtomID == 0) || (copyAtomID == 0))
                    throw new Win32Exception();

                if (RegisterHotKey(this.Handle, downAtomID, downModifiers, downKeys) == 0)
                    throw new Win32Exception();

                if (RegisterHotKey(this.Handle, upAtomID, upModifiers, upKeys) == 0)
                    throw new Win32Exception();

                if (RegisterHotKey(this.Handle, showAtomID, showModifiers, showKeys) == 0)
                    throw new Win32Exception();

                if (RegisterHotKey(this.Handle, copyAtomID, copyModifiers, copyKeys) == 0)
                    throw new Win32Exception();
            }
            catch (FormatException fe) {
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        public void UnregisterHotKeys() {
            UnregisterHotKey(this.Handle, downAtomID);
            UnregisterHotKey(this.Handle, upAtomID);
            UnregisterHotKey(this.Handle, showAtomID);
            UnregisterHotKey(this.Handle, copyAtomID);

            GlobalDeleteAtom(downAtomID);
            GlobalDeleteAtom(upAtomID);
            GlobalDeleteAtom(showAtomID);
            GlobalDeleteAtom(copyAtomID);
        }
    }
}