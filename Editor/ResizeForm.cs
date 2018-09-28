using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Editor {
    public partial class ResizeForm : Form {
		private Size originalSize;
		private Resize filter = new Resize();
		private bool updating = false;

		public Size OriginalSize {
			get { return originalSize; }
			set { originalSize = value; }
		}

        public Resize Filter {
			get { return filter; }
		}

		public ResizeForm() {
			InitializeComponent();
		}

		private void ResizeForm_Load(object sender, EventArgs e) {
			factorBox.Text = "2";

			widthBox.Text = (originalSize.Width * 2).ToString();
			heightBox.Text = (originalSize.Height * 2).ToString();
		}

		private void factorBox_TextChanged(object sender, EventArgs e) {
            try {
                float factor = float.Parse(factorBox.Text);

                updating = true;
                widthBox.Text = Math.Max(1, Math.Min(5000, (int)(factor * originalSize.Width))).ToString();
                heightBox.Text = Math.Max(1, Math.Min(5000, (int)(factor * originalSize.Height))).ToString();
                updating = false;
            }
            catch (FormatException) { }
        }

		private void widthBox_TextChanged(object sender, EventArgs e) {
			if ((!updating) && (ratioCheck.Checked)) {
                try {
                    int width = int.Parse(widthBox.Text);

                    updating = true;
                    heightBox.Text = Math.Max(1, Math.Min(5000, (int)(width * originalSize.Height / originalSize.Width))).ToString();
                    updating = false;
                }
                catch (FormatException) { }
            }
		}

		private void heightBox_TextChanged(object sender, EventArgs e) {
			if ((!updating) && (ratioCheck.Checked)) {
                try {
                    int height = int.Parse(heightBox.Text);

                    updating = true;
                    widthBox.Text = Math.Max(1, Math.Min(5000, (int)(height * originalSize.Width / originalSize.Height))).ToString();
                    updating = false;
                }
                catch (FormatException) { }
			}
		}

		private void okButton_Click(object sender, EventArgs e) {
            try {
                filter.NewWidth = Math.Max(1, Math.Min(5000, int.Parse(widthBox.Text)));
                filter.NewHeight = Math.Max(1, Math.Min(5000, int.Parse(heightBox.Text)));

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException fe) {
                MessageBox.Show("You must specify a valid number.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

        private void factorBox_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar != 8) && (e.KeyChar != 44))
                if (!char.IsNumber(e.KeyChar))
                    e.Handled = true;
        }

        private void widthBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != 8)
                if (!char.IsNumber(e.KeyChar))
                    e.Handled = true;
        }

        private void heightBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != 8)
                if (!char.IsNumber(e.KeyChar))
                    e.Handled = true;
        }
    }
}