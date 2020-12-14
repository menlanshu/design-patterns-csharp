using AbstractFactorySelfDemo2.Services.ProductReader;
using AbstractFactorySelfDemo2.Services.ProductWriter;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySelfDemo2.Services.AbstractFactory
{
    public class InMemoryProductCommunicatorAbstractFactory : IProductCommunicatorAbstractFactory
    {
        public IProductReader CreateProductReader()
        {
            return new InMemoryReader();
        }

        public IProductWriter CreateProductWriter()
        {
            return new InMemoryWriter();
        }
    }
}
