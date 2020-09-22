using BusinessRuleEngine.Implementation;
using BusinessRuleEngine.Interface;

namespace BusinessRuleEngine.Factory
{
    public class MembershipProcessingFactory : OrderProcessingFactory
    {
        protected override IOrderProcessor GetOrderType()
        {
            IOrderProcessor order = new MembershipProcessor();
            return order;
        }
    }
}
