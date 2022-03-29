using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Basic_Digital_Calculator
{
    public partial class Form1 : Form
    {       
        public string currentEntry = "0"; // string variable to be displayed on Display Panel
        public string firstEntry; // variable to store first entry before clearing for second entry

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            // Font
            Font font = new Font("Microsoft Sans Serif", 26);

            // String Format
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Far;

            // Number Format
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 0;
            nfi.NegativeSign = "-";
            nfi.NumberNegativePattern = 1;
            nfi.NumberGroupSeparator = "";

            // Convert string variable to double to drop '0's in beginning
            double entryToDub = double.Parse(currentEntry, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowTrailingSign, nfi);

            // Display decimal digits
            if (currentEntry.IndexOf(".") != -1)
            {
                int decimaldigits = currentEntry.Substring(currentEntry.IndexOf(".")).Length;
                nfi.NumberDecimalDigits = decimaldigits - 1;
            }

            // Print current entry as a number to the screen
            e.Graphics.DrawString(entryToDub.ToString("N", nfi), font, Brushes.Black, DisplayPanel.ClientRectangle, stringFormat);
            
        }

        // "1" Button 
        private void OneButton_Click(object sender, EventArgs e)
        {
            if(currentEntry.Length < 16)
                currentEntry += "1";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "0" Button
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 16)
                currentEntry += "0";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "2" Button 
        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 16)
                currentEntry += "2";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "3" Button
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 16)
                currentEntry += "3";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "4" Button
        private void FourButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 16)
                currentEntry += "4";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "5" Button
        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 16)
                currentEntry += "5";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "6" Button
        private void SixButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 16)
                currentEntry += "6";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "7" Button
        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 16)
                currentEntry += "7";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "8" Button
        private void EightButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 16)
                currentEntry += "8";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "9" Button
        private void NineButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 16)
                currentEntry += "9";
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "+/-" Button
        private void NegateButton_Click(object sender, EventArgs e)
        {           
            if (currentEntry[0] == '-') // Check if number is negative
                currentEntry = currentEntry.Remove(0, 1); // remove negative symbol, if negative
            else
                currentEntry = "-" + currentEntry; // add negative symbol, if positive
            DisplayPanel.Invalidate(); // refresh screen to update
        }

        // "." Button
        private void PeriodButton_Click(object sender, EventArgs e)
        {
            if (currentEntry.Length < 19)
                currentEntry += ".";
            DisplayPanel.Invalidate(); // refresh screen to update
        }
    }
}
