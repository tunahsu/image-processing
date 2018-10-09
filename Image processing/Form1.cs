using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Image_processing
{
    public partial class Form1 : Form
    {
        static Bitmap img = new Bitmap(1, 1);
        static Bitmap img_origin = new Bitmap(1, 1);
        static int pixel;
        static int pixel_origin;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e) //open file
        {
            OpenFileDialog openImg = new OpenFileDialog();

            openImg.Title = "Open File";
            openImg.Filter = "All files (*.jpg)|*.*|All files (*.*)|*.*|All files (*.bmp)|*.*";
            //openImg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //set default path = desktop
            openImg.RestoreDirectory = true;

            if (openImg.ShowDialog() == DialogResult.OK)
            {
                //create image
                img_origin = new Bitmap(Image.FromFile(openImg.FileName));
                img_origin = img_origin.Clone(new Rectangle(0, 0, img_origin.Width, img_origin.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                img = new Bitmap(img_origin);

                //set image information
                pictureBox1.Image = img_origin;
                pictureBox2.Image = null;
                label_origin.Text = img.Width.ToString() + " X " + img.Height.ToString();
                textBox_width.Text = img.Width.ToString();
                textBox_height.Text = img.Height.ToString();
                pixel_origin = img_origin.Width * img_origin.Height;

                //test
                /*
                int[] scale_r = new int[256];
                int[] scale_g = new int[256];
                int[] scale_b = new int[256];

                for (int x = 0; x < img_origin.Width; x++)
                {
                    for (int y = 0; y < img_origin.Height; y++)
                    {
                        int red = img.GetPixel(x, y).R;
                        int green = img.GetPixel(x, y).G;
                        int blue = img.GetPixel(x, y).B;

                        scale_r[red]++;
                        scale_r[green]++;
                        scale_r[blue]++;
                    }
                }

                for(int i  = 0; i <  256; i++)
                {
                    scale_r[i] = (int)((double)(scale_r[i] / pixel_origin) * 80);
                    MessageBox.Show(scale_r[i].ToString());
                }
                */

                /*
                Bitmap scale = new Bitmap(80, 80);

                for(int y = 79; y >= 0; y--)
                {
                    for(int x = 0; x < 80; x++)
                    {
                        if(scale_r[3 * x] != 0){
                            scale_r[3 * x]--;
                            scale.SetPixel(x, y, Color.Red);
                            MessageBox.Show(scale_r[3 * x].ToString());
                        }
                    }
                }

                pictureBox3.Image = scale;
                */
            }
        }

        private void button_save_Click(object sender, EventArgs e) //save file
        {
            SaveFileDialog saveImg = new SaveFileDialog();

            saveImg.Title = "Save File";
            saveImg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveImg.Filter = "All files (*.bmp)|*.*|All files (*.*)|*.*";
            saveImg.RestoreDirectory = true;

            if(saveImg.ShowDialog() == DialogResult.OK)
            {
                img.Save(saveImg.FileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        private void button_undo_Click(object sender, EventArgs e)
        {

        }

        private void button_origin_Click(object sender, EventArgs e) //reset image
        {
            try
            {
                img = img_origin;
                pictureBox2.Image = img;
                label_result.Text = img.Width.ToString() + " X " + img.Height.ToString();
                textBox_width.Text = img.Width.ToString();
                textBox_height.Text = img.Height.ToString();
            }
            catch
            {
                
            }
        }

        private void button_resize_Click(object sender, EventArgs e) //resize image
        {
            try
            {
                //create new size image
                int re_width = Int32.Parse(textBox_width.Text);
                int re_height = Int32.Parse(textBox_height.Text);
                img = new Bitmap(img, new Size(re_width, re_height));

                //new size image information
                label_result.Text = re_width.ToString() + " X " + re_height.ToString();
                pictureBox2.Image = img;
                pixel = img.Width * img.Height;
                textBox_width.Text = img.Width.ToString();
                textBox_height.Text = img.Height.ToString();
            }
            catch
            {
                MessageBox.Show("Please select image ! ! !", "Error");
            }
        }

        private void button_grayscale_Click(object sender, EventArgs e)
        {
            Bitmap grayscale = new Bitmap(img.Width, img.Height);

            for(int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int red = img.GetPixel(x, y).R;
                    int green = img.GetPixel(x, y).G;
                    int blue = img.GetPixel(x, y).G;
                    int gray = (int)(red * 0.299 + green * 0.587 + blue * 0.114);

                    grayscale.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            img = grayscale;
            pictureBox2.Image = grayscale;
        }

        private void button_negative_Click(object sender, EventArgs e)
        {
            Bitmap negative = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int red = 255 - img.GetPixel(x, y).R;
                    int green = 255 - img.GetPixel(x, y).G;
                    int blue = 255 - img.GetPixel(x, y).B;

                    negative.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            img = negative;
            pictureBox2.Image = negative;
        }

        private void button_retro_Click(object sender, EventArgs e)
        {
            Bitmap retro = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int r = img.GetPixel(x, y).R;
                    int g = img.GetPixel(x, y).G;
                    int b = img.GetPixel(x, y).B;

                    int red = (int)(r * 0.393 + 0.769 * g + 0.189 * b);
                    int green = (int)(r * 0.343 + 0.686 * g + 0.168 * b);
                    int blue = (int)(r * 0.272 + 0.543 * g + 0.131 * b);

                    if (red > 255) { red = 255; }
                    if (green > 255) { green = 255; }

                    retro.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            img = retro;
            pictureBox2.Image = retro;
        }

        private void button_median_Click(object sender, EventArgs e)
        {
            Bitmap medium = new Bitmap(img.Width, img.Height);
            int[] r = new int[9];
            int[] g = new int[9];
            int[] b = new int[9];
            int[] pixelX = new int[3];
            int[] pixelY = new int[3];

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 1; y < img.Height; y++)
                {
                    if (x == 0 || x == (img.Width - 1) || y == 0 || y == (img.Height - 1))
                    {
                        medium.SetPixel(x, y, Color.FromArgb(img.GetPixel(x, y).R, img.GetPixel(x, y).G, img.GetPixel(x, y).B));
                    }
                    else
                    {
                        pixelX[0] = x - 1;
                        pixelX[1] = x;
                        pixelX[2] = x + 1;
                        pixelY[0] = y - 1;
                        pixelY[1] = y;
                        pixelY[2] = y + 1;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                r[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).R;
                                g[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).G;
                                b[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).B;
                            }
                        }

                        Array.Sort(r);
                        Array.Sort(g);
                        Array.Sort(b);

                        int red = r[4];
                        int green = g[4];
                        int blue = b[4];

                        medium.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
            }

            img = medium;
            pictureBox2.Image = medium;
        }

        private void button_mean_Click(object sender, EventArgs e)
        {
            Bitmap mean = new Bitmap(img.Width, img.Height);
            int[] r = new int[9];
            int[] g = new int[9];
            int[] b = new int[9];
            int[] pixelX = new int[3];
            int[] pixelY = new int[3];

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 1; y < img.Height; y++)
                {
                    if (x == 0 || x == (img.Width - 1) || y == 0 || y == (img.Height - 1))
                    {
                        mean.SetPixel(x, y, Color.FromArgb(img.GetPixel(x, y).R, img.GetPixel(x, y).G, img.GetPixel(x, y).B));
                    }
                    else
                    {
                        pixelX[0] = x - 1;
                        pixelX[1] = x;
                        pixelX[2] = x + 1;
                        pixelY[0] = y - 1;
                        pixelY[1] = y;
                        pixelY[2] = y + 1;

                        int red = 0;
                        int green = 0;
                        int blue = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                red += r[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).R;
                                green += g[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).G;
                                blue += b[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).B;
                            }
                        }

                        red /= 9;
                        green /= 9;
                        blue /= 9;

                        mean.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
            }

            img = mean;
            pictureBox2.Image = mean;
        }

        private void button_gaussian_Click(object sender, EventArgs e)
        {
            Bitmap gaussian = new Bitmap(img.Width, img.Height);
            int[] r = new int[9];
            int[] g = new int[9];
            int[] b = new int[9];
            int[] pixelX = new int[3];
            int[] pixelY = new int[3];

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 1; y < img.Height; y++)
                {
                    if (x == 0 || x == (img.Width - 1) || y == 0 || y == (img.Height - 1))
                    {
                        gaussian.SetPixel(x, y, Color.FromArgb(img.GetPixel(x, y).R, img.GetPixel(x, y).G, img.GetPixel(x, y).B));
                    }
                    else
                    {
                        pixelX[0] = x - 1;
                        pixelX[1] = x;
                        pixelX[2] = x + 1;
                        pixelY[0] = y - 1;
                        pixelY[1] = y;
                        pixelY[2] = y + 1;

                        int red = 0;
                        int green = 0;
                        int blue = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if((i == 0 && j == 0) || (i == 0 && j == 2) || (i == 2 && j == 0) || (i == 2 && j == 2))
                                {
                                    red += r[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).R;
                                    green += g[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).G;
                                    blue += b[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).B;
                                }
                                else if((i == 0 && j == 1) || (i == 1 && j == 0) || (i == 1 && j == 2) || (i == 2 && j == 1))
                                {
                                    red += r[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).R * 2;
                                    green += g[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).G * 2;
                                    blue += b[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).B * 2;
                                }
                                else
                                {
                                    red += r[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).R * 4;
                                    green += g[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).G * 4;
                                    blue += b[i * 3 + j] = img.GetPixel(pixelX[i], pixelY[j]).B * 4;
                                }
                            }
                        }

                        red /= 16;
                        green /= 16;
                        blue /= 16;

                        gaussian.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
            }

            img = gaussian;
            pictureBox2.Image = gaussian;
        }

        private void button_sobel_Click(object sender, EventArgs e)
        {
            Bitmap sobel = new Bitmap(img.Width, img.Height);
            int[] r = new int[9];
            int[] g = new int[9];
            int[] b = new int[9];
            int[] pixelX = new int[3];
            int[] pixelY = new int[3];
            int[] weights_ver = new int[9] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
            int[] weights_hor = new int[9] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 1; y < img.Height; y++)
                {
                    if (x == 0 || x == (img.Width - 1) || y == 0 || y == (img.Height - 1))
                    {
                        sobel.SetPixel(x, y, Color.FromArgb(img.GetPixel(x, y).R, img.GetPixel(x, y).G, img.GetPixel(x, y).B));
                    }
                    else
                    {
                        pixelX[0] = x - 1;
                        pixelX[1] = x;
                        pixelX[2] = x + 1;
                        pixelY[0] = y - 1;
                        pixelY[1] = y;
                        pixelY[2] = y + 1;

                        int red_ver = 0;
                        int green_ver = 0;
                        int blue_ver = 0;
                        int red_hor = 0;
                        int green_hor = 0;
                        int blue_hor = 0;
                        int n = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                red_ver += img.GetPixel(pixelX[i], pixelY[j]).R * weights_ver[n];
                                green_ver += img.GetPixel(pixelX[i], pixelY[j]).G * weights_ver[n];
                                blue_ver += img.GetPixel(pixelX[i], pixelY[j]).B * weights_ver[n];
                                red_hor += img.GetPixel(pixelX[i], pixelY[j]).R * weights_hor[n];
                                green_hor += img.GetPixel(pixelX[i], pixelY[j]).G * weights_hor[n];
                                blue_hor += img.GetPixel(pixelX[i], pixelY[j]).B * weights_hor[n];
                                n++;
                            }
                        }

                        int red_sobel = ((int)Math.Sqrt(red_ver * red_ver + red_hor * red_hor) > 255) ? 255 : (int)Math.Sqrt(red_ver * red_ver + red_hor * red_hor);
                        int green_sobel = ((int)Math.Sqrt(green_ver * green_ver + green_hor * green_hor) > 255) ? 255 : (int)Math.Sqrt(green_ver * green_ver + green_hor * green_hor);
                        int blue_sobel = ((int)Math.Sqrt(blue_ver * blue_ver + blue_hor * blue_hor) > 255) ? 255 : (int)Math.Sqrt(blue_ver * blue_ver + blue_hor * blue_hor);

                        sobel.SetPixel(x, y, Color.FromArgb(red_sobel, green_sobel, blue_sobel));
                    }
                }
            }

            img = sobel;
            pictureBox2.Image = sobel;
        }

        private void button_laplacian_Click(object sender, EventArgs e)
        {
            Bitmap laplacian = new Bitmap(img.Width, img.Height);
            int[] r = new int[9];
            int[] g = new int[9];
            int[] b = new int[9];
            int[] pixelX = new int[3];
            int[] pixelY = new int[3];
            int[] laplacian_matrix = new int[9];

            switch (comboBox_laplacian.Text)
            {
                case "Laplacian 1" :
                    laplacian_matrix = new int[9] { 0, -1, 0, -1, 4, -1, 0, -1, 0 };
                    break;
                case "Laplacian 2":
                    laplacian_matrix = new int[9] { -1, 1, -1, -1, 8, -1, -1, -1, -1 };
                    break;
                case "Laplacian 3":
                    laplacian_matrix = new int[9] { 1, -2, 1, -2, 4, -2, 1, -2, 1 };
                    break;
            }
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 1; y < img.Height; y++)
                {
                    if (x == 0 || x == (img.Width - 1) || y == 0 || y == (img.Height - 1))
                    {
                        laplacian.SetPixel(x, y, Color.FromArgb(img.GetPixel(x, y).R, img.GetPixel(x, y).G, img.GetPixel(x, y).B));
                    }
                    else
                    {
                        pixelX[0] = x - 1;
                        pixelX[1] = x;
                        pixelX[2] = x + 1;
                        pixelY[0] = y - 1;
                        pixelY[1] = y;
                        pixelY[2] = y + 1;

                        int red = 0;
                        int green = 0;
                        int blue = 0;
                        int n = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                red += img.GetPixel(pixelX[i], pixelY[j]).R * laplacian_matrix[n];
                                green += img.GetPixel(pixelX[i], pixelY[j]).G * laplacian_matrix[n];
                                blue += img.GetPixel(pixelX[i], pixelY[j]).B * laplacian_matrix[n];
                                n++;
                            }
                        }

                        if (red < 0) { red = 0; }
                        if (red > 255) { red = 255; }
                        if (green < 0) { green = 0; }
                        if (green > 255) { green = 255; }
                        if (blue < 0) { blue = 0; }
                        if (blue > 255) { blue = 255; }

                        laplacian.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
            }

            img = laplacian;
            pictureBox2.Image = laplacian;
        }
    }
}
