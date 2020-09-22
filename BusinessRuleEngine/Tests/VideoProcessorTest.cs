using BusinessRuleEngine.Implementation;
using BusinessRuleEngine.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngine.Tests
{
    [TestClass]
    public class VideoProcessorTest
    {
        VideoProcessor videoProcessor;

        [TestInitialize]
        public void Init()
        {
            videoProcessor = new VideoProcessor();
        }

        [TestMethod]
        public void ProcessOrder_Success_Test()
        {
            //arrange
            Product product = new Product() { Type = "Video", Name = "Learning to Ski" };
            string message = "Video Order processed for: Learning to Ski";
            //act
            var result = videoProcessor.ProcessOrder(product);
            //assert
            Assert.AreEqual(message, result);
        }

        [TestMethod]
        public void ProcessOrder_Error_Test()
        {
            //arrange
            Product product = new Product() { Type = "Video" };
            string message = "some error";
            //act
            var result = videoProcessor.ProcessOrder(product);
            //assert
            Assert.AreEqual(message, result);
        }
    }
}
