using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    public class Grayscale
    {
        public static Bitmap Transform(Bitmap img, string str1)
        {
            int[,,] rgb = ImageRW.GetRGB(img);
            int height = rgb.GetLength(0);
            int width = rgb.GetLength(1);

            switch(str1)
            {
                case "Mean-Value":
                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            int gray = (rgb[j, i, 0] + rgb[j, i, 1] + rgb[j, i, 2]) / 3;
                            rgb[j, i, 0] = gray;
                            rgb[j, i, 1] = gray;
                            rgb[j, i, 2] = gray;
                        }
                    }
                    break;

                case "Mean-Weight":
                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            float gray = (float)(0.299 * rgb[j, i, 0] + 0.587 * rgb[j, i, 1] + 0.114 * rgb[j, i, 2]);
                            rgb[j, i, 0] = (int)gray;
                            rgb[j, i, 1] = (int)gray;
                            rgb[j, i, 2] = (int)gray;
                        }
                    }
                    break;

                case "Maximum":
                    for (int j = 0; j < height; j++)
                    {
                        for (int i = 0; i < width; i++)
                        {
                            int gray = Math.Max(rgb[j, i, 0], rgb[j, i, 1]);
                            gray = Math.Max(gray, rgb[j, i, 2]);
                            rgb[j, i, 0] = gray;
                            rgb[j, i, 1] = gray;
                            rgb[j, i, 2] = gray;
                        }
                    }
                    break;

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

                //case "Power-Law":
                //    for (int j = 0; j < height; j++)
                //    {
                //        for (int i = 0; i < width; i++)
                //        {
                //            double c = 255;
                //            double gamma = 1;
                //            if (str2 == "gamma=2.5")
                //            {
                //                gamma = 2.5;
                //            }
                //            else if (str2 == "gamma=0.4")
                //            {
                //                gamma = 0.4;
                //            }
                //            rgb[j, i, 0] = (int)(c * Math.Pow(((double)rgb[j, i, 0]) / 255, gamma));
                //            rgb[j, i, 1] = (int)(c * Math.Pow(((double)rgb[j, i, 1]) / 255, gamma));
                //            rgb[j, i, 2] = (int)(c * Math.Pow(((double)rgb[j, i, 2]) / 255, gamma));
                //        }
                //    }
                //    break;
            }
            img = ImageRW.SetRGB(rgb);
            return img;
        } 
    }
}

