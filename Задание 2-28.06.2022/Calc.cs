using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_28._06._2022
{
    class Calc
    {
        private double s1;
        private double s2;
        private double res;
        public double S1
        {
            set
            {
                s1 = value;
            }
            get
            {
                return s1;
            }
        }
        public double S2
        {
            set
            {
                s2 = value;
            }
            get
            {
                return s2;
            }
        }
        public double Res
        {
            get
            {
                return res;
            }
        }
        public void Sum()
        {
            res = s1 + s2;
        }
        public void Diff()
        {
            res = s1 - s2;
        }
        public void Mult()
        {
            res = s1 * s2;
        }
        public void Div()
        {
            res = s1 / s2;
        }
    }
}
