using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_processing
{
    class Edge
    {
        public static Bitmap sobel(Bitmap sobel, Bitmap img)
        {
            BitmapData imgData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr imgScan = imgData.Scan0;
            BitmapData sobelData = sobel.LockBits(new Rectangle(0, 0, sobel.Width, sobel.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr sobelScan = sobelData.Scan0;

            unsafe
            {
                byte* img_p = (byte*)imgScan.ToPointer();
                img_p += imgData.Stride;
                byte* sobel_p = (byte*)sobelScan.ToPointer();
                sobel_p += sobelData.Stride;

                int[,] matrix = new int[,] { { -3, -2, -1 }, { 0, 1, 2 }, { 3, 4, 5 } };
                int[,] weights_ver = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
                int[,] weights_hor = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

                for (int y = 1; y < (img.Height - 1); y++)
                {
                    for (int x = 1; x < (img.Width - 1); x++)
                    {
                        int point = x * 3;

                        int red_ver = 0;
                        int green_ver = 0;
                        int blue_ver = 0;
                        int red_hor = 0;
                        int green_hor = 0;
                        int blue_hor = 0;

                        //遍歷九宮格內的值
                        img_p -= imgData.Stride;
                        sobel_p -= sobelData.Stride;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                blue_ver += img_p[point + matrix[j, 0]] * weights_ver[i, j];
                                green_ver += img_p[point + matrix[j, 1]] * weights_ver[i, j];
                                red_ver += img_p[point + matrix[j, 2]] * weights_ver[i, j];

                                blue_hor += img_p[point + matrix[j, 0]] * weights_hor[i, j];
                                green_hor += img_p[point + matrix[j, 1]] * weights_hor[i, j];
                                red_hor += img_p[point + matrix[j, 2]] * weights_hor[i, j];
                            }
                            img_p += imgData.Stride;
                            sobel_p += sobelData.Stride;
                        }
                        img_p -= imgData.Stride * 2;
                        sobel_p -= sobelData.Stride * 2;

                        int blue_sobel = Math.Abs(blue_ver) + Math.Abs(blue_hor);
                        int green_sobel = Math.Abs(green_ver) + Math.Abs(green_hor);
                        int red_sobel = Math.Abs(red_ver) + Math.Abs(red_hor);

                        if (red_sobel > 255) { red_sobel = 255; }
                        if (green_sobel > 255) { green_sobel = 255; }
                        if (blue_sobel > 255) { blue_sobel = 255; }

                        sobel_p[point] = (byte)(blue_sobel);
                        sobel_p[point + 1] = (byte)(green_sobel);
                        sobel_p[point + 2] = (byte)(red_sobel);

                    }
                    sobel_p += sobelData.Stride;
                    img_p += imgData.Stride;
                }
            }
            img.UnlockBits(imgData);
            sobel.UnlockBits(sobelData);
            return sobel;
        }

        public static Bitmap laplacian(Bitmap laplacian, Bitmap img, String select)
        {
            BitmapData imgData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr imgScan = imgData.Scan0;
            BitmapData laplacianData = laplacian.LockBits(new Rectangle(0, 0, laplacian.Width, laplacian.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr laplacianScan = laplacianData.Scan0;

            int[,] laplacian_matrix = new int[3,3];

            switch (select)
            {
                case "Laplacian 1":
                    laplacian_matrix = new int[,] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
                    break;
                case "Laplacian 2":
                    laplacian_matrix = new int[,] { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
                    break;
                case "Laplacian 3":
                    laplacian_matrix = new int[,] { { 1, -2, 1 }, { -2, 4, -2 }, { 1, -2, 1 } };
                    break;
            }

            unsafe
            {
                byte* img_p = (byte*)imgScan.ToPointer();
                img_p += imgData.Stride;
                byte* laplacian_p = (byte*)laplacianScan.ToPointer();
                laplacian_p += laplacianData.Stride;

                int[,] matrix = new int[,] { { -3, -2, -1 }, { 0, 1, 2 }, { 3, 4, 5 } };

                for (int y = 1; y < (img.Height - 1); y++)
                {
                    for (int x = 1; x < (img.Width - 1); x++)
                    {
                        int point = x * 3;

                        int red = 0;
                        int green = 0;
                        int blue = 0;

                        //遍歷九宮格內的值
                        img_p -= imgData.Stride;
                        laplacian_p -= laplacianData.Stride;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                blue += img_p[point + matrix[j, 0]] * laplacian_matrix[i, j];
                                green += img_p[point + matrix[j, 1]] * laplacian_matrix[i, j];
                                red += img_p[point + matrix[j, 2]] * laplacian_matrix[i, j];
                            }
                            img_p += imgData.Stride;
                            laplacian_p += laplacianData.Stride;
                        }
                        img_p -= imgData.Stride * 2;
                        laplacian_p -= laplacianData.Stride * 2;

                        if (red > 255) { red = 255; }
                        if (green > 255) { green = 255; }
                        if (blue > 255) { blue = 255; }
                        if (red < 0) { red = 0; }
                        if (green < 0) { green = 0; }
                        if (blue < 0) { blue = 0; }

                        laplacian_p[point] = (byte)(blue);
                        laplacian_p[point + 1] = (byte)(green);
                        laplacian_p[point + 2] = (byte)(red);

                    }
                    laplacian_p += laplacianData.Stride;
                    img_p += imgData.Stride;
                }
            }
            img.UnlockBits(imgData);
            laplacian.UnlockBits(laplacianData);
            return laplacian;
        }
    }
}
