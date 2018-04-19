using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIDPrototype1TC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            
                if ((e.Column) == 1 )
                    e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.CellBounds);
                else
                    e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.CellBounds);

            if ((e.Row) == 0)
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.Snow, e.CellBounds);

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Row) == 0)
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.CellBounds);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
