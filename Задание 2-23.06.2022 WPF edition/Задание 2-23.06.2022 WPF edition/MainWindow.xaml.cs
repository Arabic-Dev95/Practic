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

namespace Задание_2_23._06._2022_WPF_edition
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            x = r.Next(1, 11);
            for(int i = 0; i < x; i++)
            {
                Clients.Add(r.Next(1000, 10000));
            }
            LBCount.Content += "" + x;
        }
        Random r = new Random();
        int x;
        int schet = 0;
        List<int> Clients = new List<int>(); 
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            B1.Content = "Следующий!";
            if (x - 1 >= 0)
            {
                LBPlata.Content = "Клиент заплатил: " + Clients[x - 1];
                schet += Clients[x - 1];
                LBSchet.Content = "Ваш счёт: " + schet;
                x--;
                LBCount.Content = "Клиентов в очереди: " + x;
            }
            else
            {
                MessageBox.Show("Клиентов больше нет!");
            }
        }
    }
}
