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

        private void button_blur_Click(object sender, EventArgs e)
        {
            String s = "";

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int red = img.GetPixel(x, y).R;
                    s += string.Format("{0:D3}", red) + " ";
                }
                s += "\n";
            }

            label_blur.Text = s;
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

        private void button_medium_Click(object sender, EventArgs e)
        {
            Bitmap medium = new Bitmap(img.Width, img.Height);
            int[] r = new int[9];
            int[] g = new int[9];
            int[] b = new int[9];


            for (int x = 1; x < img.Width - 1; x++)
            {
                for (int y = 1; y < img.Height - 1 ; y++)
                {
                    r[0] = img.GetPixel(x - 1, y - 1).R;
                    r[1] = img.GetPixel(x - 1, y).R;
                    r[2] = img.GetPixel(x - 1, y + 1).R;
                    r[3] = img.GetPixel(x, y - 1).R;
                    r[4] = img.GetPixel(x, y).R;
                    r[5] = img.GetPixel(x, y + 1).R;
                    r[6] = img.GetPixel(x + 1, y - 1).R;
                    r[7] = img.GetPixel(x + 1, y).R;
                    r[8] = img.GetPixel(x + 1, y + 1).R;

                    g[0] = img.GetPixel(x - 1, y - 1).G;
                    g[1] = img.GetPixel(x - 1, y).G;
                    g[2] = img.GetPixel(x - 1, y + 1).G;
                    g[3] = img.GetPixel(x, y - 1).G;
                    g[4] = img.GetPixel(x, y).G;
                    g[5] = img.GetPixel(x, y + 1).G;
                    g[6] = img.GetPixel(x + 1, y - 1).G;
                    g[7] = img.GetPixel(x + 1, y).G;
                    g[8] = img.GetPixel(x + 1, y + 1).G;

                    b[0] = img.GetPixel(x - 1, y - 1).B;
                    b[1] = img.GetPixel(x - 1, y).B;
                    b[2] = img.GetPixel(x - 1, y + 1).B;
                    b[3] = img.GetPixel(x, y - 1).B;
                    b[4] = img.GetPixel(x, y).B;
                    b[5] = img.GetPixel(x, y + 1).B;
                    b[6] = img.GetPixel(x + 1, y - 1).B;
                    b[7] = img.GetPixel(x + 1, y).B;
                    b[8] = img.GetPixel(x + 1, y + 1).B;

                    Array.Sort(r);
                    Array.Sort(g);
                    Array.Sort(b);

                    int red = r[4];
                    int green = g[4];
                    int blue = b[4];

                    medium.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }

            img = medium;
            pictureBox2.Image = medium;
        }
    }
}
