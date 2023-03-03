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
* 3 Mar 23
* CSC 153
* McCollum Joseph
* This program uses a For Loop to calculate the number of days after a user has inputted the number of days
* for each number of days the penny amount increases by 2
*/



namespace WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dayBox.Text = "";
            listResults.Items.Clear();
            dayBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int payDays;

            const double PENNIES = 0.01;
            

            if (int.TryParse(dayBox.Text, out payDays) && payDays >= 1)
            {
                double pay = PENNIES;

                for (int day = 1; day <= payDays; day++)
                {
                    listResults.Items.Add("Pay after day " + day + "," + " Susan has made: " + pay.ToString("c"));
                    pay += pay;
                }
            }
            else
            {
                MessageBox.Show("Invalid input try again.");

            }
        }
    }
}
