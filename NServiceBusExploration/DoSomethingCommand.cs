using NServiceBus;

namespace NServiceBusExploration.Messages
{
    public class DoSomethingCommand : ICommand
    {
        public string SomeProperty { get; set; }
    }
}