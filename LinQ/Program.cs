using System;
using System.Collections.Generic;
using System.Linq;
using System.LinQ;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() {IDictioanry = 1, Price = 1},
                new Product() {IDictioanry = 1, Price = 2},
                new Product() {IDictioanry = 1, Price = 33},
                new Product() {IDictioanry = 1, Price = 4},
                new Product() {IDictioanry = 1, Price = 6},
                new Product() {IDictioanry = 1, Price = 2},
            };

            Console.WriteLine("Average: {0}",products.Average(p => p.Price));
            Console.WriteLine("Median: {0}",products.Median(p => p.Price));
            Console.WriteLine("Moda: {0}",products.Moda(p => p.Price));
            Console.WriteLine("Contraty Moda: {0}",products.ContraryModa(p => p.Price));
        }

        private class Product
        {
            public int IDictioanry { get; set; }
            public int Price { get; set; }
        }
    }
}