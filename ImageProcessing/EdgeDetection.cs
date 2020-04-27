using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace ImageProcessing
{
    class EdgeDetection
    {
        public static Bitmap Transform(Bitmap img, string str1)
        {
            int[,,] rgb = ImageRW.GetRGB(img);
            int height = rgb.GetLength(0);
            int width = rgb.GetLength(1);

            int[,,] rgb_big = new int[height + 2, width + 2, 3];

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
                    int[,] mask = new int[3, 3]
                    { 
                        {0, -1, 0}, 
                        {-1, 4, -1}, 
                        {0, -1, 0}
                    };


                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                rgb[j, i, k] = rgb_big[j, i, k] * mask[0, 0] +
                                rgb_big[j, i + 1, k] * mask[0, 1] +
                                rgb_big[j, i + 2, k] * mask[0, 2] +
                                rgb_big[j + 1, i, k] * mask[1, 0] +
                                rgb_big[j + 1, i + 1, k] * mask[1, 1] +
                                rgb_big[j + 1, i + 2, k] * mask[1, 2] +
                                rgb_big[j + 2, i, k] * mask[2, 0] +
                                rgb_big[j + 2, i + 1, k] * mask[2, 1] +
                                rgb_big[j + 2, i + 2, k] * mask[2, 2];

                                if(rgb[j, i, k] > 255)
                                {
                                    rgb[j, i, k] = 255;
                                }
                                if(rgb[j, i, k] < 0)
                                {
                                    rgb[j, i, k] = 0;
                                }
                            }
                        }
                    }
                    break;

                case "Laplacian(4) Add":
                    mask = new int[3, 3]
                    {
                        {0, -1, 0},
                        {-1, 4, -1},
                        {0, -1, 0}
                    };


                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                rgb[j, i, k] = rgb[j, i, k] + 
                                (
                                rgb_big[j, i, k] * mask[0, 0] +
                                rgb_big[j, i + 1, k] * mask[0, 1] +
                                rgb_big[j, i + 2, k] * mask[0, 2] +
                                rgb_big[j + 1, i, k] * mask[1, 0] +
                                rgb_big[j + 1, i + 1, k] * mask[1, 1] +
                                rgb_big[j + 1, i + 2, k] * mask[1, 2] +
                                rgb_big[j + 2, i, k] * mask[2, 0] +
                                rgb_big[j + 2, i + 1, k] * mask[2, 1] +
                                rgb_big[j + 2, i + 2, k] * mask[2, 2]
                                );

                                if (rgb[j, i, k] > 255)
                                {
                                    rgb[j, i, k] = 255;
                                }
                                if (rgb[j, i, k] < 0)
                                {
                                    rgb[j, i, k] = 0;
                                }
                            }
                        }
                    }
                    break;

                case "Laplacian(4) Minus":
                    mask = new int[3, 3]
                    {
                        {0, -1, 0},
                        {-1, 4, -1},
                        {0, -1, 0}
                    };


                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                rgb[j, i, k] = rgb[j, i, k] -
                                (
                                rgb_big[j, i, k] * mask[0, 0] +
                                rgb_big[j, i + 1, k] * mask[0, 1] +
                                rgb_big[j, i + 2, k] * mask[0, 2] +
                                rgb_big[j + 1, i, k] * mask[1, 0] +
                                rgb_big[j + 1, i + 1, k] * mask[1, 1] +
                                rgb_big[j + 1, i + 2, k] * mask[1, 2] +
                                rgb_big[j + 2, i, k] * mask[2, 0] +
                                rgb_big[j + 2, i + 1, k] * mask[2, 1] +
                                rgb_big[j + 2, i + 2, k] * mask[2, 2]
                                );

                                if (rgb[j, i, k] > 255)
                                {
                                    rgb[j, i, k] = 255;
                                }
                                if (rgb[j, i, k] < 0)
                                {
                                    rgb[j, i, k] = 0;
                                }
                            }
                        }
                    }
                    break;

                case "Laplacian(9)":
                    mask = new int[3, 3]
                    {
                        {-1, -1, -1},
                        {-1, 9, -1},
                        {-1, -1, -1}
                    };


                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                rgb[j, i, k] = rgb_big[j, i, k] * mask[0, 0] +
                                rgb_big[j, i + 1, k] * mask[0, 1] +
                                rgb_big[j, i + 2, k] * mask[0, 2] +
                                rgb_big[j + 1, i, k] * mask[1, 0] +
                                rgb_big[j + 1, i + 1, k] * mask[1, 1] +
                                rgb_big[j + 1, i + 2, k] * mask[1, 2] +
                                rgb_big[j + 2, i, k] * mask[2, 0] +
                                rgb_big[j + 2, i + 1, k] * mask[2, 1] +
                                rgb_big[j + 2, i + 2, k] * mask[2, 2];

                                if (rgb[j, i, k] > 255)
                                {
                                    rgb[j, i, k] = 255;
                                }
                                if (rgb[j, i, k] < 0)
                                {
                                    rgb[j, i, k] = 0;
                                }
                            }
                        }
                    }
                    break;

                case "Laplacian(9) Add":
                    mask = new int[3, 3]
                    {
                        {-1, -1, -1},
                        {-1, 9, -1},
                        {-1, -1, -1}
                    };


                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                rgb[j, i, k] = rgb[j, i, k] +
                                (
                                rgb_big[j, i, k] * mask[0, 0] +
                                rgb_big[j, i + 1, k] * mask[0, 1] +
                                rgb_big[j, i + 2, k] * mask[0, 2] +
                                rgb_big[j + 1, i, k] * mask[1, 0] +
                                rgb_big[j + 1, i + 1, k] * mask[1, 1] +
                                rgb_big[j + 1, i + 2, k] * mask[1, 2] +
                                rgb_big[j + 2, i, k] * mask[2, 0] +
                                rgb_big[j + 2, i + 1, k] * mask[2, 1] +
                                rgb_big[j + 2, i + 2, k] * mask[2, 2]
                                );

                                if (rgb[j, i, k] > 255)
                                {
                                    rgb[j, i, k] = 255;
                                }
                                if (rgb[j, i, k] < 0)
                                {
                                    rgb[j, i, k] = 0;
                                }
                            }
                        }
                    }
                    break;

                case "Laplacian(9) Minus":
                    mask = new int[3, 3]
                    {
                        {-1, -1, -1},
                        {-1, 9, -1},
                        {-1, -1, -1}
                    };


                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                rgb[j, i, k] = rgb[j, i, k] -
                                (
                                rgb_big[j, i, k] * mask[0, 0] +
                                rgb_big[j, i + 1, k] * mask[0, 1] +
                                rgb_big[j, i + 2, k] * mask[0, 2] +
                                rgb_big[j + 1, i, k] * mask[1, 0] +
                                rgb_big[j + 1, i + 1, k] * mask[1, 1] +
                                rgb_big[j + 1, i + 2, k] * mask[1, 2] +
                                rgb_big[j + 2, i, k] * mask[2, 0] +
                                rgb_big[j + 2, i + 1, k] * mask[2, 1] +
                                rgb_big[j + 2, i + 2, k] * mask[2, 2]
                                );

                                if (rgb[j, i, k] > 255)
                                {
                                    rgb[j, i, k] = 255;
                                }
                                if (rgb[j, i, k] < 0)
                                {
                                    rgb[j, i, k] = 0;
                                }
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
