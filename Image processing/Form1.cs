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
        static Bitmap img_temp = new Bitmap(1, 1);
        static int pixel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();

            openImg.Title = "Open File";
            openImg.Filter = "All files (*.jpg)|*.*|All files (*.*)|*.*|All files (*.bmp)|*.*";
            //openImg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //set default path = desktop
            openImg.RestoreDirectory = true;

            if (openImg.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(Image.FromFile(openImg.FileName));
                img = img.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                img_origin = new Bitmap(img);
                img_temp = img;

                pictureBox1.Image = img_origin;
                pictureBox2.Image = null;
                label_origin.Text = img.Width.ToString() + " X " + img.Height.ToString();
                textBox_width.Text = img.Width.ToString();
                textBox_height.Text = img.Height.ToString();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
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
            try
            {
                img = img_temp;
                pictureBox2.Image = img;
                label_result.Text = img.Width.ToString() + " X " + img.Height.ToString();
                textBox_width.Text = img.Width.ToString();
                textBox_height.Text = img.Height.ToString();
            }
            catch
            {

            }
        }

        private void button_origin_Click(object sender, EventArgs e)
        {
            try
            {
                img_temp = img;
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

        private void button_resize_Click(object sender, EventArgs e)
        {
            try
            {
                int re_width = Int32.Parse(textBox_width.Text);
                int re_height = Int32.Parse(textBox_height.Text);
                img_temp = img;
                img = new Bitmap(img_origin, new Size(re_width, re_height));
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
    }
}
