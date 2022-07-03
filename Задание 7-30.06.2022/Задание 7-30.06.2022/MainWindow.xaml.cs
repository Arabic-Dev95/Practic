using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Задание_7_30._06._2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SV.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
            unit1.Add(new Solder("Ларионов Фёдор Иванович", "АК-74М", "Солдат", 5));
            unit1.Add(new Solder("Климов Марк Тимурович", "АК-74М", "Матрос", 3));
            unit1.Add(new Solder("Медведев Илья Билалович", "АК-12", "Сержант", 10));
            unit1.Add(new Solder("Блинов Михаил Егорович", "СВДМ", "Старший сержант", 12));
            unit1.Add(new Solder("Виноградов Никита Дамирович", "АКС-74У", "Солдат", 6));
            LB.Content += "Отряд №1:\n";
            foreach (Solder solder in unit1)
            {
                LB.Content += solder.FIO + " Вооружение: " + solder.Armament + " Звание: " + solder.Title + " Срок службы: " + solder.Srok + "\n";
            }
            LB.Content += "Отряд №2:\n";
        }
        List<Solder> unit1 = new List<Solder>();
        List<Solder> unit2 = new List<Solder>();

        private void BTansact_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            Regex regex = new Regex("^[Б]");
            unit2 =
                (from solder in unit1
                 where regex.IsMatch(solder.FIO)
                 select solder).ToList();
            foreach (Solder solder in unit2)
            {
                unit1.Remove(solder);
            }
            LB.Content += "Отряд №1:\n";
            foreach (Solder solder in unit1)
            {
                LB.Content += solder.FIO + " Вооружение: " + solder.Armament + " Звание: " + solder.Title + " Срок службы: " + solder.Srok + "\n";
            }
            LB.Content += "Отряд №2:\n";
            foreach (Solder solder in unit2)
            {
                LB.Content += solder.FIO + " Вооружение: " + solder.Armament + " Звание: " + solder.Title + " Срок службы: " + solder.Srok + "\n";
            }
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            unit1.Clear();
            unit2.Clear();
            unit1.Add(new Solder("Ларионов Фёдор Иванович", "АК-74М", "Солдат", 5));
            unit1.Add(new Solder("Климов Марк Тимурович", "АК-74М", "Матрос", 3));
            unit1.Add(new Solder("Медведев Илья Билалович", "АК-12", "Сержант", 10));
            unit1.Add(new Solder("Блинов Михаил Егорович", "СВДМ", "Старший сержант", 12));
            unit1.Add(new Solder("Виноградов Никита Дамирович", "АКС-74У", "Солдат", 6));
            LB.Content += "Отряд №1:\n";
            foreach (Solder solder in unit1)
            {
                LB.Content += solder.FIO + " Вооружение: " + solder.Armament + " Звание: " + solder.Title + " Срок службы: " + solder.Srok + "\n";
            }
            LB.Content += "Отряд №2:\n";
        }
    }
}
