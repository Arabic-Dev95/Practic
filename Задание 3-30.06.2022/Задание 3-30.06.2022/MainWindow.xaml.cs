using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Задание_3_30._06._2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            patients.Add(new Patient("Гусев Иван Тимурович", 20, "Ангина"));
            patients.Add(new Patient("Никольский Максим Богданович", 18, "Сколиоз"));
            patients.Add(new Patient("Щербаков Константин Кириллович", 36, "Бронхит"));
            patients.Add(new Patient("Ильин Степан Юрьевич", 29, "Грипп"));
            patients.Add(new Patient("Крылов Роман Никитич", 51, "Цирроз"));
            patients.Add(new Patient("Глушков Фёдор Матвеевич", 82, "Маразм"));
            patients.Add(new Patient("Анисимов Александр Германович", 16, "Простуда"));
            patients.Add(new Patient("Калугин Руслан Даниилович", 43, "Увечье рук"));
            patients.Add(new Patient("Иванов Денис Тимурович", 65, "Травма ноги"));
            patients.Add(new Patient("Кузнецов Владислав Даниилович", 77, "Глухота"));
            foreach(Patient patient in patients)
            {
                LB.Content += patient.FIO + " Возраст: " + patient.Age + " Заболевание: " + patient.Disease + "\n";
            }
        }
        List<Patient> patients = new List<Patient>();

        private void BSortFIO_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            patients =
                (from patient in patients
                 orderby patient.FIO
                 select patient).ToList();
            foreach (Patient patient in patients)
            {
                LB.Content += patient.FIO + " Возраст: " + patient.Age + " Заболевание: " + patient.Disease + "\n";
            }
        }

        private void BSortAge_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            patients =
                (from patient in patients
                 orderby patient.Age
                 select patient).ToList();
            foreach (Patient patient in patients)
            {
                LB.Content += patient.FIO + " Возраст: " + patient.Age + " Заболевание: " + patient.Disease + "\n";
            }
        }

        private void BSearchDisease_Click(object sender, RoutedEventArgs e)
        {


            LB.Content = "";
            var Quary =
                from patient in patients
                where patient.Disease == TB.Text
                select patient;
            foreach (Patient patient in Quary)
            {
                LB.Content += patient.FIO + " Возраст: " + patient.Age + " Заболевание: " + patient.Disease + "\n";
            }
        }
    }
}
