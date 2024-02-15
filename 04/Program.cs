using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 999.99m);
            Product product2 = new Product("Smartphone", 499.99m);
            Product product3 = new Product("Headphones", 49.99m);

            Console.WriteLine("Product Details:");
            DisplayProductDetails(product1);
            DisplayProductDetails(product2);
            DisplayProductDetails(product3);

            Console.ReadKey();
        }

        static void DisplayProductDetails(Product product)
        {
            Console.WriteLine($"Product Name: {product.ProductName}");
            Console.WriteLine($"Price: ${product.Price}");
            Console.WriteLine();
        }
    }
}
