﻿using BusinessRuleEngine.Implementation;
using BusinessRuleEngine.Interface;
namespace BusinessRuleEngine.Factory
{
    public class VideoProcessingFactory : OrderProcessingFactory
    {
        protected override IOrderProcessor GetOrderType()
        {
            IOrderProcessor order = new VideoProcessor();
            return order;
        }
    }
}
