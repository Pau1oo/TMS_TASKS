using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_ProductInventory
{
    internal class Product
    {
        string ID;
        decimal Price;
        int Count;

        public Product(string ID, decimal Price, int Count)
        {
            this.ID = ID;
            this.Price = Price;
            this.Count = Count;
        }

        public Product(string ID, decimal Price)
        {
            this.ID = ID;
            this.Price = Price;
            this.Count = 0;
        }

        public Product(string ID, int Count)
        {
            this.ID = ID;
            this.Count = Count;
            this.Price = 0;
        }

        public Product(decimal Price, int Count)
        {
            this.ID = "Неизвестно";
            this.Price = Price;
            this.Count = Count;
        }

        public Product()
        {
            this.ID = "Неизвестно";
            this.Price = 0;
            this.Count = 0;
        }
    }
}
