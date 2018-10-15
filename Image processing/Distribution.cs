using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Distribution
    {
        public static Bitmap[] drawDistribution(Bitmap img)
        {
            BitmapData imgData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr imgScan = imgData.Scan0;

            Bitmap[] rgb = new Bitmap[3] { new Bitmap(256, 200), new Bitmap(256, 200) , new Bitmap(256, 200) };

            int[,] rgb_count = new int[3, 258];
            int[] max = new int[3] { 0, 0, 0 };

            unsafe
            {
                byte* img_p = (byte*)imgScan.ToPointer();

                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        int point = x * 3;

                        rgb_count[0, img_p[point]]++;
                        if (rgb_count[0, img_p[point]] > max[0]) { max[0] = rgb_count[0, img_p[point]]; }
                        rgb_count[1, img_p[point + 1]]++;
                        if (rgb_count[1, img_p[point + 1]] > max[1]) { max[1] = rgb_count[1, img_p[point + 1]]; }
                        rgb_count[2, img_p[point + 2]]++;
                        if (rgb_count[2, img_p[point + 2]] > max[2]) { max[2] = rgb_count[2, img_p[point + 2]]; }
                    }
                    img_p += imgData.Stride;
                }

                int n0 = max[0] / 200;
                int n1 = max[1] / 200;
                int n2 = max[2] / 200;

                for (int i = 0; i < 256; i++)
                {
                    rgb_count[0, i] = (rgb_count[0, i] / n0 > 199) ? 199 : rgb_count[0, i] / n0;
                    rgb_count[1, i] = (rgb_count[1, i] / n1 > 199) ? 199 : rgb_count[1, i] / n1;
                    rgb_count[2, i] = (rgb_count[2, i] / n2 > 199) ? 199 : rgb_count[2, i] / n2;
                }

                for(int x = 0; x < 256; x++)
                {
                    for(int y = 199; y >= 0; y--)
                    {
                        if(rgb_count[0, x] != 0)
                        {
                            rgb[0].SetPixel(x, y, Color.Blue);
                            rgb_count[0, x]--;
                        }                     
                    }
                    for (int y = 199; y >= 0; y--)
                    {
                        if (rgb_count[1, x] != 0)
                        {
                            rgb[1].SetPixel(x, y, Color.Green);
                            rgb_count[1, x]--;
                        }
                    }
                    for (int y = 199; y >= 0; y--)
                    {
                        if (rgb_count[2, x] != 0)
                        {
                            rgb[2].SetPixel(x, y, Color.Red);
                            rgb_count[2, x]--;
                        }
                    }
                }
            }
            img.UnlockBits(imgData);
            return rgb;
        }
    }
}