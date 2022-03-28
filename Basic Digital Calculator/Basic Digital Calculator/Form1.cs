using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Digital_Calculator
{
    public partial class Form1 : Form
    {
        public long CurrentEntry = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 30);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Far;

            e.Graphics.DrawString(CurrentEntry.ToString(), font, Brushes.Black, DisplayPanel.ClientRectangle, stringFormat);
        }
    }
}
