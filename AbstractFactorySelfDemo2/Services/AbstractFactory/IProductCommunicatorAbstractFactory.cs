using AbstractFactorySelfDemo2.Services.ProductReader;
using AbstractFactorySelfDemo2.Services.ProductWriter;

namespace AbstractFactorySelfDemo2.Services.AbstractFactory
{
    public interface IProductCommunicatorAbstractFactory
    {
        IProductReader CreateProductReader();
        IProductWriter CreateProductWriter();
    }
}