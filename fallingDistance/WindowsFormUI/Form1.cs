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
* Mar 15 23
* CSC 153
* Mccollum Joseph
* This program accepts input from a user and calc seconds to the Falling Distance of a object. The method/functions calculate the distance formula
* distance = 1/2 "0.5" * gt2 "Gravity * time(seconds) squared"
*/

namespace WindowsFormUI
{
    public partial class Form1 : Form
    {
        private const double GRAVITY = 9.8;
        private const double DT = 0.5;

        private double FallingDistance(double seconds)
        {
            double distance = (DT) * (GRAVITY) * (Math.Pow(seconds, 2));
            return distance;
        }

        private bool IsInputValid(ref double timeSec)
        {
            bool valInput = false;

            if (double.TryParse(secBox.Text, out timeSec) && timeSec >= 0)
            {
                timeSec = Math.Round(timeSec, 2);
                secBox.Text = timeSec.ToString();
                valInput = true;
            }
            else
            {
                MessageBox.Show("Invalid input! Try again.");
                secBox.Clear();
                secBox.Focus();
            }

            return valInput;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double timeSec = 0, distance;
            if(IsInputValid(ref timeSec))
            {
                distance = Math.Round(FallingDistance(timeSec), 2);

                totalBox.Text = distance.ToString("n2");

                secBox.Focus();
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            secBox.Clear();
            secBox.Focus();
            totalBox.Clear();
        }
    }
}
