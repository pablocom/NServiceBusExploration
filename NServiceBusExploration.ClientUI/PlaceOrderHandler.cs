using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using NServiceBusExploration.Messages;

namespace NServiceBusExploration.ClientUI
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        static ILog log = LogManager.GetLogger<PlaceOrderHandler>();
        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received PlaceOrder, OrderId = {message.OrderId}");
            return Task.CompletedTask;
        }
    }
}