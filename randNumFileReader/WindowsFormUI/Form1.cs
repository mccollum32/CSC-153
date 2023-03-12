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
* This program reads the files from "Random File Writer" and displays the information in the list box
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

        private void readBtn_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            try
            {
                int num;
                int total = 0;
                int count = 0;

                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog1.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        num = int.Parse(inputFile.ReadLine());
                        listBox1.Items.Add(num);
                        total += num;
                        count++;
                    }
                    listBox1.Items.Add("Total: " + total);
                    listBox1.Items.Add("Random numbers read: " + count);
                    MessageBox.Show("Success!\nNumbers from: \n" + openFileDialog1.FileName + "\nhave been read!");
                }
                else
                {
                    MessageBox.Show("Operation Terminated!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
