using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Введите длинну массива: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[x];
            Console.WriteLine("Введите элементы массива(каждый элемент с новой строки):");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Исходный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            arr.Sortirovka();
            Console.Write("Отсортированный массив: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
