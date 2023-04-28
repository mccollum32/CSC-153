using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;


/**
* 4 27 23
* CSC 153
* Mccollum Joseph
* This program randomly selects an image and displays the amount won/earned and displays how much was entered
* in the slot machine
*/

namespace SlotMachines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int randomNo1, randomNo2, randomNo3;

        double amountIn;
        double amountWon;
        double totalIn = 0.00;
        double total = 0.00;


        private void closeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You inserted: $" + totalIn.ToString("n2") + "\n\n" + "You won: $" + total.ToString("n2"));
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string input = amntEntBox.Text;

            if (IsInputValid(input))
            {
                randomNo1 = rand.Next(10);
                randomNo2 = rand.Next(10);
                randomNo3 = rand.Next(10);

                pictureBox1.Image = imagelist1.Images[randomNo1];
                pictureBox2.Image = imagelist1.Images[randomNo2];
                pictureBox3.Image = imagelist1.Images[randomNo3];

                WL(randomNo1, randomNo2, randomNo3);

                resetIMG();

                amntEntBox.Clear();
                amntEntBox.Focus();
            }
        }

        private bool IsInputValid(string str)
        {
            bool isValid = false;

            try
            {
                amountIn = double.Parse(str);

                if (amountIn > 0.00)
                {
                    isValid = true;
                    totalIn += amountIn;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a dollar amount greater than 0.00.");
            }

            return isValid;
        }

        

        private void WL(int num1, int num2, int num3)
        {
            amountWon = 0;

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                MessageBox.Show("You have won $0.00");
            }
            else if (num1 == num2 && num1 != num3)
            {
                amountWon = amountIn * 2;
                total += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
            else if (num1 != num2 && num1 == num3)
            {
                amountWon = amountIn * 2;
                total += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
            else if (num1 != num2 && num2 == num3)
            {
                amountWon = amountIn * 2;
                total += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
            else if (num1 == num2 && num1 == num3)
            {
                amountWon = amountIn * 3;
                total += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
        }

        private void resetIMG()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
        }


    }

}
