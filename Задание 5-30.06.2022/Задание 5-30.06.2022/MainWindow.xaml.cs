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

namespace Задание_5_30._06._2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            stews.Add(new Stew("Тушёнка №1", 2020, 2021));
            stews.Add(new Stew("Тушёнка №2", 2019, 2021));
            stews.Add(new Stew("Тушёнка №3", 2021, 2022));
            stews.Add(new Stew("Тушёнка №4", 2018, 2020));
            stews.Add(new Stew("Тушёнка №5", 2019, 2022));
            foreach (Stew stew in stews)
            {
                LB.Content += stew.Name + " Дата изготовдения: " + stew.DateMade + " Годен до: " + stew.Srok + "\n";
            }
        }
        List<Stew> stews = new List<Stew>();
        private void BSearch_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            int year = DateTime.Now.Year;
            var Quary =
                from stew in stews
                where stew.Srok < year
                select stew;
            foreach (Stew stew in Quary)
            {
                LB.Content += stew.Name + " Дата изготовдения: " + stew.DateMade + " Годен до: " + stew.Srok + "\n";
            }
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
            foreach (Stew stew in stews)
            {
                LB.Content += stew.Name + " Дата изготовдения: " + stew.DateMade + " Годен до: " + stew.Srok + "\n";
            }
        }
    }
}
