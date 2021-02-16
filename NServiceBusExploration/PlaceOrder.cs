using NServiceBus;

namespace NServiceBusExploration.Messages
{
    public class PlaceOrder : ICommand
    {
        public string OrderId { get; set; }
    }
}