using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Editor {
	public class Resize {
		private int	newWidth = 0;
		private int newHeight = 0;

		public int NewWidth {
			get { return newWidth; }
			set { newWidth = Math.Max(1, Math.Min(5000, value)); }
		}

        public int NewHeight {
			get { return newHeight; }
			set { newHeight = Math.Max(1, Math.Min(5000, value)); }
		}

		public Resize() { }

		public Resize(int newWidth, int newHeight) {
			this.newWidth = newWidth;
			this.newHeight = newHeight;
		}

		public Bitmap Apply(Bitmap srcImg) {
			int width = srcImg.Width;
			int height = srcImg.Height;

            if ((newWidth == width) && (newHeight == height))
                return (Bitmap)srcImg.Clone();

            PixelFormat fmt = PixelFormat.Format24bppRgb;

			BitmapData srcData = srcImg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, fmt);

			Bitmap dstImg = new Bitmap(newWidth, newHeight, fmt);
			BitmapData dstData = dstImg.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.ReadWrite, fmt);

			int pixelSize = 3;
			int srcStride = srcData.Stride;
			int dstOffset = dstData.Stride - pixelSize * newWidth;
			float xFactor = (float) width / newWidth;
			float yFactor = (float) height / newHeight;

			unsafe {
				byte * src = (byte *) srcData.Scan0.ToPointer();
				byte * dst = (byte *) dstData.Scan0.ToPointer();

				float ox, oy, dx1, dy1, dx2, dy2;
				int	ox1, oy1, ox2, oy2;
				int	ymax = height - 1;
				int	xmax = width - 1;
				byte v1, v2;
				byte * tp1, tp2;

				byte *	p1, p2, p3, p4;

				for (int y = 0; y < newHeight; y++) {
					oy	= (float) y * yFactor;
					oy1	= (int) oy;
					oy2	= (oy1 == ymax) ? oy1 : oy1 + 1;
					dy1	= oy - (float) oy1;
					dy2 = 1.0f - dy1;

                    tp1 = src + oy1 * srcStride;
					tp2 = src + oy2 * srcStride;

					for (int x = 0; x < newWidth; x++) {
						ox	= (float) x * xFactor;
						ox1	= (int) ox;
						ox2	= (ox1 == xmax) ? ox1 : ox1 + 1;
						dx1	= ox - (float) ox1;
						dx2	= 1.0f - dx1;

						p1 = tp1 + ox1 * pixelSize;
						p2 = tp1 + ox2 * pixelSize;
						p3 = tp2 + ox1 * pixelSize;
						p4 = tp2 + ox2 * pixelSize;

						for (int i = 0; i < pixelSize; i++, dst++, p1++, p2++, p3++, p4++) {
							v1 = (byte)(dx2 * (*p1) + dx1 * (*p2));
							v2 = (byte)(dx2 * (*p3) + dx1 * (*p4));
							*dst = (byte)(dy2 * v1 + dy1 * v2);
						}
					}
					dst += dstOffset;
				}
			}

			dstImg.UnlockBits(dstData);
			srcImg.UnlockBits(srcData);

			return dstImg;
		}
	}
}
