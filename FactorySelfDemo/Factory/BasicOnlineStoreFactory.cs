using FactorySelfDemo.Model;
using FactorySelfDemo.Service.Payment;
using FactorySelfDemo.Service.Shipping;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo.Factory
{
    public class BasicOnlineStoreFactory : IOnlineStoreFactory
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public BasicOnlineStoreFactory(IPaymentService paymentService, IShippingService shippingService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public IOnlineStore CreateStore(string name)
        {
            return new BasicOnlineStore(name, _paymentService, _shippingService);
        }
    }
}
