using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_30._06._2022
{
    class Stew
    {
        private string name;
        private int dateMade;
        private int srok;
        public Stew(string n, int s, int l)
        {
            name = n;
            dateMade = s;
            srok = l;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int DateMade
        {
            get
            {
                return dateMade;
            }
        }
        public int Srok
        {
            get
            {
                return srok;
            }
        }
    }
}
