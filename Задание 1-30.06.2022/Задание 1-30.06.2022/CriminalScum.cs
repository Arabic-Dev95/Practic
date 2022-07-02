using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_30._06._2022
{
    class CriminalScum
    {
        private string fio;
        private double rost;
        private double ves;
        private string naz;
        private bool concluded;
        public CriminalScum(string s, double r, double v, string n, bool c)
        {
            fio = s;
            rost = r;
            ves = v;
            naz = n;
            concluded = c;
        }
        public string FIO
        {
            get
            {
                return fio;
            }
        }
        public double Rost
        {
            get
            {
                return rost;
            }
        }
        public double Ves
        {
            get
            {
                return ves;
            }
        }
        public string Naz
        {
            get
            {
                return naz;
            }
        }
        public bool Concluded
        {
            get
            {
                return concluded;
            }
        }
    }
}
