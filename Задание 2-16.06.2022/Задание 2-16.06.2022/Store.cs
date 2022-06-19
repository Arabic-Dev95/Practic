using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_16._06._2022
{
    class Store
    {
        private List<Article> articles;
        public Store()
        {
            articles = new List<Article>();
        }
        public void AddArticle(Article a)
        {
            articles.Add(a);
        }
        public void ArticleIndex(int i)
        {
            if(i > 0 && i <= articles.Count)
            {
                Console.WriteLine("Название: " + articles[i - 1].Name);
                Console.WriteLine("Магазин: " + articles[i - 1].Shop);
                Console.WriteLine("Цена: " + articles[i - 1].Price);
            }
            else
            {
                Console.WriteLine("Товар не найден");
            }
        }
        public void ArticleName(string n)
        {
            int counter = 0;
            for(int i = 0; i < articles.Count; i++)
            {
                if(articles[i].Name == n)
                {
                    Console.WriteLine("Название: " + articles[i].Name);
                    Console.WriteLine("Магазин: " + articles[i].Shop);
                    Console.WriteLine("Цена: " + articles[i].Price);
                    counter++;
                }
            }
            if(counter == 0)
            {
                Console.WriteLine("Товар не найден");
            }
        }
    }
}
