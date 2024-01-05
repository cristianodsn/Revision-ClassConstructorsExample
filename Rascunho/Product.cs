using System;
using System.Globalization;

namespace Rascunho
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product(string name, double price, int quantyti)
        {
            Name = name;
            Price = price;
            Quantity = quantyti;
        }

        public double TotalInStock()
        {
            return Quantity * Price;
        }

        public void AddProduct(int p)
        {
            Quantity += p;
        }

        public void RemoveProduct(int p)
        {
            Quantity -= p;
        }

        public override string ToString()
        {
            return $"{Name}, $ {Price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $", {Quantity} units, total: $ {TotalInStock().ToString("F2", CultureInfo.InvariantCulture)}"; 
        }

    }
}
