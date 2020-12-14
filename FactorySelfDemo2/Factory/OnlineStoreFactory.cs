using FactorySelfDemo2.Model;
using FactorySelfDemo2.Service.Payment;
using FactorySelfDemo2.Service.Shipping;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo2.Factory
{
    public class OnlineStoreFactory : IOnlineStoreFactory
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public OnlineStoreFactory(IPaymentService paymentService, IShippingService shippingService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public IOnlineStore CreateOnlineStore(string storeName)
        {
            return new BasicOnlineStore(storeName, _paymentService, _shippingService);
        }
    }
}
