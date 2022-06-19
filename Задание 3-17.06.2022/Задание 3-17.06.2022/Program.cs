using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_17._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Укажите цвет: (0 - синий, 1 - красный, 2 - зелёный, 3 - жёлтый)");
            int color = Convert.ToInt32(Console.ReadLine());
            ColorPrint.Print(stroka, color);
            Console.ReadKey();
        }
    }
}
