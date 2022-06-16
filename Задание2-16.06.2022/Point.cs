using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Point
    {
        private int x;
        private int y;
        private string s;
        public Point(int a, int b, string c)
        {
            x = a;
            y = b;
            s = c;
        }
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string S
        {
            get
            {
                return s;
            }
        }
    }
}
