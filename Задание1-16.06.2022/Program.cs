using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            int c;
            Console.Write("Введите количество строк: ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Введите количество столбцов: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            MyMatrix matrix = new MyMatrix(s, c);
            Console.WriteLine("Введите элементы матрицы(каждый элемент с новой строки):");
            matrix.SetElement();
            Console.WriteLine();
            matrix.Matrix();
            Console.WriteLine();
            matrix.UpStrings(10);
            matrix.Matrix();
            Console.WriteLine();
            matrix.UpColumns(10);
            matrix.Matrix();
            Console.WriteLine();
            matrix.UpStringsAndColumns(2, 3);
            matrix.Matrix();
            Console.ReadKey();
        }
    }
}
