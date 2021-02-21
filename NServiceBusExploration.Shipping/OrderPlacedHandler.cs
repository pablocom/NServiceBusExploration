using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using NServiceBusExploration.Messages;

namespace NServiceBusExploration.Shipping
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        static ILog log = LogManager.GetLogger<OrderPlacedHandler>();

        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderPlaced, OrderId = {message.OrderId}");

            return Task.CompletedTask;
        }
    }
}