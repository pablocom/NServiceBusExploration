using System;
using System.Threading.Tasks;
using NServiceBus;

namespace NServiceBusExploration.Sales
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Sales";

            var endpointConfiguration = new EndpointConfiguration("Sales");
            endpointConfiguration.Recoverability()
                .Immediate(
                    immediate => { immediate.NumberOfRetries(5); });

            var transport = endpointConfiguration.UseTransport<LearningTransport>();

            var endpointInstance = await Endpoint.Start(endpointConfiguration)
                .ConfigureAwait(false);

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

            await endpointInstance.Stop()
                .ConfigureAwait(false);
        }
    }
}