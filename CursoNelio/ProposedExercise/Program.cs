using ProposedExercise.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProposedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>(); 

            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used ou imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if(ch == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product pr in list)
            {
                Console.WriteLine(pr.PriceTag());
            }
        }
    }
}
