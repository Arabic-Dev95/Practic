using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_17._06._2022
{
    static class ColorPrint
    {

        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)Color.Blue:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case (int)Color.Red:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case (int)Color.Green:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case (int)Color.Yellow:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }
                default:
                    Console.WriteLine("Введенная Вами строка будет выведена на экран цветом по умолчанию!");
                    break;
            }

            Console.WriteLine(stroka);
        }
    }
    enum Color
    {
        Blue = 0,
        Red = 1,
        Green = 2,
        Yellow = 3
    }
}
