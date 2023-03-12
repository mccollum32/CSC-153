using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/**
* Mar 12 23
* CSC 153
* McCollum Joseph
* This program takes input from a user with an interger from 1 - 100 and writes the random number to a file
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

        private void saveFilebtn_Click(object sender, EventArgs e)
        {            
            SaveFileDialog saveFile = new SaveFileDialog();            
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            StreamWriter outputFile;
            Random rand = new Random();
            int numbers;

            if (int.TryParse(userNum.Text, out numbers) && numbers > 0)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.CreateText(saveFile.FileName);
                    //Writes random numbers to the file using a for loop
                    for (int count = 1; count <= numbers; count++)
                    {
                        int random1 = rand.Next(100) + 1;
                        outputFile.WriteLine(random1);
                    }
                    outputFile.Close();
                    MessageBox.Show(numbers + " Files have been written to \n " + saveFile.FileName);
                    userNum.Clear();
                    userNum.Focus();
                }
                else
                {
                    MessageBox.Show("Operation Cancelled!");
                    userNum.Clear();
                    userNum.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid input!\nNumbers must be 1 - 100! \nTry again!");
                userNum.Clear();
                userNum.Focus();
            }
        }
    }
}