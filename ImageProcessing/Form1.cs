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
            comboBox_grayscale.SelectedIndex = 0;
            button_grayscale.Enabled = true;
        }

        private void showBand_ori(Bitmap img)
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

        private void showBand_res(Bitmap img)
        {
            // show RGB bands
            Tuple<int[,,], int[,,], int[,,]> bands = ImageRW.getBand(img);
            pictureBox_resultRB.Image = ImageRW.setRGB(bands.Item1);
            pictureBox_resultGB.Image = ImageRW.setRGB(bands.Item2);
            pictureBox_resultBB.Image = ImageRW.setRGB(bands.Item3);

            // show histogram of  RGB bands
            Tuple<Bitmap, Bitmap, Bitmap> histograms = ImageRW.getHistogram(img);
            pictureBox_resultRH.Image = histograms.Item1;
            pictureBox_resultGH.Image = histograms.Item2;
            pictureBox_resultBH.Image = histograms.Item3;
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
                label_origin_size.Text = img_origin.Width.ToString() + " X " + img_origin.Height.ToString();
                showBand_ori(img_origin);
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

        private void button_grayscale_Click(object sender, EventArgs e)
        {
            string str = comboBox_grayscale.Text;
            switch (str)
            {
                case "Mean":
                    img = Grayscale.mean(img_origin);
                    break;
                case "Weight":
                    img = Grayscale.weight(img_origin);
                    break;

                case "Max":
                    img = Grayscale.max(img_origin);
                    break;
            }
            pictureBox_result.Image = img;
            label_result_size.Text = img.Width.ToString() + " X " + img.Height.ToString();
            showBand_res(img);
        }
    }
}
