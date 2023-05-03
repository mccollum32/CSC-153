using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Class1
    {
        private int year;
        private string model;
        private string make;
        private double speed;

        public void Car(int year, string make, string model)
        {
            CarYear = year;
            CarMake = make;
            CarModel = model;
            CarSpeed = 0;
        }

        public int CarYear
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public string CarMake
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        public double CarSpeed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public string CarModel
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public void Acceleration()
        {
            CarSpeed += 5;
        }

        public void Brake()
        {
            if (CarSpeed - 5 < 0)
            {
                CarSpeed = 0;
            }
            else
            {
                CarSpeed -= 5;
            }
        }

        
    }
}