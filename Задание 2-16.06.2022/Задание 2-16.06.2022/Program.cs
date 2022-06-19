using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_16._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            bool AddMode = true;
            while (AddMode)
            {
                try
                {
                    Console.Write("Введите название товара: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите название магазина: ");
                    string storeName = Console.ReadLine();
                    Console.Write("Введите стоимость товара: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Article article = new Article(name, storeName, price);
                    store.AddArticle(article);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                ConsoleKeyInfo answer = new ConsoleKeyInfo();
                while (answer.Key != ConsoleKey.Y)
                {
                    if (answer.Key == ConsoleKey.N)
                    {
                        AddMode = false;
                        break;
                    }

                    Console.Write("Добавить еще один товар? (y - да, n - нет): ");
                    answer = Console.ReadKey();
                    Console.WriteLine();
                }
            }
            Console.Write("Введите индекс товара для поиска: ");
            int Findindex = Convert.ToInt32(Console.ReadLine());
            store.ArticleIndex(Findindex);
            Console.Write("Введите название товара для поиска: ");
            string Findname = Console.ReadLine();
            store.ArticleName(Findname);
            Console.ReadKey();
        }
    }
}
