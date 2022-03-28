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
        // string variable to be displayed on Display Panel
        public string currentEntry = "0"; 

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            // Font
            Font font = new Font("Microsoft Sans Serif", 30);

            // String Format
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Far;

            // Convert string variable to long to drop '0's in beginning
            long entryToLong = long.Parse(currentEntry);

            // Print current entry as a number to the screen
            e.Graphics.DrawString(entryToLong.ToString(), font, Brushes.Black, DisplayPanel.ClientRectangle, stringFormat);
        }

        // "1" Button 
        private void OneButton_Click(object sender, EventArgs e)
        {
            currentEntry += "1";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "0" Button
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            currentEntry += "0";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "2" Button 
        private void TwoButton_Click(object sender, EventArgs e)
        {
            currentEntry += "2";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "3" Button
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            currentEntry += "3";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "4" Button
        private void FourButton_Click(object sender, EventArgs e)
        {
            currentEntry += "4";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "5" Button
        private void FiveButton_Click(object sender, EventArgs e)
        {
            currentEntry += "5";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "6" Button
        private void SixButton_Click(object sender, EventArgs e)
        {
            currentEntry += "6";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "7" Button
        private void SevenButton_Click(object sender, EventArgs e)
        {
            currentEntry += "7";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "8" Button
        private void EightButton_Click(object sender, EventArgs e)
        {
            currentEntry += "8";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "9" Button
        private void NineButton_Click(object sender, EventArgs e)
        {
            currentEntry += "9";
            DisplayPanel.Invalidate(); // refresh screen to update
        }
    }
}
