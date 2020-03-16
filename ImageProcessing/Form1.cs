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
            pictureBox_originR.Image = null;
            pictureBox_originG.Image = null;
            pictureBox_originB.Image = null;
            label_origin_size.Text = "0 X 0";
        }

        private void showBand()
        {

        }

        public static int[,,] getRGB(Bitmap bitimg)
        {
            int width = bitimg.Width;
            int height = bitimg.Height;

            BitmapData bitmap_data = bitimg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            IntPtr img_ptr = bitmap_data.Scan0;
            int stride = bitmap_data.Stride;
            int width_byte = width * 3;
            int skip_byte = stride - width_byte;
            int[,,] rgb_data = new int[height, width, 3];

            unsafe
            {
                byte* p = (byte*)img_ptr;
                for(int j = 0; j < height; j++)
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
            bitimg.UnlockBits(bitmap_data);
            return rgb_data;
        }

        public static Bitmap setRGB(int[,,] rgb_data)
        {
            Bitmap bitimg;
            int width = rgb_data.GetLength(0);
            int height = rgb_data.GetLength(1);

            bitimg = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bitmap_data = bitimg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            IntPtr img_ptr = bitmap_data.Scan0;
            int stride = bitmap_data.Stride;
            int width_byte = width * 3;
            int skip_byte = stride - width_byte;

            unsafe
            {
                byte* p = (byte*)img_ptr;
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
            bitimg.UnlockBits(bitmap_data);
            return bitimg;
        }

        private void showBand(Bitmap img)
        {
            int[,,] rgb = getRGB(img);
            int width = img.Width;
            int height = img.Height;

            int temp = 0;
            int[,,] RBand = new int[height, width, 3];
            int[,,] GBand = new int[height, width, 3];
            int[,,] BBand = new int[height, width, 3];
        
            for(int j = 0; j < height; j++)
            {
                for(int i = 0; i < width; i++)
                {
                    //set R
                    temp = rgb[j, i, 0];
                    RBand[j, i, 0] = temp;
                    RBand[j, i, 1] = temp;
                    RBand[j, i, 2] = temp;

                    //set G
                    temp = rgb[j, i, 1];
                    GBand[j, i, 0] = temp;
                    GBand[j, i, 1] = temp;
                    GBand[j, i, 2] = temp;

                    //set B
                    temp = rgb[j, i, 2];
                    BBand[j, i, 0] = temp;
                    BBand[j, i, 1] = temp;
                    BBand[j, i, 2] = temp;
                }
            }
            pictureBox_originR.Image = setRGB(RBand);
            pictureBox_originG.Image = setRGB(GBand);
            pictureBox_originB.Image = setRGB(BBand);
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();

            openImg.Title = "Open Image File";
            openImg.Filter = "All files (*.jpg)|*.*|All files (*.*)|*.*";
            //openImg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //set default path = desktop
            openImg.RestoreDirectory = true;

            if (openImg.ShowDialog() == DialogResult.OK)
            {
                initForm();

                //create image
                img = new Bitmap(Image.FromFile(openImg.FileName));
                //img_origin = img_origin.Clone(new Rectangle(0, 0, img_origin.Width, img_origin.Height), PixelFormat.Format24bppRgb);
                img_origin = new Bitmap(img);

                //set image information
                pictureBox_origin.Image = img_origin;
                //pictureBox2.Image = null;
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
