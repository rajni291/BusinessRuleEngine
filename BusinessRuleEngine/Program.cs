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
            IOrderProcessor order = new BookProcessingFactory().CreateOrder();
            if(order != null)
            {
                Console.WriteLine("Order Status:" + order.ProcessOrder());
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }
            Console.ReadLine();
        }
    }
}
