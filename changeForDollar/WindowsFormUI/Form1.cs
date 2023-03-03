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
* Feb 17 23
* CSC 153
* McCollum Joseph
* The purpose of this program is to take intput from a user 
* and convert it into currency format and equal up to a $1
* using IF/Else format
*/



namespace WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The clear button to clear the output and focus on the penny box
        private void clearBtn_Click(object sender, EventArgs e)
        {
            pennyBox.Text = "";
            nickelBox.Text = "";
            dimeBox.Text = "";
            qtrBox.Text = "";
            pennyBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            //Integer input for the text box to convert the Int output
            int pennies, nickels, dimes, qtrs;
            pennies = Convert.ToInt32(pennyBox.Text);
            nickels = Convert.ToInt32(nickelBox.Text);
            dimes = Convert.ToInt32(dimeBox.Text);
            qtrs = Convert.ToInt32(qtrBox.Text);
            
            //Calculate the total coins inputted by the user
            const double penny = 0.01;
            const double nickel = 0.05;
            const double dime = 0.10;
            const double quater = 0.25;
            const double dollar = 1.00;

            double pennyTotal = pennies * penny;
            double nickelsTotal = nickels * nickel;
            double dimeTotal = dimes * dime;
            double quaterTotal = qtrs * quater;
            double totalChange = pennyTotal + nickelsTotal + dimeTotal + quaterTotal;

            //IF/Else statement using ToString format to format the currency output
            if(totalChange == dollar)
            {
                MessageBox.Show("You Win! You have entered " + totalChange.ToString("c"));              
            }
            else if (totalChange <= dollar)
            {
                MessageBox.Show("Incorrect Amount! Your amount " + totalChange.ToString("c") + "is less!");
            }
            else if (totalChange >= dollar)
            {
                MessageBox.Show("Incorrect Amount! Your amount " + totalChange.ToString("c") + " is more!");
            }
            else
            {
                MessageBox.Show("Invalid entry try again!");
            }
     

        }
    }
}
