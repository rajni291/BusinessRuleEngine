using BusinessRuleEngine.Factory;
using BusinessRuleEngine.Interface;
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
                Console.WriteLine("Order Status:" + bookOrder.ProcessOrder());
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }
            Console.WriteLine("-------------");
            IOrderProcessor Productorder = new PhysicalProductProcessingFactory().CreateOrder();
            if (Productorder != null)
            {
                Console.WriteLine("Order Status:" + Productorder.ProcessOrder());
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }
            Console.ReadLine();
        }
    }
}
