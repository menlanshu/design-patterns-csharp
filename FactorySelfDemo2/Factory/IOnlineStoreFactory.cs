using FactorySelfDemo2.Model;

namespace FactorySelfDemo2.Factory
{
    public interface IOnlineStoreFactory
    {
        IOnlineStore CreateOnlineStore(string storeName);
    }
}