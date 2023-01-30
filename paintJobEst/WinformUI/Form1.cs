using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Jan 29 23
 * CSC 153
 * McCollum, Joseph
 * This application allows the user to enter SQ feet of wallspace and the price per gallon
 * The program will output Gall of paint/Hours of labor/Cost/Labor charge/Total the paint job
 */


namespace WinformUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //This function closes the program
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Empty strings to clear the GUI output
            paintGall.Text = "";
            sqWall.Text = "";
            ppGal.Text = "";
            laborHours.Text = "";
            paintCost.Text = "";
            totalBox.Text = "";
            laborCharge.Text = "";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            decimal sqft;
            decimal gall;
            decimal gallNeed;
            decimal laborNeed;
            decimal costpaint;
            decimal laborCharges;
            decimal totalPrice;
            
            //Converting the decimal to a string output
            sqft = decimal.Parse(sqWall.Text);
            gall = decimal.Parse(ppGal.Text);
            
            //Math calculation
            gallNeed = sqft / 115;
            laborNeed = (sqft * 8) / 115;
            costpaint = (sqft * gall) / 115;
            laborCharges = laborNeed * 20;
            totalPrice = laborCharges + costpaint;

            //Formatting string output 2 decimal places
            paintGall.Text = gallNeed.ToString("n2");
            laborHours.Text = laborNeed.ToString("n2");
            paintCost.Text = costpaint.ToString("c2");
            laborCharge.Text = laborCharges.ToString("c2");
            totalBox.Text = totalPrice.ToString("c2");

        }
    }
}
