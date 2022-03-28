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
        // variable 
        public string currentEntry = "0"; 

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

            long entryToLong = long.Parse(currentEntry);
            e.Graphics.DrawString(entryToLong.ToString(), font, Brushes.Black, DisplayPanel.ClientRectangle, stringFormat);
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            currentEntry += "1";
            DisplayPanel.Invalidate();
        }
    }
}
