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

namespace Задание_1_30._06._2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            scums.Add(new CriminalScum("Ситников Константин Константинович", 180, 65, "Русский", true));
            scums.Add(new CriminalScum("Зайцев Матвей Иванович", 174, 60, "Украинец", true));
            scums.Add(new CriminalScum("Чижов Дмитрий Яковлевич", 171, 51, "Бурят", false));
            scums.Add(new CriminalScum("Васильев Роберт Егорович", 181, 70, "Молдованин", false));
            scums.Add(new CriminalScum("Васильев Роберт Егорович", 181, 70, "Молдованин", true));
            scums.Add(new CriminalScum("Фомин Платон Саввич", 180, 67, "Поляк", true));
        }
        List<CriminalScum> scums = new List<CriminalScum>();

        private void BSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LB.Content = "";
                var Quary =
                    from CriminalScum in scums
                    where CriminalScum.Rost == Convert.ToDouble(TBrost.Text) &&
                    CriminalScum.Ves == Convert.ToDouble(TBves.Text) &&
                    CriminalScum.Naz == TBnaz.Text &&
                    !CriminalScum.Concluded
                    select CriminalScum;
                foreach (CriminalScum scum in Quary)
                {
                    LB.Content += scum.FIO + "\n" + scum.Rost + "\n" + scum.Ves + "\n" + scum.Naz + "\n";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
