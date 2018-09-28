using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PluginInterface;

namespace TextPlugin{
    public partial class OptionsForm : Form{
        NameValueCollection settings = new NameValueCollection();
        TextPlugin parentNode;

        private bool firstControlModifier;
        private bool firstAltModifier;
        private bool firstShiftModifier;
        private Keys firstHotKey;

        private bool selectedControlModifier;
        private bool selectedAltModifier;
        private bool selectedShiftModifier;
        private Keys selectedHotKey;

        private bool previousControlModifier;
        private bool previousAltModifier;
        private bool previousShiftModifier;
        private Keys previousHotKey;

        private bool nextControlModifier;
        private bool nextAltModifier;
        private bool nextShiftModifier;
        private Keys nextHotKey;

        private bool hotKeyChanged = false;

        public NameValueCollection TextSettings {
            set { settings = value; }
        }

        public OptionsForm(TextPlugin parent) {
            InitializeComponent();
            parentNode = parent;
        }

        protected override void OnLoad(EventArgs e){
            base.OnLoad(e);

            FillOptionForm();
        }

        private void firstEntryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void nextEntryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void previousEntryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void selectedEntryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
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

        private void firstEntryTextBox_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode != Keys.ControlKey) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Alt) && 
                (e.KeyCode != Keys.Menu) && (e.KeyCode != Keys.LWin) && (e.KeyCode != Keys.RWin)) {

                firstEntryTextBox.Text = DisplayHotkey(e.Control, e.Alt, e.Shift, e.KeyCode);

                firstControlModifier = e.Control;
                firstAltModifier = e.Alt;
                firstShiftModifier = e.Shift;
                firstHotKey = e.KeyCode;

                hotKeyChanged = true;
            }
        }

        private void nextEntryTextBox_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode != Keys.ControlKey) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Alt) &&
                (e.KeyCode != Keys.Menu) && (e.KeyCode != Keys.LWin) && (e.KeyCode != Keys.RWin)) {

                nextEntryTextBox.Text = DisplayHotkey(e.Control, e.Alt, e.Shift, e.KeyCode);

                nextControlModifier = e.Control;
                nextAltModifier = e.Alt;
                nextShiftModifier = e.Shift;
                nextHotKey = e.KeyCode;

                hotKeyChanged = true;
            }
        }
        
        private void previousEntryTextBox_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode != Keys.ControlKey) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Alt) &&
                (e.KeyCode != Keys.Menu) && (e.KeyCode != Keys.LWin) && (e.KeyCode != Keys.RWin)) {

                previousEntryTextBox.Text = DisplayHotkey(e.Control, e.Alt, e.Shift, e.KeyCode);

                previousControlModifier = e.Control;
                previousAltModifier = e.Alt;
                previousShiftModifier = e.Shift;
                previousHotKey = e.KeyCode;

                hotKeyChanged = true;
            }
        }

        private void selectedEntryTextBox_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode != Keys.ControlKey) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Alt) &&
                (e.KeyCode != Keys.Menu) && (e.KeyCode != Keys.LWin) && (e.KeyCode != Keys.RWin)) {

                selectedEntryTextBox.Text = DisplayHotkey(e.Control, e.Alt, e.Shift, e.KeyCode);

                selectedControlModifier = e.Control;
                selectedAltModifier = e.Alt;
                selectedShiftModifier = e.Shift;
                selectedHotKey = e.KeyCode;

                hotKeyChanged = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void entryListMaxLengthTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != 8)
                if (!char.IsNumber(e.KeyChar))
                    e.Handled = true;
        }

        private void FillOptionForm() {
            KeysConverter kc = new KeysConverter();

            emailToEntryListCheckBox.Checked = bool.Parse(settings["AddEmailToList"]);
            urlToEntryListCheckBox.Checked = bool.Parse(settings["AddUrlToList"]);

            emailToClientCheckBox.Checked = bool.Parse(settings["CatchEmail"]);
            urlToClientCheckBox.Checked = bool.Parse(settings["CatchUrl"]);

            entryListMaxLengthTextBox.Text = settings["EntryListLength"];

            firstControlModifier = bool.Parse(settings["FirstEntryCtrlMod"]);
            firstAltModifier = bool.Parse(settings["FirstEntryAltMod"]);
            firstShiftModifier = bool.Parse(settings["FirstEntryShiftMod"]);
            firstHotKey = (Keys)kc.ConvertFromString(settings["FirstEntryHotKey"]);

            selectedControlModifier = bool.Parse(settings["SelectedEntryCtrlMod"]);
            selectedAltModifier = bool.Parse(settings["SelectedEntryAltMod"]);
            selectedShiftModifier = bool.Parse(settings["SelectedEntryShiftMod"]);
            selectedHotKey = (Keys)kc.ConvertFromString(settings["SelectedEntryHotKey"]);

            previousControlModifier = bool.Parse(settings["PreviousEntryCtrlMod"]);
            previousAltModifier = bool.Parse(settings["PreviousEntryAltMod"]);
            previousShiftModifier = bool.Parse(settings["PreviousEntryShiftMod"]);
            previousHotKey = (Keys)kc.ConvertFromString(settings["PreviousEntryHotKey"]);

            nextControlModifier = bool.Parse(settings["NextEntryCtrlMod"]);
            nextAltModifier = bool.Parse(settings["NextEntryAltMod"]);
            nextShiftModifier = bool.Parse(settings["NextEntryShiftMod"]);
            nextHotKey = (Keys)kc.ConvertFromString(settings["NextEntryHotKey"]);

            firstEntryTextBox.Text = DisplayHotkey(firstControlModifier, firstAltModifier, firstShiftModifier, firstHotKey);
            selectedEntryTextBox.Text = DisplayHotkey(selectedControlModifier, selectedAltModifier, selectedShiftModifier, selectedHotKey);
            previousEntryTextBox.Text = DisplayHotkey(previousControlModifier, previousAltModifier, previousShiftModifier, previousHotKey);
            nextEntryTextBox.Text = DisplayHotkey(nextControlModifier, nextAltModifier, nextShiftModifier, nextHotKey);

            if (bool.Parse(settings["PasteType"]))
                pasteOnComboBox.SelectedIndex = 0;
            else
                pasteOnComboBox.SelectedIndex = 1;
        }

        private void FillOptionsNVCollection() {
            settings.Clear();

            settings.Add("AddEmailToList", emailToEntryListCheckBox.Checked.ToString());
            settings.Add("AddUrlToList", urlToEntryListCheckBox.Checked.ToString());

            settings.Add("CatchEmail", emailToClientCheckBox.Checked.ToString());
            settings.Add("CatchUrl", urlToClientCheckBox.Checked.ToString());

            settings.Add("EntryListLength", entryListMaxLengthTextBox.Text);

            settings.Add("FirstEntryCtrlMod", firstControlModifier.ToString());
            settings.Add("FirstEntryAltMod", firstAltModifier.ToString());
            settings.Add("FirstEntryShiftMod", firstShiftModifier.ToString());
            settings.Add("FirstEntryHotKey", firstHotKey.ToString());

            settings.Add("SelectedEntryCtrlMod", selectedControlModifier.ToString());
            settings.Add("SelectedEntryAltMod", selectedAltModifier.ToString());
            settings.Add("SelectedEntryShiftMod", selectedShiftModifier.ToString());
            settings.Add("SelectedEntryHotKey", selectedHotKey.ToString());

            settings.Add("PreviousEntryCtrlMod", previousControlModifier.ToString());
            settings.Add("PreviousEntryAltMod", previousAltModifier.ToString());
            settings.Add("PreviousEntryShiftMod", previousShiftModifier.ToString());
            settings.Add("PreviousEntryHotKey", previousHotKey.ToString());

            settings.Add("NextEntryCtrlMod", nextControlModifier.ToString());
            settings.Add("NextEntryAltMod", nextAltModifier.ToString());
            settings.Add("NextEntryShiftMod", nextShiftModifier.ToString());
            settings.Add("NextEntryHotKey", nextHotKey.ToString());

            if (pasteOnComboBox.SelectedIndex == 0)
                settings.Add("PasteType", "True");
            else
                settings.Add("PasteType", "False");

            parentNode.Host.WritePluginOptions((IPlugin)parentNode);
        }

        private void okButton_Click(object sender, EventArgs e) {
            FillOptionsNVCollection();

            parentNode.InitSettings();

            if (hotKeyChanged) {
                try {
                    parentNode.UnregisterHotKeys();
                    parentNode.RegisterHotKeys();
                }
                catch (Win32Exception w3e) {
                    MessageBox.Show("Error registering selected hotkeys:\n" + w3e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Close();
        }

        private void entryListEditButton_Click(object sender, EventArgs e) {
            EntryListEdit ele = new EntryListEdit(int.Parse(settings["EntryListLength"]));

            ele.Entries = parentNode.Entries;
            ele.Show();
        }
    }
}