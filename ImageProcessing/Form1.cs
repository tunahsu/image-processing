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
        static Stack<Bitmap> img_stack = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void initForm()
        {
            comboBox_grayscale.SelectedIndex = 0;
            comboBox_enhancement.SelectedIndex = 0;
            comboBox_spatialFiltering.SelectedIndex = 0;
            // comboBox1.SelectedIndex = 0;
            button_grayscale.Enabled = true;
            button_enhancement.Enabled = true;
            button_spatialFiltering.Enabled = true;
        }

        private void clearResult()
        {
            pictureBox_result.Image = null;
            pictureBox_resultRB.Image = null;
            pictureBox_resultGB.Image = null;
            pictureBox_resultBB.Image = null;
            pictureBox_resultRH.Image = null;
            pictureBox_resultGH.Image = null;
            pictureBox_resultBH.Image = null;
            label_result_size.Text = "0 X 0";
            img_stack.Clear();
        }

        private void button_undo_Click(object sender, EventArgs e)
        {
            if (img_stack.Count() > 1)
            {
                img = img_stack.Pop();
                pictureBox_result.Image = img;
                label_result_size.Text = img.Width.ToString() + " X " + img.Height.ToString();
                showBand_res(img);
            }
            else if(img_stack.Count() == 1)
            {
                img = img_stack.Pop();
                clearResult();
            }
        }

        private void showBand_ori(Bitmap img)
        {
            // show RGB bands
            Tuple<int[,,], int[,,], int[,,]> bands = ImageRW.getBand(img);
            pictureBox_originRB.Image = ImageRW.SetRGB(bands.Item1);
            pictureBox_originGB.Image = ImageRW.SetRGB(bands.Item2);
            pictureBox_originBB.Image = ImageRW.SetRGB(bands.Item3);

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
            pictureBox_resultRB.Image = ImageRW.SetRGB(bands.Item1);
            pictureBox_resultGB.Image = ImageRW.SetRGB(bands.Item2);
            pictureBox_resultBB.Image = ImageRW.SetRGB(bands.Item3);

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
                clearResult();

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
            // saveImg.RestoreDirectory = true;

            if (saveImg.ShowDialog() == DialogResult.OK)
            {
                string filename = saveImg.FileName.Replace(".jpg", "");
                img.Save(filename + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void button_grayscale_Click(object sender, EventArgs e)
        {
            string str = comboBox_grayscale.Text;
            img_stack.Push(img);
            img = Grayscale.Transform(img, str);
            pictureBox_result.Image = img;
            label_result_size.Text = img.Width.ToString() + " X " + img.Height.ToString();
            showBand_res(img);
        }

        private void button_enhancement_Click(object sender, EventArgs e)
        {
            string str = comboBox_enhancement.Text;
            // string str2 = comboBox1.Text;
            img_stack.Push(img);
            img = Enhancement.Transform(img, str);
            pictureBox_result.Image = img;
            label_result_size.Text = img.Width.ToString() + " X " + img.Height.ToString();
            showBand_res(img);
        }

        private void button_spatialFiltering_Click(object sender, EventArgs e)
        {
            string str = comboBox_spatialFiltering.Text;
            // string str2 = comboBox1.Text;
            img_stack.Push(img);
            img = SpatialFiltering.Transform(img, str);
            pictureBox_result.Image = img;
            label_result_size.Text = img.Width.ToString() + " X " + img.Height.ToString();
            showBand_res(img);
        }
    }
}
