using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeClassLibrary;


/**
* 4 30 223
* CSC 153
* Mccollum Joseph
* This program genereates employee information into each text field with Employee Name , ID Number , Position and feild of work
*/

namespace EmployeeClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee employee1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
        Employee employee2 = new Employee("Mark Jones", 39119, "IT", "Programmer");
        Employee employee3 = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = employee1.Name + " " + employee1.IdNumber + " " + employee1.Department + " " + employee1.Position;
            textBox2.Text = employee2.Name + " " + employee2.IdNumber + " " + employee2.Department + " " + employee2.Position;
            textBox3.Text = employee3.Name + " " + employee3.IdNumber + " " + employee3.Department + " " + employee3.Position;
        }
    }
}