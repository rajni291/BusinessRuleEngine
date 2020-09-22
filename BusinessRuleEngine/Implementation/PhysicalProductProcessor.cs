using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Model;

namespace BusinessRuleEngine.Implementation
{
    public class PhysicalProductProcessor : IOrderProcessor
    {
        public string ProcessOrder(Product product)
        {
            bool result = false;
            bool packageSlipDone = this.GeneratePackingSlipForShipping();
            if (packageSlipDone)
                result = this.GenerateComission();
            return result ? "PhysicalProduct Order processed for: " + product.Name : "some error";
        }

        // this will be moved to common code later
        private bool GeneratePackingSlipForShipping()
        {
            //some logic
            return true;
        }

        // this will be moved to common code later
        private bool GenerateComission()
        {
            //some logic
            return true;
        }
    }
}
