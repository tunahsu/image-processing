using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Sharpen
    {
        public static Bitmap sharpen(Bitmap img, Bitmap origin)
        {
            BitmapData imgData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr imgScan = imgData.Scan0;

            BitmapData originData = origin.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr originScan = originData.Scan0;

            unsafe
            {
                byte* img_p = (byte*)imgScan.ToPointer();
                byte* origin_p = (byte*)originScan.ToPointer();

                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        int point = x * 3;

                        int blue = img_p[point] + origin_p[point];
                        int green = img_p[point + 1] + origin_p[point + 1];
                        int red = img_p[point + 2] + origin_p[point + 2];

                        img_p[point] = (blue > 255) ? (byte)255 : (byte)blue;
                        img_p[point + 1] = (green > 255) ? (byte)255 : (byte)green;
                        img_p[point + 2] = (red > 255) ? (byte)255 : (byte)red;
                    }
                    img_p += imgData.Stride;
                    origin_p += originData.Stride;
                }
            }
            img.UnlockBits(imgData);
            origin.UnlockBits(originData);
            return img;
        }
    }
}
