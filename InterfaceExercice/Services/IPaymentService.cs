using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercice.Services
{
    internal interface IPaymentService
    {
        public double Interest(double amount, int months);

        public double PaymentFees(double amount);

    }
}
