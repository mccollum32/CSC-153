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
* 16 Mar 23
* CSC 153
* Mccollum Joseph 
* This program takes input from the user and converts that through the private bool method/function then calculates the total, the fees
* and the number of days spent in the hospital from three seperate methods to calculate the total.
*/


namespace WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const double DAYRATE = 350;

        private int daysIn = 0;
        private double medication = 0;
        private double surgery = 0;
        private double labratory = 0;
        private double rehabphys = 0;

        private bool IsInputValid(ref int daysIn, ref double medication, ref double surgery, ref double labratory, ref double rehabphys)
        {
            bool isValid = false;
            if (int.TryParse(daysText.Text, out daysIn) && daysIn >= 0)
            {
                if (double.TryParse(medCharge.Text, out medication) && medication >= 0)
                {
                    if (double.TryParse(surgChar.Text, out surgery) && surgery >= 0)
                    {
                        if (double.TryParse(labFee.Text, out labratory) && labratory >= 0)
                        {
                            if (double.TryParse(rehabCha.Text, out rehabphys) && rehabphys >= 0)
                            {
                                isValid = true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid input for Rehab Fees. Please try again!");
                                rehabCha.Clear();                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input for Labwork Fees. Please try again!");
                            labFee.Clear();                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for Surgery Fees. Please try again!");
                        surgChar.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for Medication Fees. Please try again!");
                    medCharge.Clear();
                }
            }
            else
            {
                MessageBox.Show("Invalid input for Days spent in hospital. Please try again!");
                daysText.Clear();
            }

            return isValid;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            daysText.Clear();
            medCharge.Clear();
            surgChar.Clear();
            labFee.Clear();
            rehabCha.Clear();
            totalBox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (IsInputValid(ref daysIn, ref medication, ref surgery, ref labratory, ref rehabphys))
            {
                totalBox.Text = CalcTotalCharges().ToString("c");
            }
        }
        
        private double CalcStayCharge(int daysIn)
        {
            return daysIn * DAYRATE;
        }

        private double CalcMiscCharges()
        {
            return medication + surgery + labratory + rehabphys;
        }

        private double CalcTotalCharges()
        {
            return CalcStayCharge(daysIn) + CalcMiscCharges();
        }
    }
}
