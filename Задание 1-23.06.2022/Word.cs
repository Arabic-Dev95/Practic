using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_23._06._2022
{
    class Word
    {
        private string word_;
        private string meaning_;
        public Word(string w, string m)
        {
            word_ = w;
            meaning_ = m;
        }
        public string word
        {
            get
            {
                return word_;
            }
            set
            {
                word_ = value;
            }
        }
        public string Meaning
        {
            get
            {
                return meaning_;
            }
            set
            {
                meaning_ = value;
            }
        }
    }
}
