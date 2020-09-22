using BusinessRuleEngine.Interface;

namespace BusinessRuleEngine.Implementation
{
    public class BookProcessor: IOrderProcessor
    {
        public string ProcessOrder()
        {
            bool result = false;
            bool packageSlipDone = this.GeneratePackingSlipForRoyalityDept();
            if (packageSlipDone)
                result = this.GenerateComission();
            return result ? "Book Order processed" : "some error";
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
