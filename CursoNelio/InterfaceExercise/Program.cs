using InterfaceExercise.Entities;
using InterfaceExercise.Services;
using System;
using System.Globalization;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);          
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(num, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installments in contract.Installments)
            {
                Console.WriteLine(installments);
            }
        }
    }
}
