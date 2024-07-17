using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_ProductInventory
{
    public class Product
    {
        public string ID;
        public decimal Price;
        public int Quantity;

        public Product(string ID, decimal Price, int Quantity)
        {
            this.ID = ID;
            this.Price = Price;
            this.Quantity = Quantity;
        }
        public Product(string ID) : this(ID, 0, 0) { }
        public Product(decimal Price) : this("Неизвестно", Price, 0) { }
        public Product(int Quantity) : this("Неизвестно", 0, Quantity) { }
        public Product(string ID, decimal Price) : this(ID, Price, 0) { }
        public Product(string ID, int Quantity) : this(ID, 0, Quantity) { }
        public Product(decimal Price, int Quantity) : this("Неизвестно", Price, Quantity) { }
        public Product() : this("Неизвестно", 0, 0) { }
    }
}
