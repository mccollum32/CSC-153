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
* 6 Mar 23
* CSC 153
* MccollumJoseph
* This program takes input from a users guess to match with the random number using a counter to show how many tries it took the 
* user to guess it.
*/


namespace WindowsFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int randomTry;
        int counter = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            randomTry = rand.Next(100) + 1;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            
            int guess;

            if (int.TryParse(guessBox.Text, out guess) && (guess >= 1 && guess <= 100))
            {
                counter += 1;

                if (guess == randomTry)
                {
                    listBox1.Items.Add("Correct! You guessed: " + counter + " times");
                    guessBox.Text = "";
                    guessBox.Focus();
                    counter = 0;
                }
                else if (guess > randomTry)
                {
                    listBox1.Items.Add("Your guess is too high! Try again. " + "\n" + counter);
                    guessBox.Text = "";
                    guessBox.Focus();
                }
                else
                {
                    listBox1.Items.Add("Your guess is too low! Try again. " + "\n" + counter);
                    guessBox.Text = "";
                    guessBox.Focus();
                }

            }
            else
            {
                MessageBox.Show("Please enter an integer in the range 1-100.");
                listBox1.Items.Clear();
                guessBox.Text = "";
                guessBox.Focus();
                counter = 0;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            guessBox.Text = "";
            listBox1.Items.Clear();
            guessBox.Focus();
            counter = 0;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}
