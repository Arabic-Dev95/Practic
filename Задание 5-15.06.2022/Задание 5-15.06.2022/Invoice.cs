using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_15._06._2022
{
    class Invoice
    {
        private readonly int Account;
        private readonly string Customer;
        private readonly string Provider;
        private string Article;
        private int Quantity;
        public Invoice(int account, string customer, string provider, string article, int quantity)
        { 
            Account = account;
            Customer = customer;
            Provider = provider;
            Article = article;
            Quantity = quantity;
        }
        public double GetAccountWithNds(double nds = 0.3)
        {
            return Account + (Account * nds);
        }

        public void Show()
        {
            Console.WriteLine($"{Customer} заказал у {Provider} {Quantity} {Article} и выставил счет,");
            Console.WriteLine($"который будет составлять {Account} без Ндс, и {GetAccountWithNds()} с Ндс");
        }
    }
}
