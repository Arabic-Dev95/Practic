using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            Console.Write("Введите количество точек: ");
            f = Convert.ToInt32(Console.ReadLine());
            List<Point> points = new List<Point>();
            Console.WriteLine();
            int x;
            int y;
            string s;
            for(int i = 0; i < f; i++)
            {
                Console.Write("Введите координату по оси Х: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите координату по оси Y: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите название точки: ");
                s = Console.ReadLine();
                Console.WriteLine();
                points.Add(new Point(x, y, s));
            }
            Figure figure = null;
            if(points.Count == 3)
            {
                figure = new Figure(points[0], points[1], points[2]);
            }
            else
            {
                if (points.Count == 4)
                {
                    figure = new Figure(points[0], points[1], points[2], points[3]);
                }
                else
                {
                    if (points.Count == 5)
                    {
                        figure = new Figure(points[0], points[1], points[2], points[3],points[4]);
                    }
                }
            }
            figure.Name();
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
