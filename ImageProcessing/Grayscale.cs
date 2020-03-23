using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    public class Grayscale
    {
        public static Bitmap mean(Bitmap img)
        {
            int[,,] rgb = ImageRW.getRGB(img);
            int height = rgb.GetLength(0);
            int width = rgb.GetLength(1);

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    int avarge = (rgb[j, i, 0] + rgb[j, i, 1] + rgb[j, i, 2]) / 3;
                    rgb[j, i, 0] = avarge;
                    rgb[j, i, 1] = avarge;
                    rgb[j, i, 2] = avarge;
                }
            }
            img = ImageRW.setRGB(rgb);
            return img;
        }

        public static Bitmap weight(Bitmap img)
        {
            int[,,] rgb = ImageRW.getRGB(img);
            int height = rgb.GetLength(0);
            int width = rgb.GetLength(1);

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    float weighted = (float)(0.299 * rgb[j, i, 0] + 0.587 * rgb[j, i, 1] + 0.114 * rgb[j, i, 2]);
                    rgb[j, i, 0] = (int)weighted;
                    rgb[j, i, 1] = (int)weighted;
                    rgb[j, i, 2] = (int)weighted;
                }
            }
            img = ImageRW.setRGB(rgb);
            return img;
        }

        public static Bitmap max(Bitmap img)
        {
            int[,,] rgb = ImageRW.getRGB(img);
            int height = rgb.GetLength(0);
            int width = rgb.GetLength(1);

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    int max = Math.Max(rgb[j, i, 0], rgb[j, i, 1]);
                    max = Math.Max(max, rgb[j, i, 2]);
                    rgb[j, i, 0] = max;
                    rgb[j, i, 1] = max;
                    rgb[j, i, 2] = max;
                }
            }
            img = ImageRW.setRGB(rgb);
            return img;
        }
    }
}

