using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaClassLibrary1;


/**
* 5 2 23
* CSC 153
* Mccollum Joseph
* This program calculates Circle, Rectangle and Cylinder using static class overloading
*/



namespace WindowsForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox1.Text);
            double circleArea = Area.Calc(radius);
            listBox1.Items.Add(circleArea ++);


        }

        private void rectBtn_Click(object sender, EventArgs e)
        {
            double width = Convert.ToDouble(textBox2.Text);
            double length = Convert.ToDouble(textBox2.Text);
            double rectangleArea = Area.Calc(width, length);
            listBox1.Items.Add(rectangleArea ++);
            
        }

        private void cylBtn_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox3.Text);
            double height = Convert.ToDouble(textBox2.Text);
            double cylinderArea = Area.Calc(radius, height);
            listBox1.Items.Add(cylinderArea);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
