using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace ImageProcessing
{
    class SpatialFiltering
    {
        public static Bitmap Transform(Bitmap img, string str1)
        {
            int[,,] rgb = ImageRW.GetRGB(img);
            int height = rgb.GetLength(0);
            int width = rgb.GetLength(1);

            int[,,] rgb_big = new int[height + 2, width + 2, 3];
            int[] values = new int[9];

            for (int j = 0; j < height + 2; j++)
            {
                for (int i = 0; i < width + 2; i++)
                {
                    if (j == 0 || i == 0 || j == height + 1 || i == width + 1)
                    {
                        rgb_big[j, i, 0] = 0;
                        rgb_big[j, i, 1] = 0;
                        rgb_big[j, i, 2] = 0;
                    }
                    else
                    {
                        rgb_big[j, i, 0] = rgb[j - 1, i - 1, 0];
                        rgb_big[j, i, 1] = rgb[j - 1, i - 1, 1];
                        rgb_big[j, i, 2] = rgb[j - 1, i - 1, 2];
                    }
                }
            }

            switch (str1)
            {
                case "Laplacian(4)":
                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                values[0] = rgb_big[j, i, k];
                                values[1] = rgb_big[j, i + 1, k];
                                values[2] = rgb_big[j, i + 2, k];
                                values[3] = rgb_big[j + 1, i, k];
                                values[4] = rgb_big[j + 1, i + 1, k];
                                values[5] = rgb_big[j + 1, i + 2, k];
                                values[6] = rgb_big[j + 2, i, k];
                                values[7] = rgb_big[j + 2, i + 1, k];
                                values[8] = rgb_big[j + 2, i + 2, k];

                                Array.Sort(values);
                                rgb[j, i, k] = values[4];
                            }
                        }
                    }
                    break;

                case "Mean":
                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                values[0] = rgb_big[j, i, k];
                                values[1] = rgb_big[j, i + 1, k];
                                values[2] = rgb_big[j, i + 2, k];
                                values[3] = rgb_big[j + 1, i, k];
                                values[4] = rgb_big[j + 1, i + 1, k];
                                values[5] = rgb_big[j + 1, i + 2, k];
                                values[6] = rgb_big[j + 2, i, k];
                                values[7] = rgb_big[j + 2, i + 1, k];
                                values[8] = rgb_big[j + 2, i + 2, k];

                                rgb[j, i, k] = values.Sum() / 9;
                            }
                        }
                    }
                    break;

                case "Min":
                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for(int k = 0; k < 3; k++)
                            {
                                values[0] = rgb_big[j, i, k];
                                values[1] = rgb_big[j, i + 1, k];
                                values[2] = rgb_big[j, i + 2, k];
                                values[3] = rgb_big[j + 1, i, k];
                                values[4] = rgb_big[j + 1, i + 1, k];
                                values[5] = rgb_big[j + 1, i + 2, k];
                                values[6] = rgb_big[j + 2, i, k];
                                values[7] = rgb_big[j + 2, i + 1, k];
                                values[8] = rgb_big[j + 2, i + 2, k];

                                rgb[j, i, k] = values.Min();
                            }
                        }
                    }
                    break;

                case "Max":
                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                values[0] = rgb_big[j, i, k];
                                values[1] = rgb_big[j, i + 1, k];
                                values[2] = rgb_big[j, i + 2, k];
                                values[3] = rgb_big[j + 1, i, k];
                                values[4] = rgb_big[j + 1, i + 1, k];
                                values[5] = rgb_big[j + 1, i + 2, k];
                                values[6] = rgb_big[j + 2, i, k];
                                values[7] = rgb_big[j + 2, i + 1, k];
                                values[8] = rgb_big[j + 2, i + 2, k];

                                rgb[j, i, k] = values.Max();
                            }
                        }
                    }
                    break;
            }
            img = ImageRW.SetRGB(rgb);
            return img;
        }
    }
}
