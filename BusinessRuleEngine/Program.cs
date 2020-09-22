using BusinessRuleEngine.Factory;
using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderProcessor bookOrder = new BookProcessingFactory().CreateOrder();
            if(bookOrder != null)
            {
                var order = new Product
                {
                    Type = "Book",
                    Name = "Book1"
                };
                Console.WriteLine("Order Status:" + bookOrder.ProcessOrder(order));
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }
            Console.WriteLine("-------------");
            IOrderProcessor Productorder = new PhysicalProductProcessingFactory().CreateOrder();
            if (Productorder != null)
            {
                var order = new Product
                {
                    Type = "Physical Product",
                    Name = "Physical Product"
                };
                Console.WriteLine("Order Status:" + Productorder.ProcessOrder(order));
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }

            Console.WriteLine("-------------");
            IOrderProcessor Videoorder = new VideoProcessingFactory().CreateOrder();
            if (Videoorder != null)
            {
                var order = new Product
                {
                    Type = "Video",
                    Name = "Learning to Ski"
                };
                Console.WriteLine("Order Status:" + Videoorder.ProcessOrder(order));
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }

            Console.WriteLine("-------------");
            IOrderProcessor Membershiporder = new MembershipProcessingFactory().CreateOrder();
            if (Membershiporder != null)
            {
                var order = new Product
                {
                    Type = "Membership",
                    Name = "Subscription1",
                    action = "activate"
                };
                Console.WriteLine("Order Status:" + Membershiporder.ProcessOrder(order));
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }

            Console.WriteLine("-------------");
            IOrderProcessor Upgrademembership = new MembershipProcessingFactory().CreateOrder();
            if (Upgrademembership != null)
            {
                var order = new Product
                {
                    Type = "Membership",
                    Name = "Subscription2",
                    action = "upgrade"
                };
                Console.WriteLine("Order Status:" + Upgrademembership.ProcessOrder(order));
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }
            Console.ReadLine();
        }
    }
}
