using AbstractProposedExercise.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractProposedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Enter payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }

            double totalTaxes = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (TaxPayer taxPayer in taxPayers)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine(taxPayer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += tax;
            }
            
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");


            
        }
    }
}
