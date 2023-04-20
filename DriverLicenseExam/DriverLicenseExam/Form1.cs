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
* 4/19/23
* CSC 153
* Mccollum, Joseph
* This program reads through a text file of answers given by the student and checks the Array of correct answers
* then prints the incorrect ones on the listbox. 
* The anserKey attached can be changed to check whether it will print out the incorrect answers.
*/



namespace DriverLicenseExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            fileBox.Clear();
            resultLBL.Clear();
            fileBox.Focus();
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            string[] answerList = {
                "B","D","A","A","C",
                "A","B","A", "C","D",
                "B","C","D","A","D",
                "C","C","B","D","A"};

            string[] studentANS = new string[20];
            List<string> IncorrectANS = new List<string>();

            int count = 0, index = 0, number = 0;
            try
            {
                string fileName = fileBox.Text;
                StreamReader inputFile = File.OpenText(fileName);
                while (!inputFile.EndOfStream)
                {
                    studentANS[index] = inputFile.ReadLine();

                    if (studentANS[index] == answerList[index])
                        count++;
                    else
                    {
                        number = index + 1;
                        IncorrectANS.Add(number.ToString());
                    }
                    index++;
                }
                inputFile.Close();

                if (count >= 15)
                {
                    resultLBL.Text = "You Passed!";
                }
                else
                {
                    resultLBL.Text = "You Failed! Take the test again!";
                }
                foreach (string str in IncorrectANS)
                {
                    listBox.Items.Add(str);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No File Found, Try Again!");
                fileBox.Clear();
                fileBox.Focus();

            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}