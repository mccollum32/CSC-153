using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaClassLibrary1
{
    public static class Area
    {
        public static double Calc(double radius)
        {
            return (Math.PI * radius * radius);
        }

        public static double Calc(int width, int length)
        {
            return (width * length);
        }

        public static double Calc(double radius, double height)
        {
            return (Math.PI * radius * radius * height);
        }
    }
}
