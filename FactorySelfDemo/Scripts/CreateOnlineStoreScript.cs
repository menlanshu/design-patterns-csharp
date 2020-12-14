using FactorySelfDemo.Factory;
using FactorySelfDemo.Model;
using FactorySelfDemo.Service.Payment;
using FactorySelfDemo.Service.Shipping;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo.Scripts
{
    public class CreateOnlineStoreScript
    {
        private readonly IOnlineStoreFactory _onlineStoreFactory;

        public CreateOnlineStoreScript(IOnlineStoreFactory onlineStoreFactory)
        {
            _onlineStoreFactory = onlineStoreFactory;
        }
        public IOnlineStore Run()
        {
            Console.Write("Please key in online store name:");
            string storeName = Console.ReadLine();

            IOnlineStore onlineStore = _onlineStoreFactory.CreateStore(storeName);

            return onlineStore;
        }
    }
}
