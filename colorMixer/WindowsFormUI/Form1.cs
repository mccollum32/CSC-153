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
* Feb 12 23
* CSC 153
* McCollum, Joseph
* This application mixes two colors from the choices chosen, if the same color is picked then it will
* show the same color. Using a IF/Else statement to decide what is picked. 
*/
namespace WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixBtn_Click(object sender, EventArgs e)
        {
            if(redButton.Checked && redRadio.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if(redButton.Checked && blueRadio.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if(redButton.Checked && yellowRadio.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if(blueButton.Checked && blueRadio.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if(blueButton.Checked && redRadio.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if(blueButton.Checked && yellowRadio.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if(yellowButton.Checked && yellowRadio.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else if(yellowButton.Checked && redRadio.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if(yellowButton.Checked && blueRadio.Checked)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Pick two choices not just one!");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            redButton.Checked = false;
            blueButton.Checked = false;
            yellowButton.Checked = false;
            redRadio.Checked = false;
            blueRadio.Checked = false;
            yellowRadio.Checked = false;
        }
    }
}
