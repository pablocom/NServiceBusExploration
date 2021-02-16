using System.Threading.Tasks;
using NServiceBus;

namespace NServiceBusExploration.ClientUI
{
    public class DoSomethingCommandHandler: IHandleMessages<DoSomethingCommand>
    {
        public Task Handle(DoSomethingCommand message, IMessageHandlerContext context)
        {
            return Task.CompletedTask;
        }
    }
}