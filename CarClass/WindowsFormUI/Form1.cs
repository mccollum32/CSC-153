using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLibrary;

/**
* 4 29 23
* CSC 153
* Mccollum Joseph
* This program uses a Car class library to calculate the speed of a car and the brake speed of a vehicle
* the acceleration button speeds it by 5 and the brake button decreases it by 5
*/



namespace CarClass
{
    public partial class Form1 : Form
    {

        Car vehicleCar = new Car();
        
        public Form1()
        {
            InitializeComponent();
        }
    

        private void accBtn_Click(object sender, EventArgs e)
        {
            vehicleCar.Acceleration();

            carBox.Text = "Vehicle sped up (accelerated) "  + vehicleCar.CarYear + " " + vehicleCar.CarMake + " "
                + vehicleCar.CarModel + " is " + vehicleCar.CarSpeed + " mph.";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            carBox.Clear();
        }

        private void brkBtn_Click(object sender, EventArgs e)
        {
            vehicleCar.Brake();            

            carBox.Text = "braking (slowing down) " + vehicleCar.CarYear + " " + vehicleCar.CarMake + " "
                + vehicleCar.CarModel + " is " + vehicleCar.CarSpeed + " mph.";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
