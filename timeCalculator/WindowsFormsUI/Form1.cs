using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* Feb 28 23
* CSC 153
* McCollum Joseph
* This program takes a user input and converts seconds, hours, or days and shows what it is equal to  
*/

namespace WindowsFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            timeBox.Text = "";
            resultBox.Text = "";
            timeBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            int timeSec;

            if (int.TryParse(timeBox.Text, out timeSec) && timeSec >= 60)
            {
                const double secondMin = 60.0;
                const double hourMin = 3600.0;
                const double dayMin = 86400.0;

                if (timeSec >= secondMin && timeSec < hourMin)
                {
                    double clockMin = timeSec / secondMin;
                    resultBox.Text = (timeSec + " seconds is the same as " + clockMin.ToString("n2") + " minutes");

                }
                else if (timeSec >= hourMin && timeSec < dayMin)
                {
                    double clockHour = timeSec / hourMin;
                    resultBox.Text = (timeSec + " seconds is the same as " + clockHour.ToString("n2") + " hours");

                }
                else if (timeSec >= dayMin)
                {
                    double clockDay = timeSec / dayMin;
                    resultBox.Text = (timeSec + " seconds is the same as " + clockDay.ToString("n2") + " days");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number not a string and greater than or equal to 60!");
            }
        }
               
    }
}
