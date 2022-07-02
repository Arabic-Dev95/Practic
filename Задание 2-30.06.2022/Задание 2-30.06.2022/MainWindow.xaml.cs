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

namespace Задание_2_30._06._2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            scums.Add(new CriminalScum("Климов Павел Семёнович", "Антиправительственное"));
            scums.Add(new CriminalScum("Дегтярев Игорь Иванович", "Контрабанда"));
            scums.Add(new CriminalScum("Гаврилов Дмитрий Анатольевич", "Антиправительственное"));
            scums.Add(new CriminalScum("Селиванов Максим Иванович", "Незаконное пересечение границы"));
            scums.Add(new CriminalScum("Соколов Игорь Всеволодович", "Антиправительственное"));
            foreach(CriminalScum scum in scums)
            {
                LB.Content += scum.FIO + "\n" + scum.Crime + "\n";
            }
        }
        List<CriminalScum> scums = new List<CriminalScum>();
     
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LB.Content = "";
                scums = 
                    (from CriminalScum in scums
                    where CriminalScum.Crime != "Антиправительственное"
                    select CriminalScum).ToList();
                foreach (CriminalScum scum in scums)
                {                   
                    LB.Content += scum.FIO + "\n" + scum.Crime + "\n";
                }
                MessageBox.Show("Слава Арстоцке!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
