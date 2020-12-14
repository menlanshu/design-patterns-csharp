using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo.Service.Shipping
{
    public class FexedShippingService : IShippingService
    {
        public void ProcessShipping(string itemName)
        {
            Console.WriteLine($"Process Fexed shipping for {itemName}.");
        }
    }
}
