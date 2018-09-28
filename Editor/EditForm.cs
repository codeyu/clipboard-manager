using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;

namespace Editor {
    public partial class EditForm : Form {
        Bitmap backup = null;
        Bitmap image = null;
        Bitmap originalImage = null;

        Color textColor;
        Font textFont;

        int width, height;

        float zoom = 1;

        bool cropping = false;
        bool dragging = false;
        bool texting = false;
        bool modified = false;
        
        Point start, end, startW, endW;

        Rectangle imageRect = new Rectangle();

        public delegate void SaveEventHandler(object sender, SaveEventArgs e);
        public event SaveEventHandler ImageSaved;

        public EditForm(Bitmap image) {
            InitializeComponent();

            this.image = (Bitmap)image.Clone();
            originalImage = (Bitmap)image.Clone();

            textColor = ForeColor;
            textFont = Font;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
            AutoScroll = true;

            Crop cropImage = new Crop(new Rectangle(new Point(0, 0), image.Size));
            image = cropImage.Apply(image);

            UpdateNewImage();

            Text = "Image Editor";
            modified = false;
        }

        private void UpdateNewImage() {
            UpdateSize();

            Invalidate();

            Text = "Image Editor *";
            modified = true;
        }

        private void UpdateSize() {
            width = image.Width;
            height = image.Height;

            AutoScrollMinSize = new Size((int)(width * zoom), (int)(height * zoom));
        }

        protected override void OnPaint(PaintEventArgs e) {
            if (image != null) {
                Graphics g = e.Graphics;
                Rectangle rc = ClientRectangle;

                using (Pen pen = new Pen(Color.Black)) {
                    int width = (int)(this.width * zoom);
                    int height = (int)(this.height * zoom);

                    int x, y;
                    if (rc.Width < width)
                        x = AutoScrollPosition.X;
                    else
                        x = (rc.Width - width) / 2;
                    
                    if (rc.Height < height)
                        y = AutoScrollPosition.Y;
                    else
                        y = (rc.Height - height) / 2;

                    g.DrawRectangle(pen, x - 1, y - 1, width + 1, height + 1);
                    g.InterpolationMode = InterpolationMode.NearestNeighbor;
                    g.DrawImage(image, x, y, width, height);
                    
                    imageRect = new Rectangle(x, y, width, height);
                }
            }
        }

        private void imageItem_Popup(object sender, EventArgs e) {
            cropImageItem.Checked = cropping;
        }

        private void backImageItem_Click(object sender, EventArgs e) {
            if (backup != null) {
                image.Dispose();

                image = backup;
                backup = null;

                UpdateNewImage();
            }
        }

        private void UpdateZoom() {
            AutoScrollMinSize = new Size((int)(width * zoom), (int)(height * zoom));
            
            Invalidate();
        }

        private void zoomItem_Click(object sender, EventArgs e) {
            String t = ((MenuItem)sender).Text;

            zoom = float.Parse(t.Remove(t.Length - 1, 1)) / 100;

            UpdateZoom();
        }

        private void zoomInImageItem_Click(object sender, EventArgs e) {
            float z = zoom * 1.5f;

            if (z <= 10) {
                zoom = z;
                UpdateZoom();
            }
        }


        private void zoomOutImageItem_Click(object sender, EventArgs e) {
            float z = zoom / 1.5f;

            if (z >= 0.05) {
                zoom = z;
                UpdateZoom();
            }
        }

        private void zoomFitImageItem_Click(object sender, EventArgs e) {
            Rectangle rc = ClientRectangle;

            zoom = Math.Min((float)rc.Width / (width + 2), (float)rc.Height / (height + 2));

            UpdateZoom();
        }

        private void flipImageItem_Click(object sender, EventArgs e) {
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            Invalidate();
        }

        private void mirrorItem_Click(object sender, EventArgs e) {
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            Invalidate();
        }

        private void rotateImageItem_Click(object sender, EventArgs e) {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            UpdateNewImage();
        }

        private void resizeFiltersItem_Click(object sender, EventArgs e) {
            texting = false;
            cropping = false;
            
            ResizeForm form = new ResizeForm();

            form.OriginalSize = new Size(width, height);

            if (form.ShowDialog() == DialogResult.OK){
                Cursor = Cursors.WaitCursor;

                Bitmap newImage = form.Filter.Apply(image);

                if (backup != null)
                    backup.Dispose();

                backup = image;
                image = newImage;

                UpdateNewImage();
            }

            Cursor = Cursors.Default;
        }

        private void GetImageAndScreenPoints(Point point, out Point imgPoint, out Point screenPoint) {
            Rectangle rc = this.ClientRectangle;
            int width = (int)(this.width * zoom);
            int height = (int)(this.height * zoom);
            int x = (rc.Width < width) ? this.AutoScrollPosition.X : (rc.Width - width) / 2;
            int y = (rc.Height < height) ? this.AutoScrollPosition.Y : (rc.Height - height) / 2;

            int ix = Math.Min(Math.Max(x, point.X), x + width - 1);
            int iy = Math.Min(Math.Max(y, point.Y), y + height - 1);

            ix = (int)((ix - x) / zoom);
            iy = (int)((iy - y) / zoom);

            imgPoint = new Point(ix, iy);
            screenPoint = this.PointToScreen(new Point((int)(ix * zoom + x), (int)(iy * zoom + y)));
        }

        private void NormalizePoints(ref Point pt1, ref Point pt2) {
            Point t1 = pt1;
            Point t2 = pt2;

            pt1.X = Math.Min(t1.X, t2.X);
            pt1.Y = Math.Min(t1.Y, t2.Y);
            pt2.X = Math.Max(t1.X, t2.X);
            pt2.Y = Math.Max(t1.Y, t2.Y);
        }

        private void DrawSelectionFrame(Graphics g) {
            Point sp = startW;
            Point ep = endW;

            NormalizePoints(ref sp, ref ep);

            ControlPaint.DrawReversibleFrame(new Rectangle(sp.X, sp.Y, ep.X - sp.X + 1, ep.Y - sp.Y + 1), Color.White, FrameStyle.Dashed);
        }

        private void cropImageItem_Click(object sender, EventArgs e) {
            if (!cropping) {
                cropping = true;
                Cursor = Cursors.Cross;
            }
            else {
                cropping = false;
                Cursor = Cursors.Default;
            }
        }

        private void ImageDoc_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                texting = false;

                if (!dragging) 
                    cropping = false;

                Cursor = Cursors.Default;
            }
            else if (e.Button == MouseButtons.Left) {
                if (cropping) {
                    dragging = true;
                    Capture = true;

                    GetImageAndScreenPoints(new Point(e.X, e.Y), out start, out startW);

                    end = start;
                    endW = startW;

                    Graphics g = CreateGraphics();
                    DrawSelectionFrame(g);
                    g.Dispose();
                }
            }
        }

        private void ImageDoc_MouseUp(object sender, MouseEventArgs e) {
            if (dragging) {
                dragging = cropping = false;
                Capture = false;
                
                Cursor = Cursors.Default;

                Graphics g = this.CreateGraphics();
                DrawSelectionFrame(g);
                g.Dispose();

                NormalizePoints(ref start, ref end);

                Cursor = Cursors.WaitCursor;

                Crop cropImage = new Crop(new Rectangle(start.X, start.Y, end.X - start.X + 1, end.Y - start.Y + 1));
                Bitmap newImage = cropImage.Apply(image);

                if (backup != null)
                    backup.Dispose();

                backup = image;
                image = newImage;

                UpdateNewImage();

                Cursor = Cursors.Default;
            }
            else if (texting) {
                if (imageRect.Contains(e.Location)) {
                    TextBox textOverlay = new TextBox();

                    textOverlay.Location = e.Location;
                    textOverlay.Multiline = true;
                    textOverlay.BorderStyle = BorderStyle.None;
                    textOverlay.Height = 13;

                    textOverlay.KeyPress += new KeyPressEventHandler(textOverlay_KeyPress);

                    Controls.Add(textOverlay);
                    textOverlay.Focus();

                    Cursor = Cursors.Default;

                    texting = false;
                }
            }
        }

        private void ImageDoc_MouseMove(object sender, MouseEventArgs e) {
            if (dragging) {
                Graphics g = CreateGraphics();

                DrawSelectionFrame(g);
                GetImageAndScreenPoints(new Point(e.X, e.Y), out end, out endW);
                DrawSelectionFrame(g);

                g.Dispose();
            }
        }

        void textOverlay_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\n') {
                ((TextBox)sender).Size = new Size(((TextBox)sender).Width, ((TextBox)sender).Height + 13);
            }
            else if (e.KeyChar == (char)Keys.Enter) {
                Point ptText = new Point(((TextBox)sender).Location.X, ((TextBox)sender).Location.Y + 6);
                Point pointedText = new Point();
                Point screenPointedText = new Point();

                GetImageAndScreenPoints(ptText, out pointedText, out screenPointedText);

                Cursor = Cursors.WaitCursor;

                TextOverlay textOverlay = new TextOverlay(((TextBox)sender).Text, pointedText);
                textOverlay.Font = textFont;
                textOverlay.Color = textColor;
                
                Bitmap newImage = textOverlay.Apply(image);

                ((TextBox)sender).Dispose();

                if (backup != null)
                    backup.Dispose();

                backup = image;
                image = newImage;

                UpdateNewImage();

                Cursor = Cursors.Default;
            }
            else if (e.KeyChar == (char)Keys.Escape) {
                ((TextBox)sender).Dispose();
            }
        }

        private void fontMenuItem_Click(object sender, EventArgs e) {
            fontDialog.Font = textFont;
            
            if (fontDialog.ShowDialog() == DialogResult.OK)
                textFont = fontDialog.Font;
        }

        private void colorMenuItem_Click(object sender, EventArgs e) {
            colorDialog.Color = textColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                textColor = colorDialog.Color;
        }

        private void insertTextMenuItem_Click(object sender, EventArgs e) {
            if (!texting) {
                Cursor = Cursors.IBeam;
                texting = true;
            }
            else if (texting) {
                Cursor = Cursors.Default;
                texting = false;
            }
        }

        private void textMenuItem_Popup(object sender, EventArgs e) {
            insertTextMenuItem.Checked = texting;
        }

        private void closeMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        protected override void OnClosing(CancelEventArgs e) {
            if (modified) {
                DialogResult dlRes = MessageBox.Show("The image has been changed. Save it before closing?", "Image Editor",
                                                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dlRes == DialogResult.Yes)
                    saveMenuItem_Click(null, new EventArgs());
                else if (dlRes == DialogResult.Cancel)
                    e.Cancel = true;
            }

            base.OnClosing(e);
        }

        private void reloadMenuItem_Click(object sender, EventArgs e) {
            if (image != null)
                image.Dispose();

            if (backup != null)
                backup.Dispose();

            backup = null;

            image = originalImage;

            Crop cropImage = new Crop(new Rectangle(new Point(0, 0), image.Size));
            image = cropImage.Apply(image);

            UpdateNewImage();

            Text = "Image Editor";
            modified = false;
        }

        private void saveMenuItem_Click(object sender, EventArgs e) {
            if (image != null) {
                ImageSaved(this, new SaveEventArgs(image));
                Text = "Image Editor";
                modified = false;
            }
        }

        private void EditForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }

        private void fileMenuItem_Popup(object sender, EventArgs e) {
            backImageItem.Enabled = (backup != null);
        }
    }

    public class SaveEventArgs : EventArgs {
        private Bitmap image;

        public Bitmap Image {
            get { return image; }
        }

        public SaveEventArgs(Bitmap image) {
            this.image = image;
        }
    }
}