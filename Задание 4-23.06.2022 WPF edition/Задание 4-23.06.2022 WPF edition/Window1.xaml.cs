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
using System.Windows.Shapes;

namespace Задание_4_23._06._2022_WPF_edition
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Badd_Click(object sender, RoutedEventArgs e)
        {
            Dossiers.AddDossier(TBsn.Text + " " + TBn.Text + " " + TBo.Text, TBPost.Text);
            TBsn.Text = "";
            TBn.Text = "";
            TBo.Text = "";
            TBPost.Text = "";
            MessageBox.Show("Досье добавлено","Сообщение", MessageBoxButton.OK);
        }

        private void BClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
