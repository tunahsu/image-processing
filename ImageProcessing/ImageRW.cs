using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessing
{
	public class ImageRW
	{
        public static int[,,] GetRGB(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;

            // lock bitmap memory
            BitmapData img_data = img.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            IntPtr img_ptr = img_data.Scan0;
            int stride = img_data.Stride;
            int width_byte = width * 3;
            int skip_byte = stride - width_byte;
            int[,,] rgb_data = new int[height, width, 3];

            unsafe
            {
                byte* p = (byte*)img_ptr;
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        //B
                        rgb_data[j, i, 2] = p[0];
                        p++;
                        //G
                        rgb_data[j, i, 1] = p[0];
                        p++;
                        //R
                        rgb_data[j, i, 0] = p[0];
                        p++;
                    }
                    p += skip_byte;
                }
            }
            img.UnlockBits(img_data);
            return rgb_data;
        }

        public static Bitmap SetRGB(int[,,] rgb_data)
        {
            Bitmap img;
            int width = rgb_data.GetLength(1);
            int height = rgb_data.GetLength(0);

            img = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData img_data = img.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            IntPtr img_ptr = img_data.Scan0;
            int stride = img_data.Stride;
            int width_byte = width * 3;
            int skip_byte = stride - width_byte;

            unsafe
            {
                byte* p = (byte*)(void*)img_ptr;
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        //B
                        p[0] = (byte)rgb_data[j, i, 2];
                        p++;
                        //G
                        p[0] = (byte)rgb_data[j, i, 1];
                        p++;
                        //R
                        p[0] = (byte)rgb_data[j, i, 0];
                        p++;
                    }
                    p += skip_byte;
                }
            }
            img.UnlockBits(img_data);
            return img;
        }

        public static Tuple<int[,,], int[,,], int[,,]>  getBand(Bitmap img)
        {
            int[,,] rgb = GetRGB(img);
            int width = img.Width;
            int height = img.Height;

            int temp = 0;
            int[,,] RBand = new int[height, width, 3];
            int[,,] GBand = new int[height, width, 3];
            int[,,] BBand = new int[height, width, 3];

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    //push R
                    temp = rgb[j, i, 0];
                    RBand[j, i, 0] = temp;
                    RBand[j, i, 1] = temp;
                    RBand[j, i, 2] = temp;

                    //push G
                    temp = rgb[j, i, 1];
                    GBand[j, i, 0] = temp;
                    GBand[j, i, 1] = temp;
                    GBand[j, i, 2] = temp;

                    //push B
                    temp = rgb[j, i, 2];
                    BBand[j, i, 0] = temp;
                    BBand[j, i, 1] = temp;
                    BBand[j, i, 2] = temp;
                }
            }
            return new Tuple<int[,,], int[,,], int[,,]>(RBand, GBand, BBand);
        }

        public static Tuple<Bitmap, Bitmap, Bitmap> getHistogram(Bitmap img)
        {
            int[] r = new int[256];
            int[] g = new int[256];
            int[] b = new int[256];
        
            for(int x = 0; x < img.Width; x++)
            {
                for(int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    r[pixel.R]++;
                    g[pixel.G]++;
                    b[pixel.B]++;
                }
            }

            int max = 0;
            for(int i = 0; i < 256; i++)
            {
                if(r[i] > max)
                {
                    max = r[i];
                }
                if (g[i] > max)
                {
                    max = g[i];
                }
                if (b[i] > max)
                {
                    max = b[i];
                }
            }

            Bitmap img_r = new Bitmap(256, 100);
            for(int x = 0; x < img_r.Width; x++)
            {
                for(int y = 0; y < (int)(((float)r[x] / max) * 100); y++)
                {
                    img_r.SetPixel(x, img_r.Height - 1 - y, Color.FromArgb(255, 0, 0));
                }
            }

            Bitmap img_g = new Bitmap(256, 100);
            for (int x = 0; x < img_g.Width; x++)
            {
                for (int y = 0; y < (int)(((float)g[x] / max) * 100); y++)
                {
                    img_g.SetPixel(x, img_g.Height - 1 - y, Color.FromArgb(0, 255, 0));
                }
            }

            Bitmap img_b = new Bitmap(256, 100);
            for (int x = 0; x < img_b.Width; x++)
            {
                for (int y = 0; y < (int)(((float)b[x] / max) * 100); y++)
                {
                    img_b.SetPixel(x, img_b.Height - 1 - y, Color.FromArgb(0, 0, 255));
                }
            }
            return new Tuple<Bitmap, Bitmap, Bitmap>(img_r, img_g, img_b);
        }
    }
}

