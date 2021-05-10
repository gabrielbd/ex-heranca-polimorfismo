using ExHerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>();
            Console.Write("Enter the number of products :");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.WriteLine("");
                Console.WriteLine("1 - Common");
                Console.WriteLine("2 - Used");
                Console.WriteLine("3 - Imported");
                Console.Write("Enter the number for the product type :");
                int type = int.Parse(Console.ReadLine());
                Console.Write("Product name :");
                string name = Console.ReadLine();
                Console.Write("Product Price :");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (type == 1)
                {
                    list.Add(new Product(name, price));
                    Console.WriteLine("");
                }
                else if (type == 2)
                {
                    Console.Write("Manufacture date (DD/MM/YYYY) :");
                    DateTime manufacturedate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacturedate));
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("Customs Fee :");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS: ");


            foreach (Product lista in list )
            {
              Console.WriteLine(lista.PriceTag());
            }
        }
    }
}
