using BusinessRuleEngine.Interface;

namespace BusinessRuleEngine.Factory
{
    public abstract class OrderProcessingFactory
    {
        protected abstract IOrderProcessor GetOrderType();
        public IOrderProcessor CreateOrder()
        {
            return this.GetOrderType();
        }
    }
}
