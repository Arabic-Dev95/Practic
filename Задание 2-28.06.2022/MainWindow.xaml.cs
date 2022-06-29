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

namespace Задание_2_28._06._2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            calc = new Calc();
            switchCalc = new SwitchCalc(calc);
        }
        private Calc calc;
        private SwitchCalc switchCalc;
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            switch (CB.SelectedIndex)
            {
                case 0:
                    calc = switchCalc.Sum(TBslog1.Text, TBslog2.Text);
                    Result();
                    break;
                case 1:
                    calc = switchCalc.Diff(TBslog1.Text, TBslog2.Text);
                    Result();
                    break;
                case 2:
                    calc = switchCalc.Mult(TBslog1.Text, TBslog2.Text);
                    Result();
                    break;
                case 3:
                    calc = switchCalc.Div(TBslog1.Text, TBslog2.Text);
                    Result();
                    break;
            }
        }
        private void Result()
        {
            TBRes.Text = Convert.ToString(calc.Res);
        }
    }
}
