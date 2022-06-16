using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1._1
{
    class Rectangle
    {
        private double side1;
        private double side2;
        public Rectangle(double Side1, double Side2)
        {
            side1 = Side1;
            side2 = Side2;
        }
        private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator()
        {
            return (side1 * 2) + (side2 * 2);
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
}
