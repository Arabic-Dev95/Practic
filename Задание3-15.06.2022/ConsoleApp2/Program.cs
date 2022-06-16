using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd;
            double eur;
            double rub;
            Console.Write("Введите курс доллара к гривне: ");
            usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите курс евро к гривне: ");
            eur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите курс рубля к гривне: ");
            rub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Converter converter = new Converter(usd, eur, rub);
            Console.WriteLine("выберете действие:");
            Console.WriteLine("1 - перевести гривны в доллары");
            Console.WriteLine("2 - перевести гривны в евро");
            Console.WriteLine("3 - перевести гривны в рубли");
            Console.WriteLine("4 - перевести доллары в гривны");
            Console.WriteLine("5 - перевести евро в гривны");
            Console.WriteLine("6 - перевести рубли в гривны");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum;
            switch (x)
            {
                case 1:
                    Console.Write("Введите сумму в гривнах: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.UAH_USD(sum));
                    break;
                case 2:
                    Console.Write("Введите сумму в гривнах: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.UAH_EUR(sum));
                    break;
                case 3:
                    Console.Write("Введите сумму в гривнах: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.UAH_RUB(sum));
                    break;
                case 4:
                    Console.Write("Введите сумму в долларах: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.USD_UAH(sum));
                    break;
                case 5:
                    Console.Write("Введите сумму в евро: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.EUR_UAH(sum));
                    break;
                case 6:
                    Console.Write("Введите сумму в рублях: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.RUB_UAH(sum));
                    break;
            }
            Console.ReadKey();
        }
    }
}
