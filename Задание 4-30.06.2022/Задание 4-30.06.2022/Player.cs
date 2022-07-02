using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_30._06._2022
{
    class Player
    {
        private string name;
        private int strong;
        private int lvl;
        public Player(string n, int s, int l)
        {
            name = n;
            strong = s;
            lvl = l;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Strong
        {
            get
            {
                return strong;
            }
        }
        public int Lvl
        {
            get
            {
                return lvl;
            }
        }
    }
}
