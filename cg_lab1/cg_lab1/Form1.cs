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

namespace cg_lab1
{
    public partial class Form1 : Form
    {
        List<List<int>> customConvMatrix;
        int anchor, offset, divisor;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox_input.Image = new Bitmap(open.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image" + ex.Message);

                }
            }
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            Bitmap input;
            if (pictureBox_output.Image != null)
                input = (Bitmap)pictureBox_output.Image;
            else
                input = (Bitmap)pictureBox_input.Image;

            if (input == null)
            {
                MessageBox.Show("Upload image first");
                return;
            }
 
            switch ((string)combobox_filters.SelectedItem)
            {
   
                case "inversion":
                    pictureBox_output.Image = ImageUtil.inverse(input);
                    //this.inverse();
                    break;
                case "brightness correction":
                    pictureBox_output.Image = ImageUtil.brigthness_correction(input);
                    break;
                case "contrast enhancement":
                    pictureBox_output.Image = ImageUtil.contrast(input);
                    break;
                case "blur":
                    //pictureBox_output.Image = ImageUtil.blur((Bitmap)pictureBox_input.Image,7,7);
                    pictureBox_output.Image = ImageUtil.convolutionFilter(input, ImageUtil.FilterType.blur);
                    break;
                case "gaussian smoothing":
                    pictureBox_output.Image = ImageUtil.convolutionFilter(input, ImageUtil.FilterType.gaussian_smoothing);
                    break;
                case "sharpen":
                    pictureBox_output.Image = ImageUtil.convolutionFilter(input, ImageUtil.FilterType.sharpen);
                    break;
                case "emboss":
                    pictureBox_output.Image = ImageUtil.convolutionFilter(input, ImageUtil.FilterType.emboss);
                    break;
                case "edge detection":
                    pictureBox_output.Image = ImageUtil.convolutionFilter(input, ImageUtil.FilterType.edge_detection);
                    break;
                case "custom":
                    if (customConvMatrix != null && anchor != 0 && offset != null && divisor != null)
                        pictureBox_output.Image = ImageUtil.convolutionFilter(input, customConvMatrix, offset, anchor, divisor);
                    else
                        MessageBox.Show("Please define custom filter first");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            customConvMatrix = form2.Matrix;
            anchor = form2.anchor;
            offset = form2.offset;
            divisor = form2.divisor;
        }

        private void erase_Click(object sender, EventArgs e)
        {
            pictureBox_input.Image = null;
            pictureBox_output.Image = null;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            pictureBox_output.Image = null;
        }

        private void combobox_filters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

