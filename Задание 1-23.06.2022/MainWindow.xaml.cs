using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Задание_1_23._06._2022
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
        List<Word> words = new List<Word>();
        private void BSearch_Click(object sender, RoutedEventArgs e)
        {
            string search = TBSearch.Text;
            for(int i = 0; i < words.Count; i++)
            {
                if(Levenshtein(search, words[i].word) == 0)
                {
                    LBResult.Content += words[i].Meaning + "\n";
                }
                else
                {
                    if (Levenshtein(search, words[i].word) < 3)
                    {
                        LBResult.Content += "Возможно вы имели ввиду:\n";
                        LBResult.Content += words[i].word + " - \n";
                        LBResult.Content += words[i].Meaning + "\n";
                    }
                }               
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            words.Add(new Word("Когараси", "Это слово, которое описывает холодный зимний ветер. Данное явление позволяет узнать о наступлении зимы."));
            words.Add(new Word("Celtis", "Слово celtis, означает, судя по контексту(в греческом, и в еврейском тексте Библии), какой-то инструмент для резьбы по камню, например «резец» или «долото». Слово celtis не встречается, кроме перевода Библии, ни в одном античном тексте;"));
            words.Add(new Word("Жамевю", "Термин, близкий к психиатрии, антоним дежавю. При жамевю вы находитесь в привычной обстановке или обстоятельствах, в которых неоднократно раньше были, но чувствуете, будто оказались тут впервые."));
            words.Add(new Word("Юрисдикция", "Спектр полномочий, которым обладает государственный орган или структура."));
            words.Add(new Word("Неврастения", "Психогенное заболевание из группы неврозов, основные проявления — раздражительность, слабость."));
            words.Add(new Word("Интроспекция", "Метод познания психических явлений путем самонаблюдения человека, т.е. внимательного изучения самим человеком того, что происходит в его сознании при решении разного рода задач."));
            words.Add(new Word("Хапкидо", "Корейское боевое искусство, на появление которого во многом оказала влияние техника, положенная и в основу айкидо, Дайто-рю Айки-дзюдзюцу. "));
            words.Add(new Word("Лэхвей", "Древнее боевое искусство из Мьянмы. Летхвей считается одним из самых жестоких видов спорта в мире, потому что удары головой разрешены, а борьба ведется голыми руками."));
            words.Add(new Word("Куреш", "Традиционный вид спорта у тюркских народов, национальная борьба на поясах. У башкир, татар и чувашей кураш является важным элементом национальных праздников"));
            words.Add(new Word("Канабо", "Оружие самураев феодальной Японии, разновидность тэцубо в виде металлической палицы с круглой рукоятью, имеющей утолщение с кольцом на конце, и, зачастую, дополненной небольшими незаточенными шипами."));
            words.Add(new Word("Басту", "Небольшие деревянные дома, типичные для скандинавских стран - традиционные шведские бани, известные с глубокой древности."));
            words.Add(new Word("Гардарйки", "Норманнское название Руси, известное в Северной Европе в Средние века, в том числе в скандинавских сагах."));
            words.Add(new Word("Преторианцы ", "Личная стража императора в Римской империи."));
            words.Add(new Word("Benyvirus", "Род патогенных для растений вирусов из монотипного семейства Benyviridae, которое не включают в какой-либо из известных порядков вирусов."));
            words.Add(new Word("Ebolavirus", "Род вирусов из семейства филовирусов (Filoviridae), вызывающих геморрагическую лихорадку Эбола у высших приматов."));
            words.Add(new Word("Сакура", "Японская окультуренная вишня, цветущая пышными розовыми цветами; один из символов Японии. Собирательное название 11 видов и нескольких сортов деревьев подсемейства Сливовые"));
            words.Add(new Word("Катана", "Длинный японский меч (дайто:). По форме клинка катана напоминает шашку, однако рукоять у неё прямая и длинная, что позволяет использовать двуручный хват. Навершие отсутствует. Небольшой изгиб клинка и острый конец позволяют наносить также и колющие удары."));
            words.Add(new Word("Отпуск", "Технологический процесс, заключающийся в термической обработке закалённого на мартенсит сплава или металла, при которой основными процессами являются распад мартенсита, а также полигонизация и рекристаллизация."));
            words.Add(new Word("Карасунокути", "Трещина в клинке. Если трещина проходит примерно в параллельной плоскости, она делит закалённую и незакалённую части, и если это отражается на форме, то меч становится бракованным."));
            words.Add(new Word("Кэндзюцу", "Японское искусство владения мечом. Зародилось около 1200 лет тому назад с появлением класса воинов."));
            SV.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
        }
        private int Levenshtein(string a, string b)
        {
            if (string.IsNullOrEmpty(a))
            {
                if (!string.IsNullOrEmpty(b))
                {
                    return b.Length;
                }
                return 0;
            }

            if (string.IsNullOrEmpty(b))
            {
                if (!string.IsNullOrEmpty(a))
                {
                    return a.Length;
                }
                return 0;
            }
            int cost;
            int[,] d = new int[a.Length + 1, b.Length + 1];
            int min1;
            int min2;
            int min3;
            for (int i = 0; i <= d.GetUpperBound(0); i += 1)
            {
                d[i, 0] = i;
            }
            for (int i = 0; i <= d.GetUpperBound(1); i += 1)
            {
                d[0, i] = i;
            }
            for (int i = 1; i <= d.GetUpperBound(0); i += 1)
            {
                for (int j = 1; j <= d.GetUpperBound(1); j += 1)
                {
                    cost = Convert.ToInt32(!(a[i - 1] == b[j - 1]));

                    min1 = d[i - 1, j] + 1;
                    min2 = d[i, j - 1] + 1;
                    min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                }
            }
            return d[d.GetUpperBound(0), d.GetUpperBound(1)];
        }
    }
}
