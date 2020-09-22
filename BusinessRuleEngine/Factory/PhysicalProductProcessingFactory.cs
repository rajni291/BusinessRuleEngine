using BusinessRuleEngine.Implementation;
using BusinessRuleEngine.Interface;

namespace BusinessRuleEngine.Factory
{
    public class PhysicalProductProcessingFactory : OrderProcessingFactory
    {
        protected override IOrderProcessor GetOrderType()
        {
            IOrderProcessor order = new PhysicalProductProcessor();
            return order;
        }
    }
}
