using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_16._06._2022
{
    class Article
    {
        private string name;
        private string shop;
        private double price;
        public Article(string Name, string Shop, double Price)
        {
            name = Name;
            shop = Shop;
            price = Price;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Shop
        {
            get
            {
                return shop;
            }
            set
            {
                shop = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
