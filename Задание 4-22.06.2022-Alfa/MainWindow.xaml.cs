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

namespace Задание_4_22._06._2022
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CP_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            LB1.Content = CP.SelectedColorText;
            SolidColorBrush solidColorBrush = new SolidColorBrush();
            solidColorBrush.Color = CP.SelectedColor.Value;
            LB1.Background = solidColorBrush;
        }
    }
}
