using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 19 Jan 23
 * CSC 153
 * McCollum, Joseph
 * Final output should show names in this format:
Ms. Kelly Jane Smith
Kelly Jane Smith 
Kelly Smith
Smith, Kelly Jane, Ms.
Smith, Kelly Jane
Smith, Kelly
 */

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exits and ends the program
            this.Close();
        }

        private void clearName_Click(object sender, EventArgs e)
        {
            //Clears the application and focuses on the Title name
            firstName.Text = " ";
            midName.Text = " ";
            lastName.Text = " ";
            nameTitle.Text = " ";
            nameTitle.Focus();
        }

        private void outPut_Click(object sender, EventArgs e)
        {
            //Name output formatted 
            string output , output2, output3, output4, output5, output6;
            output = $"{nameTitle.Text}. {firstName.Text} {midName.Text} {lastName.Text}";
            output2 = $"{firstName.Text} {midName.Text} {lastName.Text}";
            output3 = $"{firstName.Text} {lastName.Text}";
            output4 = $"{lastName.Text}, {firstName.Text} {midName.Text}, {nameTitle.Text}.";
            output5 = $"{lastName.Text}, {firstName.Text} {midName.Text}";
            output6 = $"{lastName.Text}, {firstName.Text}";
            MessageBox.Show(string.Format($"{output}\n {output2}\n {output3}\n {output4}\n {output5}\n {output6}"));
        }

       
    }
}
