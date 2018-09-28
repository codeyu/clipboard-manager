using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextPlugin {
    public partial class EntryListEdit : Form {
        EntryList entries;
        EntryList entriesNew;

        int selectedEntry;
        int maxSize;

        public EntryList Entries {
            set { entries = value; }
        }
        
        public EntryListEdit(int MaxSize) {
            InitializeComponent();
            maxSize = MaxSize;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            FillListBox();
        }

        private void FillListBox() {
            entryListListBox.Items.Clear();

            entriesNew = new EntryList();
            entriesNew.MaxSize = maxSize;

            entryListListBox.BeginUpdate();

            for (int i = 0; i < entries.Count; i++) {
                entryListListBox.Items.Add(entries[i]);
                entriesNew.Add(entries[i]);
            }

            entryListListBox.EndUpdate();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e) {
            applyButton_Click(sender, e);
            Close();
        }

        private void entryListListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (entryListListBox.SelectedIndex != -1) {
                selectedEntry = entryListListBox.SelectedIndex;
                
                entryTextBox.Text = entryListListBox.Items[selectedEntry].ToString();
                entryTextBox.Enabled = true;
                entryTextBox.Focus();
            }
        }

        private void entrySaveButton_Click(object sender, EventArgs e) {
            if (entryTextBox.Enabled) {
                entriesNew[selectedEntry] = entryTextBox.Text;
                entryListListBox.Items[selectedEntry] = entryTextBox.Text;

                applyButton.Enabled = true;
            }
        }

        private void entryDeleteButton_Click(object sender, EventArgs e) {
            if ((selectedEntry != -1) && (entriesNew.Count > 0)) {
                entriesNew.RemoveAt(selectedEntry);
                entryListListBox.Items.RemoveAt(selectedEntry);

                entryTextBox.Text = "";
                entryTextBox.Enabled = false;

                selectedEntry = -1;

                entryListListBox.Focus();

                applyButton.Enabled = true;
            }
        }

        private void applyButton_Click(object sender, EventArgs e) {
            entries.Clear();

            entries.MaxSize = maxSize;

            if (entriesNew.Count == 0)
                Clipboard.Clear();
            else
                for (int i = 0; i < entriesNew.Count; i++)
                    entries.Add(entriesNew[i]);

            applyButton.Enabled = false;
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            FillListBox();
            applyButton.Enabled = false;
        }

        private void entryAtFirstButton_Click(object sender, EventArgs e) {
            if ((entryListListBox.SelectedIndex != -1) && (entryListListBox.SelectedIndex != 0) && (entryListListBox.Items.Count > 1)) {
                int itemPos = entryListListBox.SelectedIndex;

                entryListListBox.BeginUpdate();

                entriesNew.Insert(0, (string)entryListListBox.Items[itemPos]);
                entryListListBox.Items.Insert(0, entryListListBox.Items[itemPos]);

                entriesNew.RemoveAt(itemPos + 1);
                entryListListBox.Items.RemoveAt(itemPos + 1);

                entryListListBox.SelectedIndex = 0;

                entryListListBox.EndUpdate();

                applyButton.Enabled = true;
            }
        }

        private void entryAtLastButton_Click(object sender, EventArgs e) {
            if ((entryListListBox.SelectedIndex != -1) && (entryListListBox.Items.Count > 1)
                && (entryListListBox.SelectedIndex + 1 < entryListListBox.Items.Count)) {

                int itemPos = entryListListBox.SelectedIndex;

                entryListListBox.BeginUpdate();

                entriesNew.Insert(entriesNew.Count, (string)entryListListBox.Items[itemPos]);
                entryListListBox.Items.Insert(entryListListBox.Items.Count, entryListListBox.Items[itemPos]);

                entriesNew.RemoveAt(itemPos);
                entryListListBox.Items.RemoveAt(itemPos);

                entryListListBox.SelectedIndex = entryListListBox.Items.Count - 1;

                entryListListBox.EndUpdate();

                applyButton.Enabled = true;
            }
        }

        private void entryAtUpButton_Click(object sender, EventArgs e) {
            if ((entryListListBox.SelectedIndex != -1) && (entryListListBox.SelectedIndex != 0) && 
                (entryListListBox.Items.Count > 1) && (entryListListBox.SelectedIndex - 1 != -1)) {

                int itemPos = entryListListBox.SelectedIndex;

                entryListListBox.BeginUpdate();

                entriesNew.Insert(itemPos - 1, (string)entryListListBox.Items[itemPos]);
                entryListListBox.Items.Insert(itemPos - 1, entryListListBox.Items[itemPos]);

                entriesNew.RemoveAt(itemPos + 1);
                entryListListBox.Items.RemoveAt(itemPos + 1);

                entryListListBox.SelectedIndex = itemPos - 1;

                entryListListBox.EndUpdate();

                applyButton.Enabled = true;
            }
        }

        private void entryAtBottomButton_Click(object sender, EventArgs e) {
            if ((entryListListBox.SelectedIndex != -1) && (entryListListBox.Items.Count > 1) 
                && (entryListListBox.SelectedIndex + 1 < entryListListBox.Items.Count)) {

                int itemPos = entryListListBox.SelectedIndex;

                entryListListBox.BeginUpdate();

                entriesNew.Insert(itemPos + 2, (string)entryListListBox.Items[itemPos]);
                entryListListBox.Items.Insert(itemPos + 2, entryListListBox.Items[itemPos]);

                entriesNew.RemoveAt(itemPos);
                entryListListBox.Items.RemoveAt(itemPos);

                entryListListBox.SelectedIndex = itemPos + 1;

                entryListListBox.EndUpdate();

                applyButton.Enabled = true;
            }
        }
    }
}