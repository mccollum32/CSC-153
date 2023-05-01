using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public class Employee
    {
        private string EPname;
        private int EPidNumber;
        private string _department;
        private string _position;

        public Employee(string name, int idNumber, string department, string position)
        {
            EPname = name;
            EPidNumber = idNumber;
            _department = department;
            _position = position;
        }

        public Employee(string name, int idNumber)
        {
            EPname = name;
            EPidNumber = idNumber;
            _department = "";
            _position = "";
        }

        public Employee()
        {
            EPname = "";
            EPidNumber = 0;
            _department = "";
            _position = "";
        }

        public string Name
        {
            get { return EPname; }
            set { EPname = value; }
        }

        public int IdNumber
        {
            get { return EPidNumber; }
            set { EPidNumber = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
