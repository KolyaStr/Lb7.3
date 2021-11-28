using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7._3
{
    class Store
    {
        Article[] article = new Article[3];

        public Store()
        {
            article[0] = new Article("телефон", "Эльдорадо", 7500);
            article[1] = new Article("ноутбук", "Цитрус", 22000);
            article[2] = new Article("телевизор", "Фокстрот", 15000);
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < article.Length)
                {
                    return article[index].Print();
                }
                else
                    return "Пока что столько товаров у нас нету.";
            }

        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                {
                    if (article[i].Article2 == index)
                    {
                        return article[i].Print();
                    }

                }
                return $"{index} - пока что такого товара нету";
            }
        }

    }
}
