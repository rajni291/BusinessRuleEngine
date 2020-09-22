using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Model;

namespace BusinessRuleEngine.Implementation
{
    public class VideoProcessor : IOrderProcessor
    {
        public string ProcessOrder(Product product)
        {
            bool result = false;
            bool packageSlipDone = this.GeneratePackingSlipForShipping();
            if (packageSlipDone)
                result = this.GeneratePackingSlipForShipping();
            return result ? "Physical Product Order processed" : "some error";
        }

        // this will be moved to common code later
        private bool GeneratePackingSlipForShipping()
        {
            //some logic
            return true;
        }

    }
}
