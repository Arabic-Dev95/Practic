using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
            Console.Write("Введите длину прямоугольника: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите ширину прямоугольника: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Rectangle r = new Rectangle(side1, side2);
            Console.Write("Площадь прямоугольника: " + r.Area);
            Console.WriteLine();
            Console.Write("Периметр прямоугольника: " + r.Perimeter);
            Console.ReadKey();
        }
    }
}
