using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_30._06._2022
{
    class CriminalScum
    {
        private string fio;
        private string crime;
        public CriminalScum(string s, string n)
        {
            fio = s;
            crime = n;
        }
        public string FIO
        {
            get
            {
                return fio;
            }
        }
        public string Crime
        {
            get
            {
                return crime;
            }
        }
    }
}
