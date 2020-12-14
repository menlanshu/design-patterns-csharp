using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo.Service.Shipping
{
    public class UPSShippingService : IShippingService
    {
        public void ProcessShipping(string itemName)
        {
            Console.WriteLine($"Process UPS shipping for {itemName}.");
        }
    }
}
