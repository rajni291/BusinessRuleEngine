using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Model;

namespace BusinessRuleEngine.Implementation
{
    public class BookProcessor: IOrderProcessor
    {
       
        public string ProcessOrder(Product product)
        {
            bool result = false;
            bool packageSlipDone = this.GeneratePackingSlipForRoyalityDept();
            if (packageSlipDone)
                result = this.GenerateComission();
            return result ? "Book Order processed for: " + product.Name : "some error";
        }

        // this will be moved to common code later
        private bool GeneratePackingSlipForRoyalityDept()
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
