using InterfaceExercice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercice.Services
{
    internal class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <=  months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota =  basicQuota + _paymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _paymentService.PaymentFees(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
                
            }
        }
    }
}
