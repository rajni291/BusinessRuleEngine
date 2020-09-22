

using BusinessRuleEngine.Implementation;
using BusinessRuleEngine.Interface;

namespace BusinessRuleEngine.Factory
{
    public class BookProcessingFactory: OrderProcessingFactory
    {
        protected override IOrderProcessor GetOrderType()
        {
            IOrderProcessor order = new BookProcessor();
            return order;
        }
    }
}
