using FactorySelfDemo2.Factory;
using FactorySelfDemo2.Model;
using FactorySelfDemo2.Service.Payment;
using FactorySelfDemo2.Service.Shipping;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo2.Scripts
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
            Console.Write($"Please key in the store name:");
            string storeName = Console.ReadLine();

            IOnlineStore onlineStore = _onlineStoreFactory.CreateOnlineStore(storeName);

            return onlineStore;

        }
    }
}
