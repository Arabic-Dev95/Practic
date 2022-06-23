using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_23._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>();
                Random random = new Random();
                int CountClients = random.Next(1, 11);
                int money = 0;
                for (int i = 0; i < CountClients; i++)
                {
                    list.Add(random.Next(100, 10000));
                }
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Clear();
                    money += list[i];
                    Console.WriteLine("Клиент заплатил: " + list[i] + " $");
                    Console.WriteLine("Ваш счёт: " + money + " $");
                    Console.WriteLine("Нажмите любую клавишу чтобы продолжить...................");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("Клиентов больше нет");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
