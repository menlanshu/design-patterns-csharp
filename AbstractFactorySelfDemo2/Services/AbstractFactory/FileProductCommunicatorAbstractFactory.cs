using AbstractFactorySelfDemo2.Services.ProductReader;
using AbstractFactorySelfDemo2.Services.ProductWriter;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySelfDemo2.Services.AbstractFactory
{
    public class FileProductCommunicatorAbstractFactory : IProductCommunicatorAbstractFactory
    {
        private readonly string _fileName;

        public FileProductCommunicatorAbstractFactory(string fileName)
        {
            _fileName = fileName;
        }

        public IProductWriter CreateProductWriter()
        {
            return new FileProductWriter(_fileName);
        }

        public IProductReader CreateProductReader()
        {
            return new FileProductReader(_fileName);
        }
    }
}
