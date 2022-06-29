using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Задание_2_28._06._2022
{
    class SwitchCalc
    {
        private Calc calc;
        public SwitchCalc(Calc c)
        {
            calc = c;
        }
        public Calc Sum(string s1, string s2)
        {
            try
            {
                double S1 = Convert.ToDouble(s1);
                double S2 = Convert.ToDouble(s2);
                S1 = Math.Round(S1, 2);
                S2 = Math.Round(S2, 2);
                calc.S1 = S1;
                calc.S2 = S2;
                calc.Sum();
                return calc;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return calc;
            }
        }
        public Calc Diff(string s1, string s2)
        {
            try
            {
                double S1 = Convert.ToDouble(s1);
                double S2 = Convert.ToDouble(s2);
                S1 = Math.Round(S1, 2);
                S2 = Math.Round(S2, 2);
                calc.S1 = S1;
                calc.S2 = S2;
                calc.Diff();
                return calc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return calc;
            }
        }
        public Calc Mult(string s1, string s2)
        {
            try
            {
                double S1 = Convert.ToDouble(s1);
                double S2 = Convert.ToDouble(s2);
                S1 = Math.Round(S1, 2);
                S2 = Math.Round(S2, 2);
                calc.S1 = S1;
                calc.S2 = S2;
                calc.Mult();
                return calc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return calc;
            }
        }
        public Calc Div(string s1, string s2)
        {
            try
            {
                double S1 = Convert.ToDouble(s1);
                double S2 = Convert.ToDouble(s2);
                if (S2 == 0)
                {
                    MessageBox.Show("На нуль делить нельзя!");
                    return calc;
                }
                else
                {
                    S1 = Math.Round(S1, 2);
                    S2 = Math.Round(S2, 2);
                    calc.S1 = S1;
                    calc.S2 = S2;
                    calc.Div();
                    return calc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return calc;
            }
        }
    }
}
