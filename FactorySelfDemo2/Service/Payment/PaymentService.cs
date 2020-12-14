using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo2.Service.Payment
{
    public class PaymentService : IPaymentService
    {
        public void ProcessPayment(string itemName)
        {
            Console.WriteLine($"Process payment for {itemName}.");
        }
    }
}
