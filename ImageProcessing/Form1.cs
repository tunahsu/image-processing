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

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        static Bitmap img = new Bitmap(1, 1);
        static Bitmap img_origin = new Bitmap(1, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void initForm()
        {
            pictureBox_originRB.Image = null;
            pictureBox_originGB.Image = null;
            pictureBox_originBB.Image = null;
            label_origin_size.Text = "0 X 0";
        }

        private void showBand(Bitmap img)
        {
            // show RGB bands
            Tuple<int[,,], int[,,], int[,,]> bands = ImageRW.getBand(img);
            pictureBox_originRB.Image = ImageRW.setRGB(bands.Item1);
            pictureBox_originGB.Image = ImageRW.setRGB(bands.Item2);
            pictureBox_originBB.Image = ImageRW.setRGB(bands.Item3);

            // show histogram of  RGB bands
            Tuple<Bitmap, Bitmap, Bitmap> histograms = ImageRW.getHistogram(img);
            pictureBox_originRH.Image = histograms.Item1;
            pictureBox_originGH.Image = histograms.Item2;
            pictureBox_originBH.Image = histograms.Item3;
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();

            openImg.Title = "Open Image File";
            openImg.Filter = "All files (*.jpg)|*.*|All files (*.*)|*.*";
            // openImg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //set default path = desktop
            openImg.RestoreDirectory = true;

            if (openImg.ShowDialog() == DialogResult.OK)
            {
                // initialize
                initForm();

                // create image
                img = new Bitmap(Image.FromFile(openImg.FileName));
                img_origin = new Bitmap(img);

                // set image information
                pictureBox_origin.Image = img_origin;
                label_origin_size.Text = img_origin.Width.ToString() + " X " + img.Height.ToString();
                showBand(img_origin);
            }

        }
        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImg = new SaveFileDialog();

            saveImg.Title = "Save Image File";
            saveImg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveImg.Filter = "All files (*.jpg)|*.*|All files (*.*)|*.*";
            saveImg.RestoreDirectory = true;

            if (saveImg.ShowDialog() == DialogResult.OK)
            {
                img.Save(saveImg.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Bmp);
            }

        }
    }
}
