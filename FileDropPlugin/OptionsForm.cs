using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PluginInterface;

namespace FileDropPlugin {
    public partial class OptionsForm : Form {
        NameValueCollection settings = new NameValueCollection();
        FileDropPlugin parentNode;

        public NameValueCollection FileDropSettings {
            set { settings = value; }
        }

        public OptionsForm(FileDropPlugin parent) {
            InitializeComponent();
            parentNode = parent;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            FillOptionForm();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e) {
            FillOptionsNVCollection();
            parentNode.InitSettings();

            Close();
        }

        private void FillOptionForm() {
            try {
                switch (int.Parse(settings["OutputNameType"])) {
                    case 0:
                        nameTypeComboBox.SelectedIndex = 0;
                        filenameTextBox.Text = settings["OutputName"];
                        break;

                    case 1:
                        nameTypeComboBox.SelectedIndex = 1;
                        filenameTextBox.Text = settings["OutputName"];
                        break;
                }

                switch (settings["PathStyle"]) {
                    case "None":
                        pathStyleComboBox.SelectedIndex = 0;
                        break;

                    case "Full":
                        pathStyleComboBox.SelectedIndex = 1;
                        break;

                    case "Relative":
                        pathStyleComboBox.SelectedIndex = 2;
                        break;
                }

                switch (bool.Parse(settings["DeflateFiles"])) {
                    case true:
                        compressionMethodComboBox.SelectedIndex = 0;
                        break;

                    case false:
                        compressionMethodComboBox.SelectedIndex = 1;
                        break;
                }

                recursiveSubdirCheckBox.Checked = bool.Parse(settings["RecursiveSubDirectories"]);

                compressionLevelTrackBar.Value = int.Parse(settings["CompressionLevel"]);

                zipCommentTextBox.Text = settings["ZipComment"];
                zipPasswordTextBox.Text = settings["ZipPassword"];
                outDirTextBox.Text = settings["OutputDir"];
            }
            catch (FormatException fe) {
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillOptionsNVCollection() {
            settings.Clear();

            switch (nameTypeComboBox.SelectedIndex) {
                case 0:
                    settings.Add("OutputNameType", "0");
                    settings.Add("OutputName", "");
                    break;

                case 1:
                    settings.Add("OutputNameType", "1");
                    settings.Add("OutputName", filenameTextBox.Text);
                    break;
            }

            switch (pathStyleComboBox.SelectedIndex) {
                case 0:
                    settings.Add("PathStyle", PathStyle.None.ToString());
                    break;

                case 1:
                    settings.Add("PathStyle", PathStyle.Full.ToString());
                    break;

                case 2:
                    settings.Add("PathStyle", PathStyle.Relative.ToString());
                    break;
            }

            switch (compressionMethodComboBox.SelectedIndex) {
                case 0:
                    settings.Add("DeflateFiles", "True");
                    break;

                case 1:
                    settings.Add("DeflateFiles", "False");
                    break;
            }

            settings.Add("RecursiveSubDirectories", recursiveSubdirCheckBox.Checked.ToString());
            settings.Add("CompressionLevel", compressionLevelTrackBar.Value.ToString());

            settings.Add("ZipComment", zipCommentTextBox.Text);
            settings.Add("ZipPassword", zipPasswordTextBox.Text);
            settings.Add("OutputDir", outDirTextBox.Text);

            parentNode.Host.WritePluginOptions((IPlugin)parentNode);
        }

        private void outDirButton_Click(object sender, EventArgs e) {
            if (!outDirTextBox.Text.Equals(""))
                folderBrowserDialog.SelectedPath = outDirTextBox.Text;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                outDirTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void nameTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            switch (nameTypeComboBox.SelectedIndex) { 
                case 0:
                    filenameTextBox.Enabled = false;
                    break;

                case 1:
                    filenameTextBox.Enabled = true;
                    break;
            }
        }
    }
}