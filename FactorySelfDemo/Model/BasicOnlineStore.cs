using FactorySelfDemo.Service.Payment;
using FactorySelfDemo.Service.Shipping;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactorySelfDemo.Model
{
    public class BasicOnlineStore : IOnlineStore
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public string Name { get; }

        public BasicOnlineStore(string name, IPaymentService paymentService, IShippingService shippingService)
        {
            Name = name;
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public void OrderItem(string buyerName, string itemName)
        {
            Console.WriteLine($"Order start in store {Name}");

            Console.WriteLine($"{buyerName} buy a {itemName}");

            _paymentService.ProcessPayment(itemName);

            Thread.Sleep(200);

            _shippingService.ProcessShipping(itemName);

            Console.WriteLine($"{buyerName} buy {itemName} completed!"); 

        }
    }
}
