using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Converter
    {
        private double USD;
        private double EUR;
        private double RUB;
        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }
        public double UAH_USD(double UAH)
        {
            return UAH / USD;
        }
        public double UAH_EUR(double UAH)
        {
            return UAH / EUR;
        }
        public double UAH_RUB(double UAH)
        {
            return UAH / RUB;
        }
        public double USD_UAH(double UAH)
        {
            return UAH * USD;
        }
        public double EUR_UAH(double UAH)
        {
            return UAH * EUR;
        }
        public double RUB_UAH(double UAH)
        {
            return UAH * RUB;
        }
    }
}
