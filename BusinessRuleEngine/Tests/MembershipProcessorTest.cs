using BusinessRuleEngine.Implementation;
using BusinessRuleEngine.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngine.Tests
{
    [TestClass]
    public class MembershipProcessorTest
    {
        MembershipProcessor membershipProcessor;

        [TestInitialize]
        public void Init()
        {
            membershipProcessor = new MembershipProcessor();
        }

        [TestMethod]
        public void ProcessOrder_Success_Activate_Test()
        {
            //arrange
            Product product = new Product() { Type = "Membership", Name = "s1", action= "activate" };
            string message = "Membership is activated";
            //act
            var result = membershipProcessor.ProcessOrder(product);
            //assert
            Assert.AreEqual(message, result);
        }

        [TestMethod]
        public void ProcessOrder_Success_Upgrade_Test()
        {
            //arrange
            Product product = new Product() { Type = "Membership", Name = "s2", action = "upgrade" };
            string message = "Membership is upgraded";
            //act
            var result = membershipProcessor.ProcessOrder(product);
            //assert
            Assert.AreEqual(message, result);
        }

        [TestMethod]
        public void ProcessOrder_Error_Test()
        {
            //arrange
            Product product = new Product() { Type = "Membership" };
            string message = "some error2";
            //act
            var result = membershipProcessor.ProcessOrder(product);
            //assert
            Assert.AreEqual(message, result);
        }
    }
}
