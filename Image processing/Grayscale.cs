using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Grayscale
    {
        public static Bitmap grayscale(Bitmap img)
        {
            BitmapData imgData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr scan =imgData.Scan0;

            unsafe
            {
                byte* img_p = (byte*)scan.ToPointer();

                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        int point = x * 3;

                        int blue = img_p[point];
                        int green = img_p[point + 1];
                        int red = img_p[point + 2];
                        byte gray = (byte)(red * 0.299 + green * 0.587 + blue * 0.114);

                        img_p[point] = gray;
                        img_p[point + 1] = gray;
                        img_p[point + 2] = gray;
                    }
                    img_p += imgData.Stride;
                }
            }
            img.UnlockBits(imgData);
            return img;
        }
    }
}
