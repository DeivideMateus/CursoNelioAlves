using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfaceExercise.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime date, double amount)
        {
            DueDate = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - " 
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
