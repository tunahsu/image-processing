using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Negative
    {
        public static Bitmap negative(Bitmap img)
        {
            BitmapData imgData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr scan = imgData.Scan0;

            unsafe
            {
                byte* img_p = (byte*)scan.ToPointer();

                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        int point = x * 3;

                        img_p[point] = (byte)(255 - img_p[point]);
                        img_p[point + 1] = (byte)(255 - img_p[point + 1]);
                        img_p[point + 2] = (byte)(255 - img_p[point + 2]);
                    }
                    img_p += imgData.Stride;
                }
            }
            img.UnlockBits(imgData);
            return img;
        }
    }
}
