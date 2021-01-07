using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise.Services
{
    class PaypalService : IOnlinePaymentService
    {

        public double Interest(double amount, int month)
        {
            return PaymentFee(amount + (amount * 0.01) * month);
        }

        public double PaymentFee(double amount)
        {
            return amount + (amount * 0.02);
        }
    }
}
