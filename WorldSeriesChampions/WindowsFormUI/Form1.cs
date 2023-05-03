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
using ClassLibrary1;


/**
* Apr 24 2023 
* CSC 153
* Mccollum Joseph
* This program displays Baseball teams and how many times they won the World series championship
* using a while loop to loop through the files in the list and display the number of times won.
*/



namespace WrldSeriesWin
{
    public partial class Form1 : Form
    {
        
    public Form1()
        {
            InitializeComponent();
        }

        List<string> teamListWinners = new List<string>();
        List<string> timesWonList = new List<string>();

        StreamReader teamSelect = File.OpenText("Teams.txt");
        StreamReader timesWonlist = File.OpenText("WorldSeriesWinners.txt");

        string selectedTeam;

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void DisplayWinnersFile()
        {
            int count = 0;

            while (!teamSelect.EndOfStream)
            {
                teamListWinners.Add(teamSelect.ReadLine());
                listBox1.Items.Add(teamListWinners[count]);
                count++;
            }

            teamSelect.Close();
        }

        private void ReadWinners()
        {
            int count = 0;

            while (!timesWonlist.EndOfStream)
            {
                timesWonList.Add(timesWonlist.ReadLine());
                count++;
            }

            timesWonlist.Close();
        }

        private int CalculateNumberWon(string selectedTeam)
        {
            int count = 0;

            foreach (string team in timesWonList)
            {
                if (team == selectedTeam)
                {
                    count++;
                }
            }

            return count;
        }

        private void DisplayNumberWon()
        {
            int numberWon = CalculateNumberWon(selectedTeam);            
            listBox2.Items.Add(selectedTeam);
            winBox.Text = Convert.ToString(numberWon);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayWinnersFile();
            ReadWinners();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam = listBox1.SelectedItem.ToString();
            DisplayNumberWon();           
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            winBox.Clear();
        }
    }
}

