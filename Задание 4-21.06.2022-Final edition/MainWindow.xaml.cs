using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
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
using System.IO;


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
        IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (isoStore.FileExists("1.txt"))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("1.txt", FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        string s = reader.ReadLine();
                        Color color = (Color)ColorConverter.ConvertFromString(s);
                        CP.SelectedColor = color;
                    }
                }
            }      
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {            
            using(IsolatedStorageFileStream stream = new IsolatedStorageFileStream("1.txt", FileMode.OpenOrCreate, isoStore))
            {
                using(StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(CP.SelectedColor.Value);
                }
            }
            
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
