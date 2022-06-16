using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Employee em = new Employee(name, surname);
            Worker(em);
            Console.ReadKey();
        }
        static void Worker(Employee emp)
        {
            Console.WriteLine("Выберите должность:");
            Console.WriteLine("1 - Программист");
            Console.WriteLine("2 - Тестировщик");
            Console.WriteLine("3 - Инженер");
            switch (Console.ReadLine())
            {
                case "1":
                    emp.post = "Программист";
                    break;
                case "2":
                    emp.post = "Тестировщик";
                    break;
                case "3":
                    emp.post = "Инженер";
                    break;
            }

            Console.Write("Введите стаж: ");
            emp.exp = Convert.ToInt32(Console.ReadLine());

            double zp = 0;

            if (emp.post == "Программист")
                zp = 50000;
            else if (emp.post == "Тестировщик")
                zp = 40000;
            else if (emp.post == "Инженер")
                zp = 60000;

            Console.WriteLine("Информация о сотруднике:");
            Console.WriteLine("Имя - " + emp.name);
            Console.WriteLine("Фамилия - " + emp.surname);
            Console.WriteLine("Должность - " + emp.post);
            Console.WriteLine("Оклад - " + zp);
            Console.WriteLine("Сбор - " + zp * 0.14);
        }
    }
}
