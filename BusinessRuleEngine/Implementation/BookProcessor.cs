using BusinessRuleEngine.Interface;

namespace BusinessRuleEngine.Implementation
{
    public class BookProcessor: IOrderProcessor
    {
        public string ProcessOrder()
        {
            bool result = false;
            bool packageSlipDone = this.GeneratePackaginSlip();
            if (packageSlipDone)
                result = this.GenerateComission();
            return result ? "Book Order processed" : "some error";
        }

        private bool GeneratePackaginSlip()
        {
            //some logic
            return true;
        }

        private bool GenerateComission()
        {
            //some logic
            return true;
        }
    }
}
