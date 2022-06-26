using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_23._06._2022_WPF_edition
{
    static class Dossiers
    {
        public static List<string> fio = new List<string>();
        public static List<string> post = new List<string>();
        public static void AddDossier(string s, string c)
        {
            fio.Add(s);
            post.Add(c);
        }
        public static void DeleteDossier(int i)
        {
            fio.RemoveAt(i - 1);
            post.RemoveAt(i - 1);
        }
        
    }
}
