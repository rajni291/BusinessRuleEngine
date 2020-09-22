using BusinessRuleEngine.Implementation;
using BusinessRuleEngine.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngine.Tests
{
    [TestClass]
    public class BookProcessorTest
    {
        BookProcessor bookProcessor;

        [TestInitialize]
        public void Init()
        {
            bookProcessor = new BookProcessor();
        }

        [TestMethod]
        public void ProcessOrder_Success_Test()
        {
            //arrange
            Product product = new Product() { Type = "Book", Name = "Book1" };
            string message = "Book Order processed for: Book1";
            //act
            var result = bookProcessor.ProcessOrder(product);
            //assert
            Assert.AreEqual(message, result);

        }
    }
}
