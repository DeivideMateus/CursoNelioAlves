﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageExercise.Entities
{
    class Acount
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Acount()
        {
        }

        public Acount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}