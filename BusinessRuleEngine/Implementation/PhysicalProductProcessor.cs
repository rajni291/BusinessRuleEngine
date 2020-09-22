using BusinessRuleEngine.Interface;

namespace BusinessRuleEngine.Implementation
{
    public class PhysicalProductProcessor : IOrderProcessor
    {
        public string ProcessOrder()
        {
            bool result = false;
            bool packageSlipDone = this.GeneratePackingSlipForShipping();
            if (packageSlipDone)
                result = this.GenerateComission();
            return result ? "Physical Product Order processed" : "some error";
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
