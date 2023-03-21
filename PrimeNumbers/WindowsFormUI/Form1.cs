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
        private int numbers;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValid(ref int numbers)
        {
            bool valid = false;
            if (int.TryParse(primeBox.Text, out numbers) && numbers >= 0)
            {
                valid = true;
            }
            else
            {
                MessageBox.Show("Enter a valid input! Try again");
                primeBox.Focus();
                primeBox.Clear();
            }
            return valid;
        }
        private bool Prime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (IsValid(ref numbers))
            {
                if (Prime(numbers) && numbers != 0 && numbers != 1)
                {
                    MessageBox.Show("Number entered is prime!");
                    primeBox.Clear();
                    primeBox.Focus();
                }
                else
                {
                    MessageBox.Show("Number entered not prime. Try again!");
                    primeBox.Clear();
                    primeBox.Focus();
                }
            }
        }
    }
}