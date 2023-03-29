using System;
using Microsoft.Extensions.Logging;
using Rebus.Activation;
using Rebus.Config;
using Rebus.Transport.InMem;

namespace TestApp;

class Program
{
    static void Main()
    {
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        using var activator = new BuiltinHandlerActivator();

        Configure.With(activator)
            .Logging(l => l.MicrosoftExtensionsLogging(loggerFactory))
            .Transport(t => t.UseInMemoryTransport(new InMemNetwork(), "logging-test"))
            .Start();

        Console.WriteLine("Press ENTER to quit");
        Console.ReadLine();
    }
}
