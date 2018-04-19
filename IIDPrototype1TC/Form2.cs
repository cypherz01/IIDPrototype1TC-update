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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

            if ((e.Column) == 1)
                e.Graphics.FillRectangle(Brushes.DarkGray, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.Gray, e.CellBounds);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    } 
}
