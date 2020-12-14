using System;

namespace Factory.Services.Accelerators
{
    public class OrderAccelerationService : IOrderAccelerationService
    {
        public void AccelerateOrder()
        {
            Console.WriteLine("Accelerating order.");
        }
    }
}