using FactorySelfDemo2.Factory;
using FactorySelfDemo2.Model;
using FactorySelfDemo2.Scripts;
using FactorySelfDemo2.Service.Payment;
using FactorySelfDemo2.Service.Shipping;
using System;

namespace FactorySelfDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Design
            // Model:
            // OnlineStore - IOnlineStore, BasicOnlineStore


            // Service
            // PaymentService
            // ShippingService
            // AccelerationService

            // factory!! for dependency inversion implmentation
            IPaymentService paymentService = new PaymentService();
            IShippingService shippingService = new ShippingService();

            IOnlineStoreFactory onlineStoreFactory = new OnlineStoreFactory(paymentService, shippingService);

            CreateOnlineStoreScript createOnlineStoreScript = new CreateOnlineStoreScript(onlineStoreFactory);

            IOnlineStore onlineStore = createOnlineStoreScript.Run();
            onlineStore.OrderItem("Long", "iPad");
            
        }
    }
}
