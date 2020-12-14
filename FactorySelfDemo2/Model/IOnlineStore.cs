namespace FactorySelfDemo2.Model
{
    public interface IOnlineStore
    {
        string Name { get; }

        void OrderItem(string buyerName, string itemName);
    }
}