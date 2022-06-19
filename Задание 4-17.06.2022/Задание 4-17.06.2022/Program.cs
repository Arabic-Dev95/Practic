using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_17._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество часов: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберете должность");
            Console.WriteLine("1 - JuniorDeveloper");
            Console.WriteLine("2 - MiddleDeveloper");
            Console.WriteLine("3 - SeniorDeveloper");
            Console.WriteLine("4 - QualityAssuranceEngineers");
            Console.WriteLine("5 - ChiefTechnologyOfficer");
            Console.WriteLine("6 - ChiefExecutiveOfficer");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {

                case 1:
                    if (Accauntant.AskForBonus(Employees.JuniorDeveloper, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 2:
                    if (Accauntant.AskForBonus(Employees.MiddleDeveloper, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 3:
                    if (Accauntant.AskForBonus(Employees.SeniorDeveloper, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 4:
                    if (Accauntant.AskForBonus(Employees.QualityAssuranceEngineers, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 5:
                    if (Accauntant.AskForBonus(Employees.ChiefTechnologyOfficer, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 6:
                    if (Accauntant.AskForBonus(Employees.ChiefExecutiveOfficer, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                default:
                    Console.WriteLine("Такого сотрудника нет");
                    break;

            }

            Console.ReadKey();
        }
    }
}
