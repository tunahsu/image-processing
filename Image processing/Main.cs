using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Image_processing
{
    public partial class Main : Form
    {
        static Bitmap img = new Bitmap(1, 1);
        static Bitmap img_origin = new Bitmap(1, 1);
        static int pixel;
        static int pixel_origin;

        public Main()
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
                img_origin = img_origin.Clone(new Rectangle(0, 0, img_origin.Width, img_origin.Height), PixelFormat.Format24bppRgb);
                img = new Bitmap(img_origin);

                //set image information
                pictureBox1.Image = img_origin;
                pictureBox2.Image = null;
                label_origin.Text = img.Width.ToString() + " X " + img.Height.ToString();
                textBox_width.Text = img.Width.ToString();
                textBox_height.Text = img.Height.ToString();
                pixel_origin = img_origin.Width * img_origin.Height;
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
                img = new Bitmap(img_origin);
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
                MessageBox.Show("未選擇圖片 或 未填入長寬", "Error");
            }
        }

        private void button_grayscale_Click(object sender, EventArgs e)
        {
            img = Grayscale.grayscale(img);
            pictureBox2.Image = img;
        }

        private void button_negative_Click(object sender, EventArgs e)
        {
            img = Negative.negative(img);
            pictureBox2.Image = img;
        }

        private void button_retro_Click(object sender, EventArgs e)
        {
            img = Retro.retro(img);
            pictureBox2.Image = img;
        }

        private void button_median_Click(object sender, EventArgs e)
        {
            img = Smoothing.median(img);
            pictureBox2.Image = img;
        }

        private void button_mean_Click(object sender, EventArgs e)
        {
            img = Smoothing.mean(img);
            pictureBox2.Image = img;
        }

        private void button_sobel_Click(object sender, EventArgs e)
        {
            Bitmap sobel = new Bitmap(img.Width, img.Height);
            img = Edge.sobel(sobel, img);
            pictureBox2.Image = img;
        }

        private void button_laplacian_Click(object sender, EventArgs e)
        {
            Bitmap laplacian = new Bitmap(img.Width, img.Height);
            img = Edge.laplacian(laplacian, img, comboBox_laplacian.Text);
            pictureBox2.Image = img;
        }
    }
}
