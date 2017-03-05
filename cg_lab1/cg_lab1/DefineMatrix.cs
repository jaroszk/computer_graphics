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
    public partial class DefineMatrix : Form
    {
        List<List<TextBox>> txtMatrix;
        public List<List<int>> Matrix;

        public DefineMatrix()
        {
            InitializeComponent();
        }
        public void initializeMatrix(int columnCount, int rowCount)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;

            txtMatrix = new List<List<TextBox>>();
            List<TextBox> temp = null;
            for (int x = 0; x < columnCount; x++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                temp = new List<TextBox>();
                for (int y = 0; y < rowCount; y++)
                {
                    
                    if (x == 0)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }
                    TextBox txt = new TextBox();
                    txt.Width = 35;
                    tableLayoutPanel1.Controls.Add(txt, x, y);
                    temp.Add(txt);
                }
                txtMatrix.Add(temp);
            }
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Button ok_button = new Button();
            ok_button.Text = "OK";
            ok_button.Width = 35;
            ok_button.UseVisualStyleBackColor = true;
            tableLayoutPanel1.Controls.Add(ok_button);
            ok_button.Click += new System.EventHandler(ok_button_Click);
        }
        private void ok_button_Click(object sender, EventArgs e)
        {
            Matrix = new List<List<int>>();
            List<int> temp = null;
            try
            {
                foreach (List<TextBox> list in txtMatrix)
                {
                    temp = new List<int>();
                    foreach (TextBox txt in list)
                        temp.Add(int.Parse(txt.Text));
                    Matrix.Add(temp);
                }
            }
            catch
            {
                MessageBox.Show("Incorrect input");
            }

            MessageBox.Show("Custom filter defined");
            this.Close();
        }
    }
}
