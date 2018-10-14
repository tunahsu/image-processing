using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Retro
    {
        public static Bitmap retro(Bitmap img)
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

                        double b = img_p[point];
                        double g = img_p[point + 1];
                        double r = img_p[point + 2];

                        double red = (r * 0.393 + 0.769 * g + 0.189 * b);
                        double green = (r * 0.343 + 0.686 * g + 0.168 * b);
                        double blue = (r * 0.272 + 0.543 * g + 0.131 * b);

                        if (red > 255) { red = 255; }
                        if (green > 255) { green = 255; }
                        if (blue > 255) { blue = 255; }

                        img_p[point] = (byte)((int)(blue));
                        img_p[point + 1] = (byte)((int)(green));
                        img_p[point + 2] = (byte)((int)(red));
                    }
                    img_p += imgData.Stride;
                }
            }
            img.UnlockBits(imgData);
            return img;
        }
    }
}
