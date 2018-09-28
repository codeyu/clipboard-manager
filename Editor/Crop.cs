using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Editor {
	public class Crop {
        [DllImport("ntdll.dll")]
        static extern unsafe byte* memcpy(byte* dst, byte* src, int count);
        
        private Rectangle rect;

		public Crop(Rectangle rect) {
			this.rect = rect;
		}

		public Bitmap Apply(Bitmap srcImg) {
			int width = srcImg.Width;
			int height = srcImg.Height;

			int xmin = Math.Max(0, Math.Min(width - 1, rect.Left));
			int ymin = Math.Max(0, Math.Min(height - 1, rect.Top));
			int xmax = Math.Min(width - 1, xmin + rect.Width - 1 + ((rect.Left < 0) ? rect.Left : 0));
			int ymax = Math.Min(height - 1, ymin + rect.Height - 1 + ((rect.Top < 0) ? rect.Top : 0));

			int dstWidth = xmax - xmin + 1;
			int dstHeight = ymax - ymin + 1;

            PixelFormat fmt = PixelFormat.Format24bppRgb;

			BitmapData srcData = srcImg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, fmt);

			Bitmap dstImg = new Bitmap(dstWidth, dstHeight, fmt);
			BitmapData dstData = dstImg.LockBits(new Rectangle(0, 0, dstWidth, dstHeight), ImageLockMode.ReadWrite, fmt);

			int srcStride = srcData.Stride;
			int dstStride = dstData.Stride;
			int pixelSize = 3;
			int copySize = dstWidth * pixelSize;

			unsafe {
				byte * src = (byte *) srcData.Scan0.ToPointer() + ymin * srcStride + xmin * pixelSize;
				byte * dst = (byte *) dstData.Scan0.ToPointer();

				for (int y = ymin; y <= ymax; y++) {
					memcpy(dst, src, copySize);
					src += srcStride;
					dst += dstStride;
				}
			}

            dstImg.UnlockBits(dstData);
			srcImg.UnlockBits(srcData);

			return dstImg;
		}
	}
}
