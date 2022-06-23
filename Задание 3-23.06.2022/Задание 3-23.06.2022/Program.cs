using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_23._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            List<int> list = new List<int>();
            Console.WriteLine("Вводите числа или команды с новой строки");
            while (flag)
            {
                string s = Console.ReadLine();
                if(s == "sum")
                {
                    Console.WriteLine(list.Sum());
                }
                else
                {
                    if(s == "exit")
                    {
                        flag = false;
                    }
                    else
                    {
                        try
                        {
                            list.Add(Convert.ToInt32(s));
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
