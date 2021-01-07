using InterfaceExercise.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double amount = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime installmentDate = contract.Date.AddMonths(i);
                double installmentAmount = _onlinePaymentService.Interest(amount, i);
                contract.AddInstallment(new Installment(installmentDate, installmentAmount));
            }
        }
    }
}
