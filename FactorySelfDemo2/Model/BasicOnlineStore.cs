using FactorySelfDemo2.Service.Payment;
using FactorySelfDemo2.Service.Shipping;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace FactorySelfDemo2.Model
{
    public class BasicOnlineStore : IOnlineStore
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public BasicOnlineStore(string name, IPaymentService paymentService, IShippingService shippingService)
        {
            Name = name;
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public string Name { get; }
        public void OrderItem(string buyerName, string itemName)
        {
            Console.WriteLine($"{buyerName} order {itemName} in {Name} Store Start.");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // make payment for the item
            _paymentService.ProcessPayment(itemName);

            // wait payment result
            Thread.Sleep(200);

            stopwatch.Stop();
            Console.WriteLine($"Total payment service cost {stopwatch.ElapsedMilliseconds}");
            // make shipping for the item
            _shippingService.ProcessShipping(itemName);

            Console.WriteLine($"{buyerName} order {itemName} in {Name} Store Completed.");
        }
    }
}
