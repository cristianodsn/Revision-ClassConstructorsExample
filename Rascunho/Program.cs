﻿using System;
using System.Globalization;

namespace Rascunho
{
    class Program
    {      
        static void Main(string[] args)
        {
            Product product;
            Console.WriteLine("Enter the product's data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            product = new Product { Name = name, Price = price, Quantity = quantity };
            Console.WriteLine("Product data: " + product);

            Console.Write("Enter the number of product to be added to the stock: ");
            product.AddProduct(int.Parse(Console.ReadLine()));
            Console.WriteLine("Update: " + product);

            Console.Write("Enter the number of product to be removed from the stock: ");
            product.RemoveProduct(int.Parse(Console.ReadLine()));
            Console.WriteLine("Update data: " + product);

            Console.ReadKey();
        }      

    }
}
