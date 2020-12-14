using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo.Service.Payment
{
    public class BasicPaymentService : IPaymentService
    {
        public void ProcessPayment(string itemName)
        {
            Console.WriteLine($"Process payment for {itemName}.");
        }
    }
}
