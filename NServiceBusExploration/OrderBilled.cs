using NServiceBus;

namespace NServiceBusExploration.Messages
{
    public class OrderBilled : IEvent
    {
        public string OrderId { get; set; }
    }
}