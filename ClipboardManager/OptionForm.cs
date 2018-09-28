using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClipboardManager{
    public partial class OptionForm : Form{
        private bool pluginDirChanged = false;
        private bool hotKeyChanged = false;

        private bool showControlModifier;
        private bool showAltModifier;
        private bool showShiftModifier;
        private Keys showHotKey;

        private bool upControlModifier;
        private bool upAltModifier;
        private bool upShiftModifier;
        private Keys upHotKey;

        private bool downControlModifier;
        private bool downAltModifier;
        private bool downShiftModifier;
        private Keys downHotKey;

        private bool copyControlModifier;
        private bool copyAltModifier;
        private bool copyShiftModifier;
        private Keys copyHotKey;

        private MainForm parent;

        private Hashtable plugins = new Hashtable();
        private Hashtable pluginToCombo = new Hashtable();

        private NameValueCollection genSettings = new NameValueCollection();

        public Hashtable PluginsRegistered{
            set { plugins = value; }
        }

        public NameValueCollection GeneralSettings{
            set { genSettings = value; }
        }
        
        public OptionForm(MainForm parent){
            this.parent = parent;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e){
            base.OnLoad(e);

            FillOptionForm();
        }

        private void pluginDirListBox_DoubleClick(object sender, EventArgs e){
            if (pluginDirListBox.SelectedIndex != -1){
                folderBrowserDialog.SelectedPath = (string)pluginDirListBox.Items[pluginDirListBox.SelectedIndex];
                DialogResult pluginDir = folderBrowserDialog.ShowDialog();

                if (pluginDir == DialogResult.OK){
                    if (!pluginDirListBox.Items[pluginDirListBox.SelectedIndex].ToString().Equals(folderBrowserDialog.SelectedPath)){
                        pluginDirListBox.Items[pluginDirListBox.SelectedIndex] = folderBrowserDialog.SelectedPath;
                        pluginDirChanged = true;
                        applyButton.Enabled = true;
                    }
                }
            }
        }

        private void pluginsComboBox_SelectedIndexChanged(object sender, EventArgs e){
            PluginInstance plugInfo = (PluginInstance)plugins[pluginToCombo[pluginsComboBox.SelectedIndex]];

            authorLabel.Text = plugInfo.Instance.PlugAuthor;
            versionLabel.Text = plugInfo.Instance.PlugVersion;
            descLabel.Text = plugInfo.Instance.PlugDescription;

            pluginOptionsButton.Enabled = plugInfo.Instance.IsOptionsFormPresent;

            if (plugInfo.Instance.HasIcon)
                pluginImagePictureBox.Image = plugInfo.Instance.PlugImage;
            else
                pluginImagePictureBox.Image = null;

            if (plugInfo.Instance.PlugOptions["EnabledPlugin"] != null)
                enabledPluginCheckBox.Checked = bool.Parse(plugInfo.Instance.PlugOptions["EnabledPlugin"]);
            else
                enabledPluginCheckBox.Checked = true;
        }

        private void pluginAboutButton_Click(object sender, EventArgs e){
            PluginInstance plugAboutForm = (PluginInstance)plugins[pluginToCombo[pluginsComboBox.SelectedIndex]];

            if (plugAboutForm.Instance.IsAboutFormPresent){
                Form aboutForm = plugAboutForm.Instance.AboutForm;
                aboutForm.Show();
            }
            else
                MessageBox.Show("Author: " + plugAboutForm.Instance.PlugAuthor + "\nVersion: " + plugAboutForm.Instance.PlugVersion + 
                                "\nDescription: " + plugAboutForm.Instance.PlugDescription, plugAboutForm.Instance.PlugName, 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pluginOptionsButton_Click(object sender, EventArgs e){
            PluginInstance pluginOptForm = (PluginInstance)plugins[pluginToCombo[pluginsComboBox.SelectedIndex]];

            Form optionForm = pluginOptForm.Instance.OptionsForm;
            optionForm.Show();
        }


        private void applyButton_Click(object sender, EventArgs e) {
            try {
                RegistryKey startupPathKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                if (startupCheckBox.Checked)
                    startupPathKey.SetValue("ClipManStartup", "\"" + Application.ExecutablePath + "\"", RegistryValueKind.String);
                else
                    startupPathKey.DeleteValue("ClipManStartup", false);
            }
            catch (ObjectDisposedException ode) {
                MessageBox.Show("Error while setting Program Startup.\n" + ode.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Security.SecurityException se) {
                MessageBox.Show("Error while setting Program Startup.\n" + se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException uae) {
                MessageBox.Show("Error while setting Program Startup.\n" + uae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FillOptionNVCollection();

            applyButton.Enabled = false;
        }

        private void okButton_Click(object sender, EventArgs e) {
            applyButton_Click(sender, e);
            
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e){
            Close();
        }

        private void FillOptionForm(){
            try{
                string[] pluginPath;

                KeysConverter kc = new KeysConverter();
                
                pluginPath = genSettings["PluginDir"].Split(new char[] { ',' });

                foreach (string path in pluginPath)
                    pluginDirListBox.Items.Add(path);

                startupCheckBox.Checked = bool.Parse(genSettings["LoadOnWindows"]);

                onTopCheckBox.Checked = bool.Parse(genSettings["WindowOnTop"]);
                savePosCheckBox.Checked = bool.Parse(genSettings["SaveWindowPos"]);

                int opacityValue = int.Parse(genSettings["WindowOpacity"]);

                if (opacityValue < 100)
                    opacityCheckBox.Checked = true;
                else
                    opacityCheckBox.Checked = false;

                opacityTrackBar.Value = opacityValue;
                opacityNumericUpDown.Value = opacityValue;

                colorPictureBox.BackColor = Color.FromArgb(int.Parse(genSettings["WindowBackColor"]));

                showControlModifier = bool.Parse(genSettings["ShowEntryCtrlMod"]);
                showAltModifier = bool.Parse(genSettings["ShowEntryAltMod"]);
                showShiftModifier = bool.Parse(genSettings["ShowEntryShiftMod"]);
                showHotKey = (Keys)kc.ConvertFromString(genSettings["ShowEntryHotKey"]);

                upControlModifier = bool.Parse(genSettings["UpEntryCtrlMod"]);
                upAltModifier = bool.Parse(genSettings["UpEntryAltMod"]);
                upShiftModifier = bool.Parse(genSettings["UpEntryShiftMod"]);
                upHotKey = (Keys)kc.ConvertFromString(genSettings["UpEntryHotKey"]);

                downControlModifier = bool.Parse(genSettings["DownEntryCtrlMod"]);
                downAltModifier = bool.Parse(genSettings["DownEntryAltMod"]);
                downShiftModifier = bool.Parse(genSettings["DownEntryShiftMod"]);
                downHotKey = (Keys)kc.ConvertFromString(genSettings["DownEntryHotKey"]);

                copyControlModifier = bool.Parse(genSettings["CopyEntryCtrlMod"]);
                copyAltModifier = bool.Parse(genSettings["CopyEntryAltMod"]);
                copyShiftModifier = bool.Parse(genSettings["CopyEntryShiftMod"]);
                copyHotKey = (Keys)kc.ConvertFromString(genSettings["CopyEntryHotKey"]);

                showWindowTextBox.Text = DisplayHotkey(showControlModifier, showAltModifier, showShiftModifier, showHotKey);
                upEntryTextBox.Text = DisplayHotkey(upControlModifier, upAltModifier, upShiftModifier, upHotKey);
                downEntryTextBox.Text = DisplayHotkey(downControlModifier, downAltModifier, downShiftModifier, downHotKey);
                copyEntryTextBox.Text = DisplayHotkey(copyControlModifier, copyAltModifier, copyShiftModifier, copyHotKey);
            }
            catch (FormatException fe){
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            foreach (int plugID in plugins.Keys)
                pluginToCombo.Add(pluginsComboBox.Items.Add(((PluginInstance)plugins[plugID]).Instance.PlugName), plugID);

            if (pluginsComboBox.Items.Count > 0)
                pluginsComboBox.SelectedIndex = 0;
            else {
                pluginAboutButton.Enabled = false;
                pluginOptionsButton.Enabled = false;
                enabledPluginCheckBox.Enabled = false;
            }
        }

        private void FillOptionNVCollection(){
            genSettings.Clear();
            
            foreach (string path in pluginDirListBox.Items)
                genSettings.Add("PluginDir", path);

            genSettings.Add("LoadOnWindows", startupCheckBox.Checked.ToString());

            genSettings.Add("WindowOnTop", onTopCheckBox.Checked.ToString());
            genSettings.Add("SaveWindowPos", savePosCheckBox.Checked.ToString());

            if (opacityCheckBox.Checked)
                genSettings.Add("WindowOpacity", opacityTrackBar.Value.ToString());
            else
                genSettings.Add("WindowOpacity", (100).ToString());

            genSettings.Add("WindowBackColor", colorPictureBox.BackColor.ToArgb().ToString());

            if (showWindowTextBox.Text != string.Empty) {
                genSettings.Add("ShowEntryCtrlMod", showControlModifier.ToString());
                genSettings.Add("ShowEntryAltMod", showAltModifier.ToString());
                genSettings.Add("ShowEntryShiftMod", showShiftModifier.ToString());
                genSettings.Add("ShowEntryHotKey", showHotKey.ToString());
            }

            if (upEntryTextBox.Text != string.Empty) {
                genSettings.Add("UpEntryCtrlMod", upControlModifier.ToString());
                genSettings.Add("UpEntryAltMod", upAltModifier.ToString());
                genSettings.Add("UpEntryShiftMod", upShiftModifier.ToString());
                genSettings.Add("UpEntryHotKey", upHotKey.ToString());
            }

            if (downEntryTextBox.Text != string.Empty) {
                genSettings.Add("DownEntryCtrlMod", downControlModifier.ToString());
                genSettings.Add("DownEntryAltMod", downAltModifier.ToString());
                genSettings.Add("DownEntryShiftMod", downShiftModifier.ToString());
                genSettings.Add("DownEntryHotKey", downHotKey.ToString());
            }

            if (copyEntryTextBox.Text != string.Empty) {
                genSettings.Add("CopyEntryCtrlMod", copyControlModifier.ToString());
                genSettings.Add("CopyEntryAltMod", copyAltModifier.ToString());
                genSettings.Add("CopyEntryShiftMod", copyShiftModifier.ToString());
                genSettings.Add("CopyEntryHotKey", copyHotKey.ToString());
            }

            if (hotKeyChanged)
                parent.UnregisterHotKeys();

            parent.InitClipMan(pluginDirChanged, hotKeyChanged);

            parent.PlugHost.WriteOptions();
        }

        private void removePluginDirButton_Click(object sender, EventArgs e){
            if (pluginDirListBox.SelectedIndex != -1){
                int selectedItem = pluginDirListBox.SelectedIndex;
                pluginDirListBox.Items.RemoveAt(selectedItem );
                pluginDirListBox.SelectedIndex = selectedItem - 1;

                pluginDirChanged = true;
                applyButton.Enabled = true;
            }
        }

        private void addPluginDirButton_Click(object sender, EventArgs e){
            folderBrowserDialog.SelectedPath = "";
            DialogResult pluginDir = folderBrowserDialog.ShowDialog();

            if (pluginDir == DialogResult.OK){
                pluginDirListBox.Items.Add(folderBrowserDialog.SelectedPath);
                removePluginDirButton.Enabled = true;
                pluginDirChanged = true;
                applyButton.Enabled = true;
            }
        }

        private void pluginDirListBox_SelectedIndexChanged(object sender, EventArgs e){
            if (pluginDirListBox.Items.Count == 0)
                removePluginDirButton.Enabled = false;
            else
                removePluginDirButton.Enabled = true;
        }

        private void enabledPluginCheckBox_CheckedChanged(object sender, EventArgs e) {
            ((PluginInstance)plugins[pluginToCombo[pluginsComboBox.SelectedIndex]]).Enabled = enabledPluginCheckBox.Checked;
        }

        private void showWindowTextBox_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode != Keys.ControlKey) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Alt) &&
                (e.KeyCode != Keys.Menu) && (e.KeyCode != Keys.LWin) && (e.KeyCode != Keys.RWin)) {

                showWindowTextBox.Text = DisplayHotkey(e.Control, e.Alt, e.Shift, e.KeyCode);

                showControlModifier = e.Control;
                showAltModifier = e.Alt;
                showShiftModifier = e.Shift;
                showHotKey = e.KeyCode;

                hotKeyChanged = true;
                applyButton.Enabled = true;
            }
        }

        private void upEntryTextBox_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode != Keys.ControlKey) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Alt) &&
                (e.KeyCode != Keys.Menu) && (e.KeyCode != Keys.LWin) && (e.KeyCode != Keys.RWin)) {

                upEntryTextBox.Text = DisplayHotkey(e.Control, e.Alt, e.Shift, e.KeyCode);

                upControlModifier = e.Control;
                upAltModifier = e.Alt;
                upShiftModifier = e.Shift;
                upHotKey = e.KeyCode;

                hotKeyChanged = true;
                applyButton.Enabled = true;
            }
        }

        private void downEntryTextBox_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode != Keys.ControlKey) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Alt) &&
                (e.KeyCode != Keys.Menu) && (e.KeyCode != Keys.LWin) && (e.KeyCode != Keys.RWin)) {

                downEntryTextBox.Text = DisplayHotkey(e.Control, e.Alt, e.Shift, e.KeyCode);

                downControlModifier = e.Control;
                downAltModifier = e.Alt;
                downShiftModifier = e.Shift;
                downHotKey = e.KeyCode;

                hotKeyChanged = true;
                applyButton.Enabled = true;
            }
        }

        private void copyEntryTextBox_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode != Keys.ControlKey) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Alt) &&
                (e.KeyCode != Keys.Menu) && (e.KeyCode != Keys.LWin) && (e.KeyCode != Keys.RWin)) {

                copyEntryTextBox.Text = DisplayHotkey(e.Control, e.Alt, e.Shift, e.KeyCode);

                copyControlModifier = e.Control;
                copyAltModifier = e.Alt;
                copyShiftModifier = e.Shift;
                copyHotKey = e.KeyCode;

                hotKeyChanged = true;
                applyButton.Enabled = true;
            }
        }

        private void showWindowTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void upEntryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void downEntryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void copyEntryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private string DisplayHotkey(bool ctrlMod, bool altMod, bool shiftMod, Keys hotKey) {
            string sHotKey = "";

            if (ctrlMod) {
                if (sHotKey.Length != 0) sHotKey += " + ";
                sHotKey += "Ctrl";
            }

            if (altMod) {
                if (sHotKey.Length != 0) sHotKey += " + ";
                sHotKey += "Alt";
            }

            if (shiftMod) {
                if (sHotKey.Length != 0) sHotKey += " + ";
                sHotKey += "Shift";
            }

            if (sHotKey.Length != 0) {
                sHotKey += " + ";
                sHotKey += hotKey.ToString();
            }

            return sHotKey;
        }

        private void opacityCheckBox_CheckedChanged(object sender, EventArgs e) {
            opacityTrackBar.Enabled = opacityCheckBox.Checked;
            opacityNumericUpDown.Enabled = opacityCheckBox.Checked;
            applyButton.Enabled = true;
        }

        private void opacityTrackBar_Scroll(object sender, EventArgs e) {
            opacityNumericUpDown.Value = opacityTrackBar.Value;
            applyButton.Enabled = true;
        }

        private void opacityNumericUpDown_ValueChanged(object sender, EventArgs e) {
            opacityTrackBar.Value = (int)opacityNumericUpDown.Value;
            applyButton.Enabled = true;
        }

        private void colorPictureBox_Click(object sender, EventArgs e) {
            colorDialog.Color = colorPictureBox.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK) {
                colorPictureBox.BackColor = colorDialog.Color;

                applyButton.Enabled = true;
            }
        }

        private void resetColorButton_Click(object sender, EventArgs e) {
            if (colorPictureBox.BackColor != SystemColors.Control) {
                colorPictureBox.BackColor = SystemColors.Control;
                applyButton.Enabled = true;
            }
        }

        private void startupCheckBox_CheckedChanged(object sender, EventArgs e) {
            applyButton.Enabled = true;
        }

        private void onTopCheckBox_CheckedChanged(object sender, EventArgs e) {
            applyButton.Enabled = true;
        }

        private void savePosCheckBox_CheckedChanged(object sender, EventArgs e) {
            applyButton.Enabled = true;
        }

        private void OptionForm_Shown(object sender, EventArgs e) {
            applyButton.Enabled = false;
        }
    }
}