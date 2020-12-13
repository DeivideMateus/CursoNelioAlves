﻿using AccountExercise.Entities;
using AccountExercise.Entities.Exceptions;
using System;
using System.Globalization;

namespace AccountExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, limit);
                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.Write("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(WithdrawException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            

        }
    }
}
