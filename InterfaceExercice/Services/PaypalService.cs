using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercice.Services
{
    internal class PaypalService: IPaymentService
    {
        private const double FeePercentage= 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFees(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
