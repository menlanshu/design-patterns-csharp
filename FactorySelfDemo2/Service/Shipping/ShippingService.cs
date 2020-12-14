using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo2.Service.Shipping
{
    public class ShippingService : IShippingService
    {
        public void ProcessShipping(string itemName)
        {
            Console.WriteLine($"Process shipping for {itemName}.");
        }
    }
}
