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
* Mar 20 23
* CSC 153
* Mccollum Joseph
* This program uses a bool method/ for loop to calculate where the number a user entered is prime or not
*/


namespace WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            primeBox.Clear();
            primeBox.Focus();
        }

        private bool IsPrime(int PrimeNum)
        {
            //int PrimeNum;
            int notPrime;

            for (int primed = 1; primed < PrimeNum; primed++)
            {
                PrimeNum++;
            }
            return false;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            IsPrime(5);
        }
    }
}
