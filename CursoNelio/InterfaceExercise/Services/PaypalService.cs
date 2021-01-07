using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise.Services
{
    class PaypalService : IOnlinePaymentService
    {


        public double Interest(double amount, int months)
        {
            throw new NotImplementedException();
        }

        public double PaymentFee(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
