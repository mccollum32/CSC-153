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
 * Feb 5 23
 * CSC 153
 * McCollum Joseph
 * This app takes user input tax and converts tax and the price output
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
            propertyLbl.Text = "";
            taxLbl.Text = "";
            totalLbl.Text = "";
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            decimal property;
            decimal total;
            decimal taxed;

            property = decimal.Parse(propertyLbl.Text);
            taxed = (property / 100) * 0.64m;
            total = property + taxed;
            
            taxLbl.Text = taxed.ToString("c");
            totalLbl.Text = total.ToString("c");
        }
    }
}
