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

namespace Задание_3_23._06._2022_WPF_edition
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<int> Nums = new List<int>();
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Nums.Add(Convert.ToInt32(TBNum.Text));
                TBNum.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BSum_Click(object sender, RoutedEventArgs e)
        {
            LB.Content += "Сумма: " + Nums.Sum() + "\n";
        }

        private void BRaz_Click(object sender, RoutedEventArgs e)
        {
            int res = 0;
            for(int i = 1; i == Nums.Count; i++)
            {
                res += Nums[i - 1] - Nums[i];
            }
            LB.Content += "Разность: " + res + "\n";
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            LB.Content = "";
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
