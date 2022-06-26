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

namespace Задание_4_23._06._2022_WPF_edition
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
       
        public void WriteDossier()
        {
            LBRes.Content = "";
            for (int i = 0; i < Dossiers.fio.Count; i++)
            {
                LBRes.Content += (i + 1) + ". ФИО - " + Dossiers.fio[i] + " Должность - " + Dossiers.post[i] + "\n";
            }
        }

        public void SearchDossier(string s)
        {
            LBRes.Content = "";
            bool flag = false;
            for (int i = 0; i < Dossiers.fio.Count; i++)
            {
                if (Dossiers.fio[i].Contains(s))
                {
                    flag = true;
                    LBRes.Content += (i + 1) + ". ФИО - " + Dossiers.fio[i] + " Должность - " + Dossiers.post[i] + "\n";
                }
            }
            if(flag == false)
            {
                LBRes.Content = "404";
            }
        }

        private void BPrint_Click(object sender, RoutedEventArgs e)
        {
            WriteDossier();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
            WriteDossier();
        }

        private void BSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchDossier(TB.Text);
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dossiers.DeleteDossier(Convert.ToInt32(TBD.Text));
                WriteDossier();
            }
            catch
            {
                MessageBox.Show("Не удалось удалить досье");
            }
        }
    }     
}
