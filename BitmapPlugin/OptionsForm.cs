using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;
using PluginInterface;

namespace BitmapPlugin{
    public partial class OptionsForm : Form{
        NameValueCollection settings = new NameValueCollection();
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
        IPlugin parentNode;

        public NameValueCollection FormatSettings{
            set { settings = value; }
        }
        
        public OptionsForm(IPlugin parent){
            InitializeComponent();
            parentNode = parent;
        }

        protected override void OnLoad(EventArgs e){
            base.OnLoad(e);

            saveFormatComboBox.Items.Add("Animated GIF");

            foreach (ImageCodecInfo codec in codecs){
                saveFormatComboBox.Items.Add(codec.CodecName);
            }

            FillOptionsForm();
        }

        private void saveFormatComboBox_SelectedIndexChanged(object sender, EventArgs e){
            animatedGifPanel.Visible = false;
            bmpGifPanel.Visible = false;
            jpegPanel.Visible = false;
            pngPanel.Visible = false;
            tiffPanel.Visible = false;
            
            switch (saveFormatComboBox.SelectedIndex){
                case 0:
                    animatedGifPanel.Visible = true;
                    break;
                case 1:
                    bmpGifPanel.Visible = true;
                    break;
                case 2:
                    jpegPanel.Visible = true;
                    break;
                case 3:
                    bmpGifPanel.Visible = true;
                    break;
                case 4:
                    tiffPanel.Visible = true;
                    break;
                case 5:
                    pngPanel.Visible = true;
                    break;
            }
        }

        private void jpegPanelQualityTrackBar_Scroll(object sender, EventArgs e){
            jpegPanelQualityNumericUpDown.Value = jpegPanelQualityTrackBar.Value;
        }

        private void jpegPanelQualityNumericUpDown_ValueChanged(object sender, EventArgs e){
            jpegPanelQualityTrackBar.Value = (int)jpegPanelQualityNumericUpDown.Value;
        }

        private void cancelButton_Click(object sender, EventArgs e){
            Close();
        }

        private void okButton_Click(object sender, EventArgs e){
            if (saveFormatComboBox.SelectedIndex == 0){
                if (MessageBox.Show("This format can be very slow to process to images.\nBefore adding an image, you must wait for the the " +
                                    "previous frame messagebox to be shown.\nDo you want to select Animated GIF anyway?", "Warning",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){

                    FillOptionsNVCollection();
                    Close();
                }
            }
            else{
                FillOptionsNVCollection();
                Close();
            }
        }

        private void FillOptionsForm(){
            try {
                if (settings["AniGIFTrasparent"] != null) {
                    if (settings["AniGIFTrasparent"].Equals("NULL")) {
                        anigifPanelTrasparentPictureBox.Enabled = false;
                        anigifPanelNoTrasparentCheckBox.Checked = true;
                    }
                    else {
                        anigifPanelTrasparentPictureBox.BackColor = Color.FromArgb(int.Parse(settings["AniGIFTrasparent"]));
                        anigifPanelNoTrasparentCheckBox.Checked = false;
                    }
                }

                if (settings["AniGIFQuality"] != null)
                    anigifPanelQualityTrackBar.Value = int.Parse(settings["AniGIFQuality"]);

                if (settings["AniGIFFrameRate"] != null)
                    anigifPanelFrameRateNumericUpDown.Value = int.Parse(settings["AniGIFFrameRate"]);

                if (settings["AniGIFRepeat"] != null)
                    anigifPanelRepeatNumericUpDown.Value = int.Parse(settings["AniGIFRepeat"]);

                if (settings["AniGIFNumFrames"] != null)
                    anigifPanelFrameNumberTextBox.Text = settings["AniGIFNumFrames"];

                if (settings["JPEGQuality"] != null) {
                    jpegPanelQualityTrackBar.Value = int.Parse(settings["JPEGQuality"]);
                    jpegPanelQualityNumericUpDown.Value = jpegPanelQualityTrackBar.Value;
                }

                if (settings["JPEGEncoding"] != null)
                    jpegPanelEncodingCheckBox.Checked = bool.Parse(settings["JPEGEncoding"]);

                if (settings["PNGEncoding"] != null)
                    pngPanelInterlacedCheckBox.Checked = bool.Parse(settings["PNGEncoding"]);

                if (settings["TIFFCompression"] != null)
                    tiffPanelCompressionComboBox.SelectedIndex = int.Parse(settings["TIFFCompression"]);

                if (settings["SelectedFormat"] != null)
                    saveFormatComboBox.SelectedIndex = int.Parse(settings["SelectedFormat"]);

                if (settings["OutputDir"] != null)
                    outDirTextBox.Text = settings["OutputDir"];

                if (settings["PrefixOutputName"] != null)
                    prefixTextBox.Text = settings["PrefixOutputName"];

                if (settings["SuffixOutputName"] != null)
                    suffixTextBox.Text = settings["SuffixOutputName"];
            }
            catch (FormatException fe) {
                MessageBox.Show("Error parsing the configuration file.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillOptionsNVCollection(){
            settings.Clear();

            if (anigifPanelNoTrasparentCheckBox.Checked)
                settings.Add("AniGIFTrasparent", "NULL");
            else
                settings.Add("AniGIFTrasparent", anigifPanelTrasparentPictureBox.BackColor.ToArgb().ToString());

            settings.Add("AniGIFQuality", anigifPanelQualityTrackBar.Value.ToString());
            settings.Add("AniGIFFrameRate", anigifPanelFrameRateNumericUpDown.Value.ToString());
            settings.Add("AniGIFRepeat", anigifPanelRepeatNumericUpDown.Value.ToString());
            settings.Add("AniGIFNumFrames", anigifPanelFrameNumberTextBox.Text);
            
            settings.Add("JPEGQuality", jpegPanelQualityTrackBar.Value.ToString());
            settings.Add("JPEGEncoding", jpegPanelEncodingCheckBox.Checked.ToString());

            settings.Add("PNGEncoding", pngPanelInterlacedCheckBox.Checked.ToString());
            
            settings.Add("TIFFCompression", tiffPanelCompressionComboBox.SelectedIndex.ToString());

            settings.Add("SelectedFormat", saveFormatComboBox.SelectedIndex.ToString());

            settings.Add("OutputDir", outDirTextBox.Text);
            settings.Add("PrefixOutputName", prefixTextBox.Text);
            settings.Add("SuffixOutputName", suffixTextBox.Text);

            parentNode.Host.WritePluginOptions(parentNode);
        }

        private void outDirButton_Click(object sender, EventArgs e){
            if (!outDirTextBox.Text.Equals(""))
                folderBrowserDialog.SelectedPath = outDirTextBox.Text;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                outDirTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void prefixTextBox_TextChanged(object sender, EventArgs e){
            outExampleNameLabel.Text = prefixTextBox.Text + "###" + suffixTextBox.Text + ".ext";
        }

        private void suffixTextBox_TextChanged(object sender, EventArgs e){
            outExampleNameLabel.Text = prefixTextBox.Text + "###" + suffixTextBox.Text + ".ext";
        }

        private void anigifPanelTrasparentPictureBox_Click(object sender, EventArgs e){
            colorDialog.Color = anigifPanelTrasparentPictureBox.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                anigifPanelTrasparentPictureBox.BackColor = colorDialog.Color;
        }

        private void anigifPanelNoTrasparentCheckBox_CheckedChanged(object sender, EventArgs e){
            anigifPanelTrasparentPictureBox.Enabled = !anigifPanelNoTrasparentCheckBox.Checked;
        }

        private void anigifPanelFrameNumberTextBox_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar != 8)
                if (!char.IsNumber(e.KeyChar))
                    e.Handled = true;
        }
    }
}