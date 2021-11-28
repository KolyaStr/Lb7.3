using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7._3
{
    class Article
    {
        private string product;
        private string store;
        private double price;

        public Article(string product, string store, double price)
        {
            this.product = product;
            this.store = store;
            this.price = price;
        }
        public string Article2
        {
            get { return product; }
            set { product = value; }
        }
        public string Print()
        {
            return $"Название товара - {product}\nЦена - {price}\nМагазин - {store}";
        }
    }
}
