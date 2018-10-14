using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Smoothing
    {
        public static Bitmap median(Bitmap img)
        {
            BitmapData imgData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr scan = imgData.Scan0;

            unsafe
            {
                byte* img_p = (byte*)scan.ToPointer();
                img_p += imgData.Stride;

                byte[] r = new byte[9];
                byte[] g = new byte[9];
                byte[] b = new byte[9];

                for (int y = 1; y < (img.Height - 1); y++)
                {
                    for (int x = 1; x < (img.Width - 1); x++)
                    {
                        int point = x * 3;

                        //儲存九宮格內的值
                        int[] matrix = new int[9] { -3, -2, -1, 0, 1, 2, 3, 4, 5 };
                        img_p -= imgData.Stride;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                b[i * 3 + j] = img_p[point + matrix[j * 3]];
                                g[i * 3 + j] = img_p[point + matrix[j * 3 + 1]];
                                r[i * 3 + j] = img_p[point + matrix[j * 3 + 2]];
                            }
                            img_p += imgData.Stride;
                        }
                        img_p -= imgData.Stride * 2;

                        Array.Sort(r);
                        Array.Sort(g);
                        Array.Sort(b);

                        byte red = r[4];
                        byte green = g[4];
                        byte blue = b[4];

                        img_p[point] = blue;
                        img_p[point + 1] = green;
                        img_p[point + 2] = red;
                    }
                    img_p += imgData.Stride;
                }
            }
            img.UnlockBits(imgData);
            return img;
        }

        public static Bitmap mean(Bitmap img)
        {
            BitmapData imgData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr scan = imgData.Scan0;

            unsafe
            {
                byte* img_p = (byte*)scan.ToPointer();
                img_p += imgData.Stride;

                for (int y = 1; y < (img.Height - 1); y++)
                {
                    for (int x = 1; x < (img.Width - 1); x++)
                    {
                        int point = x * 3;

                        int red = 0;
                        int green = 0;
                        int blue = 0;

                        //儲存九宮格內的值
                        int[] matrix = new int[9] { -3, -2, -1, 0, 1, 2, 3, 4, 5 };
                        img_p -= imgData.Stride;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                blue += img_p[point + matrix[j * 3]];
                                green += img_p[point + matrix[j * 3 + 1]];
                                red += img_p[point + matrix[j * 3 + 2]];
                            }
                            img_p += imgData.Stride;
                        }
                        img_p -= imgData.Stride * 2;

                        img_p[point] = (byte)(blue / 9);
                        img_p[point + 1] = (byte)(green / 9);
                        img_p[point + 2] = (byte)(red / 9);
                    }
                    img_p += imgData.Stride;
                }
            }
            img.UnlockBits(imgData);
            return img;
        }
    }
}