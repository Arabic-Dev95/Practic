using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_30._06._2022
{
    class Patient
    {
        private string fio;
        private int age;
        private string disease;
        public Patient(string s, int a, string d)
        {
            fio = s;
            age = a;
            disease = d;
        }
        public string FIO
        {
            get
            {
                return fio;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
        public string Disease
        {
            get
            {
                return disease;
            }
        }
    }
}
