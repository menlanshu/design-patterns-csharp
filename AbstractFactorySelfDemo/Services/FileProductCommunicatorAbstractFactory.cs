using AbstractFactorySelfDemo.Services.ProductReaders;
using AbstractFactorySelfDemo.Services.ProductWriters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySelfDemo.Services
{
    public class FileProductCommunicatorAbstractFactory : IProductCommunicatorAbstractFactory
    {
        private readonly string _fileName;

        public FileProductCommunicatorAbstractFactory(string fileName)
        {
            _fileName = fileName;
        }

        public IProductReader CreateProductReader()
        {
            return new FileProductReader(_fileName);
        }

        public IProductWriter CreateProductWriter()
        {
            return new FileProductWriter(_fileName);
        }
    }
}
