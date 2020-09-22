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
            Console.ReadLine();
        }
    }
}
