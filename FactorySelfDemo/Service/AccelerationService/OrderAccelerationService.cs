using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySelfDemo.Service.AccelerationService
{
    public class OrderAccelerationService : IOrderAccelerationService
    {
        public void AccelerateOrder(string itemName)
        {
            Console.WriteLine($"Accelerate Order for {itemName}.");
        }
    }
}
