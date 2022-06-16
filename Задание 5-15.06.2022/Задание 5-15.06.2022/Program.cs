using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_15._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Клиент: ");
            string client = Console.ReadLine();
            Console.Write("Поставщик: ");
            string postav = Console.ReadLine();
            Console.Write("Счет: ");
            int summa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Товар: ");
            string tovar = Console.ReadLine();
            Console.Write("Количество: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Invoice invoice = new Invoice(summa, client, postav, tovar, k);
            invoice.Show();
            Console.ReadKey();
        }
    }
}
