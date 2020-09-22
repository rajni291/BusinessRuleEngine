using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Model;

namespace BusinessRuleEngine.Implementation
{
    public class VideoProcessor : IOrderProcessor
    {
        public string ProcessOrder(Product product)
        {
            bool packageSlipDone = this.GeneratePackingSlipForShipping(product);
            return packageSlipDone ? "Video Order processed for: " + product.Name : "some error";
        }

        // this will be moved to common code later
        private bool GeneratePackingSlipForShipping(Product product )
        {
            if (product.Name == null)
                return false;
            if(product.Name == "Learning to Ski")
            {
                var FirstAidProduct = new Product
                {
                    Type = "Video",
                    Name = "First Aid"
                };
                this.GeneratePackingSlipForShipping(FirstAidProduct);

            }
            return true;
        }

    }
}
