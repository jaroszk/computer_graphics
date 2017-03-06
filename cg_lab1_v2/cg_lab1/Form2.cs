using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cg_lab1
{
    public partial class Form2 : Form
    {
        public List<List<int>> Matrix;
        public int divisor, anchorX, anchorY, offset;

        public Form2()
        {
            InitializeComponent();
        }

        private void height_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            int matrix_width=0, matrix_height=0;
            try
            {
                matrix_width = int.Parse(textBox_width.Text);
                matrix_height = int.Parse(textBox_height.Text);
                if (matrix_width % 2 == 0 || matrix_height % 2 == 0 || matrix_width < 1 || matrix_width > 9 || matrix_height < 1 || matrix_height > 9)
                    throw new Exception("Incorrect matrix size");
                offset = int.Parse(textBox_offset.Text);
                divisor = int.Parse(textBox_divisor.Text);
                anchorX = int.Parse(textBox_anchorX.Text);
                anchorY = int.Parse(textBox_anchorY.Text);
                if (anchorX < 0 || anchorY < 0 || anchorX > (matrix_width - 1) || anchorY > (matrix_height - 1))
                    throw new Exception("Incorrect anchor coordinates ");

                DefineMatrix defineMatrix = new DefineMatrix();
                defineMatrix.initializeMatrix(matrix_width, matrix_height);
                defineMatrix.ShowDialog();
                Matrix = defineMatrix.Matrix;
                this.Close();
            }
            catch
            {
               MessageBox.Show("Incorrect input");
            }
            
        }

     
    }
}
