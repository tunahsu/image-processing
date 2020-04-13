using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    class Enhancement
    {
        public static Bitmap Transform(Bitmap img, string str1)
        {
            int[,,] rgb = ImageRW.GetRGB(img);
            int height = rgb.GetLength(0);
            int width = rgb.GetLength(1);

            switch (str1)
            {
                case "Negative":
                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            rgb[j, i, 0] = 255 - rgb[j, i, 0];
                            rgb[j, i, 1] = 255 - rgb[j, i, 1];
                            rgb[j, i, 2] = 255 - rgb[j, i, 2];
                        }
                    }
                    break;

                case "Log-Transform":
                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            double c = 100;
                            rgb[j, i, 0] = (int)(c * Math.Log(1 + rgb[j, i, 0], 10));
                            rgb[j, i, 1] = (int)(c * Math.Log(1 + rgb[j, i, 1], 10));
                            rgb[j, i, 2] = (int)(c * Math.Log(1 + rgb[j, i, 2], 10));
                        }
                    }
                    break;
            }
            img = ImageRW.SetRGB(rgb);
            return img;
        }
    }
}
