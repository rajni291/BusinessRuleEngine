using BusinessRuleEngine.Model;


namespace BusinessRuleEngine.Interface
{
    public interface IOrderProcessor
    {
       string ProcessOrder(Product product);
    }
}
