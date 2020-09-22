using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Model;
using System;

namespace BusinessRuleEngine.Implementation
{
    public class MembershipProcessor : IOrderProcessor
    {
        public string ProcessOrder(Product product)
        {
           
            string memberStatus = this.ProcessMembership(product); 
            if(memberStatus != null)
            {
                if (product.action == "activate")
                    return "Membership is activated";
                else if (product.action == "upgrade")
                    return "Membership is upgraded";
                else
                    return "some error1";
            }
            return "some error2";
        }

        private string ProcessMembership(Product product)
        {
            switch (product.action)
            {
                case "activate":
                    return this.ActivateMember();
                case "upgrade":
                    return this.UpgradeMember();                  
                default:
                    return null;
            }
        }

        private string UpgradeMember()
        {
            this.NotifyUser();
            return "Upgraded";
        }

        private string NotifyUser()
        {
            return "Email Sent";
        }

        private string ActivateMember()
        {
            return "Activated";
        }
    }
}
