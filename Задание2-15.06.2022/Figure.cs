using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Figure
    {
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4; 
        private Point p5;
        public Figure(Point P1, Point P2, Point P3)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
        }
        public Figure(Point P1, Point P2, Point P3, Point P4)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
            p4 = P4;
        }
        public Figure(Point P1, Point P2, Point P3, Point P4, Point P5)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
            p4 = P4;
            p5 = P5;
        }
        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public void Name()
        {
            if (p4 == null)
            {
                Console.WriteLine("Многоугольник " + p1.S + p2.S + p3.S);
            }
            else
            {
                if (p5 == null)
                {
                    Console.WriteLine("Многоугольник " + p1.S + p2.S + p3.S + p4.S);
                }
                else
                {
                    Console.WriteLine("Многоугольник " + p1.S + p2.S + p3.S + p4.S + p5.S);
                }
            }
        }
        public void PerimeterCalculator()
        {
            double res;
            if (p4 == null)
            {
                res = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p1);
            }
            else
            {
                if(p5 == null)
                {
                    res = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p1);
                }
                else
                {
                    res = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1);
                }
            }
            Console.WriteLine("Периметр многоугольника: " + res);
        }
    }
}
