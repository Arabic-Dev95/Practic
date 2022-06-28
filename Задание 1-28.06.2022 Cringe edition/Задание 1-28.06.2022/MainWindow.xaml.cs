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

namespace Задание_1_28._06._2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            secundomer = new Secundomer();
            switchClass = new SwitchClass(secundomer);
            flag = false;
            LB.Content = "00:00:00";
        }
        private Secundomer secundomer;
        private SwitchClass switchClass;
        private bool flag;
        private void BStart_Stop_Click(object sender, RoutedEventArgs e)
        {
            if (!flag)
            {
                secundomer = switchClass.Start();
                secundomer.Update += Update;
                flag = true;
                BStart_Stop.Content = "Стоп";
            }
            else
            {
                secundomer = switchClass.Stop();
                flag = false;
                BStart_Stop.Content = "Старт";
            }
        }
        private void Update(string s)
        {
            LB.Content = s;
        }

        private void BReset_Click(object sender, RoutedEventArgs e)
        {
            secundomer = switchClass.Reset();
            BStart_Stop.Content = "Старт";
            flag = false;
            LB.Content = "00:00:00";
        }
    }
}
