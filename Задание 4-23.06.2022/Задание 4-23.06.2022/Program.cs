using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_23._06._2022
{
    class Program
    {
        static List<string> fio = new List<string>();
        static List<string> post = new List<string>();
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Выберете действие:");
                    Console.WriteLine("1 - добавить досье");
                    Console.WriteLine("2 - вывести все досье");
                    Console.WriteLine("3 - удалить досье");
                    Console.WriteLine("4 - поиск по фамилии");
                    Console.WriteLine("5 - выход");
                    int x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            AddDossier();
                            break;
                        case 2:
                            WriteDossier();
                            break;
                        case 3:
                            DeleteDossier();
                            break;
                        case 4:
                            SearchDossier();
                            break;
                        case 5:
                            flag = false;
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void AddDossier()
        {
            Console.Write("Введите фамилию, имя и отчество: ");
            string s = Console.ReadLine();
            Console.Write("Введите должность: ");
            string c = Console.ReadLine();
            fio.Add(s);
            post.Add(c);
        }
        public static void WriteDossier()
        {
            for(int i = 0; i < fio.Count; i++)
            {
                Console.WriteLine((i + 1) + ". ФИО - " + fio[i] + " Должность - " + post[i]);
            }
        }
        public static void DeleteDossier()
        {
            Console.Write("Введите номер досье: ");
            int i = Convert.ToInt32(Console.ReadLine());
            fio.RemoveAt(i - 1);
            post.RemoveAt(i - 1);
        }
        public static void SearchDossier()
        {
            Console.Write("Введите фамилию: ");
            string s = Console.ReadLine();
            for(int i = 0; i < fio.Count; i++)
            {
                if (fio[i].Contains(s))
                {
                    Console.WriteLine((i + 1) + ". ФИО - " + fio[i] + " Должность - " + post[i]);
                }
            }
        }
    }
}
