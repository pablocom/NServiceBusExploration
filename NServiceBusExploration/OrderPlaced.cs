using NServiceBus;

namespace NServiceBusExploration.Messages
{
    public class OrderPlaced : IEvent
    {
        public string OrderId { get; set; }
    }
}