using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;

namespace IPLab {
    public class ImageDoc : Form {
		Bitmap backup = null;
		Bitmap image = null;
		
        string fileName = null;
		
        int width;
		int height;
		
        float zoom = 1;

		bool cropping = false;
		bool dragging = false;
		Point start, end, startW, endW;

		public Bitmap Image {
			get { return image; }
		}

        public int ImageWidth {
			get { return width; }
		}

        public int ImageHeight {
			get { return height; }
		}

        public float Zoom {
			get { return zoom; }
		}

        public string FileName {
			get { return fileName; }
		}

		public ImageDoc(string fileName) {
			image = (Bitmap) Bitmap.FromFile(fileName);

			ImageUtility.FormatImage(ref image);

			this.fileName = fileName;

            Init();
		}

        public ImageDoc(Bitmap image){
			this.image = image;
			ImageUtility.FormatImage(ref this.image);

			Init();
		}

		private void Init() {
            InitializeComponent();

			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);

			this.AutoScroll = true;

			UpdateSize();
		}

		private void UpdateNewImage() {
			UpdateSize();

            Invalidate();
		}

		public void Reload() {
			if (fileName != null) {
				Bitmap newImage = (Bitmap) Bitmap.FromFile(fileName);

				image.Dispose();
				image = newImage;

				ImageUtility.FormatImage(ref image);

                UpdateNewImage();
			}
		}

		public void Center() {
			Rectangle	rc = ClientRectangle;
			Point		p = this.AutoScrollPosition;
			int			width = (int) (this.width * zoom);
			int			height = (int) (this.height * zoom);

			if (rc.Width < width)
				p.X = (width - rc.Width) >> 1;
			if (rc.Height < height)
				p.Y = (height - rc.Height) >> 1;

			this.AutoScrollPosition = p;
		}

		private void UpdateSize() {
			width = image.Width;
			height = image.Height;

			this.AutoScrollMinSize = new Size((int)(width * zoom), (int)(height * zoom));
		}

		protected override void OnPaint(PaintEventArgs e) {
			if (image != null) {
				Graphics	g = e.Graphics;
				Rectangle	rc = ClientRectangle;
				Pen			pen = new Pen(Color.FromArgb(0, 0, 0));

				int			width = (int) (this.width * zoom);
				int			height = (int) (this.height * zoom);
				int			x = (rc.Width < width) ? this.AutoScrollPosition.X : (rc.Width - width) / 2;
				int			y = (rc.Height < height) ? this.AutoScrollPosition.Y : (rc.Height - height) / 2;

				g.DrawRectangle(pen, x - 1, y - 1, width + 1, height + 1);

				g.InterpolationMode = InterpolationMode.NearestNeighbor;

				g.DrawImage(image, x, y, width, height);

				pen.Dispose();
			}
		}

		protected override void OnClick(EventArgs e) {
			Focus();
		}

		private void ApplyFilter(IFilter filter) {
			this.Cursor = Cursors.WaitCursor;

			Bitmap newImage = filter.Apply(image);

			if (backup != null)
				backup.Dispose();

			backup = image;
			image = newImage;

			UpdateNewImage();

            this.Cursor = Cursors.Default;
		}

		private void imageItem_Popup(object sender, EventArgs e) {
			this.backImageItem.Enabled = (backup != null);
			this.cropImageItem.Checked = cropping;
		}

		private void backImageItem_Click(object sender, EventArgs e){
			if (backup != null) {
				image.Dispose();

                image = backup;
				backup = null;

				UpdateNewImage();
			}
		}

		private void UpdateZoom() {
			this.AutoScrollMinSize = new Size((int)(width * zoom), (int)(height * zoom));
			this.Invalidate();
		}

		private void zoomItem_Click(object sender, EventArgs e) {
			String	t = ((MenuItem) sender).Text;

            int	i = int.Parse(t.Remove(t.Length - 1, 1));

            zoom = (float) i / 100;

			UpdateZoom();
		}

		private void zoomInImageItem_Click(object sender, EventArgs e){
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
            ResizeForm form = new ResizeForm();

            form.OriginalSize = new Size(width, height);

            if (form.ShowDialog() == DialogResult.OK)
                ApplyFilter(form.Filter);
        }

		private void GetImageAndScreenPoints(Point point, out Point imgPoint, out Point screenPoint) {
			Rectangle	rc = this.ClientRectangle;
			int			width = (int) (this.width * zoom);
			int			height = (int) (this.height * zoom);
			int			x = (rc.Width < width) ? this.AutoScrollPosition.X : (rc.Width - width) / 2;
			int			y = (rc.Height < height) ? this.AutoScrollPosition.Y : (rc.Height - height) / 2;

			int			ix = Math.Min(Math.Max(x, point.X), x + width - 1);
			int			iy = Math.Min(Math.Max(y, point.Y), y + height - 1);

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
			Point	sp = startW;
			Point	ep = endW;

			NormalizePoints(ref sp, ref ep);

            ControlPaint.DrawReversibleFrame(new Rectangle(sp.X, sp.Y, ep.X - sp.X + 1, ep.Y - sp.Y + 1), Color.White, FrameStyle.Dashed);
		}

		private void cropImageItem_Click(object sender, EventArgs e) {
            if (!cropping) {
                cropping = true;
                this.Cursor = Cursors.Cross;
            }
            else {
                cropping = false;
                this.Cursor = Cursors.Default;
            }
        }

		private void ImageDoc_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				if (!dragging) {
					cropping = false;
					this.Cursor = Cursors.Default;
				}
			}
			else if (e.Button == MouseButtons.Left) {
				if (cropping) {
					dragging = true;
					this.Capture = true;

					GetImageAndScreenPoints(new Point(e.X, e.Y), out start, out startW);

					end = start;
					endW = startW;
					
					Graphics g = this.CreateGraphics();
					DrawSelectionFrame(g);
					g.Dispose();
				}
			}
		}

		private void ImageDoc_MouseUp(object sender, MouseEventArgs e) {
			if (dragging) {
				dragging = cropping = false;
				this.Capture = false;
				this.Cursor = Cursors.Default;

				Graphics g = this.CreateGraphics();
				DrawSelectionFrame(g);
				g.Dispose();

				NormalizePoints(ref start, ref end);

				ApplyFilter(new Crop(new Rectangle(start.X, start.Y, end.X - start.X + 1, end.Y - start.Y + 1)));
			}
		}

		private void ImageDoc_MouseMove(object sender, MouseEventArgs e) {
			if (dragging) {

				Graphics g = this.CreateGraphics();

				DrawSelectionFrame(g);

				GetImageAndScreenPoints(new Point(e.X, e.Y), out end, out endW);

				DrawSelectionFrame(g);

				g.Dispose();
			}
		}
	}
}
