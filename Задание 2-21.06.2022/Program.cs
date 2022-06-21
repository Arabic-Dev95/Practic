using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_2_21._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool c = true;
                StreamWriter sw = new StreamWriter("file.txt");
                Console.WriteLine("Введите данные для записи в файл:");
                while (c)
                {
                    sw.WriteLine(Console.ReadLine());
                    Console.WriteLine("Продолжить? (y/n)");
                    string s = Console.ReadLine();
                    switch (s)
                    {
                        case "y":
                            break;
                        case "n":
                            c = false;
                            break;
                    }
                }
                sw.Close();
                Console.Clear();
                StreamReader sr = new StreamReader("file.txt");
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                Console.ReadKey();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
}
