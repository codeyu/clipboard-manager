using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Editor {
	public class TextOverlay {
        private string text;
        private Point pointedText;
        private Font textFont;
        private Color textColor;

        public Font Font {
            set { textFont = value; }
        }

        public Color Color {
            set { textColor = value; }
        }

        public TextOverlay(string text, Point pointedText) {
			this.text = text;
            this.pointedText = pointedText;
		}

		public Bitmap Apply(Bitmap srcImg) {
            Bitmap dstImg = (Bitmap)srcImg.Clone();
            Graphics g = Graphics.FromImage(dstImg);

            int delta = g.MeasureString(text, textFont).ToSize().Height / 2;
            Point pointDraw = new Point(pointedText.X, pointedText.Y - delta);

            using (SolidBrush brush = new SolidBrush(textColor))
                g.DrawString(text, textFont, brush, pointDraw);

            g.Dispose();

            return dstImg;
		}
	}
}
