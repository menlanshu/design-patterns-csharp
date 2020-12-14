using FactorySelfDemo.Factory;
using FactorySelfDemo.Model;
using FactorySelfDemo.Scripts;
using FactorySelfDemo.Service.Payment;
using FactorySelfDemo.Service.Shipping;
using System;

namespace FactorySelfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // if write by yourself?
            // Design:
            // Service:
            // PaymentService - IPaymentService, BasicPaymentService
            // ShippingService - IShippingService, FedexShippingService, UPSShippingService
            // AccerlerationService - IAccelerationService, OrderAccelerationService

            // Model:
            // OnlineStore - IOnlineStore, OnlineStore, FastOnlineStore
            // Factory - IOnlineStoreFactory

            // Scripts:
            // OnlineStoreCreateScripts
            // OnlineStoreUpdateScripts

            IPaymentService paymentService = new BasicPaymentService();
            IShippingService shippingService = new FexedShippingService();
            IOnlineStoreFactory onlineStoreFactory = new BasicOnlineStoreFactory(paymentService, shippingService);

            CreateOnlineStoreScript onlineStoreScript = new CreateOnlineStoreScript(onlineStoreFactory);

            IOnlineStore onlineStore = onlineStoreScript.Run();

            onlineStore.OrderItem("Long", "iPad");
        }
    }
}
