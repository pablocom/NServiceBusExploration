using System;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using NServiceBusExploration.Messages;

namespace NServiceBusExploration.Sales
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        private static ILog log = LogManager.GetLogger<PlaceOrderHandler>();
        private static Random random = new Random();
        
        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received PlaceOrder, OrderId = {message.OrderId}");

            if (random.Next(0, 5) == 0)
            {
                throw new Exception("BOOM");
            }

            var orderPlaced = new OrderPlaced
            {
                OrderId = message.OrderId
            };
            return context.Publish(orderPlaced);
        }
    }
}