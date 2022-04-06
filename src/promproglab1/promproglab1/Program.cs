using Lab1.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using promproglab1.Commands;
using promproglab1.Repositories;
using Spectre.Console.Cli;

namespace PromProgLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IFunctionsRepository, XmlFunctionsRepository>();

            var registrar = new TypeRegistrar(serviceCollection);
            var app = new CommandApp(registrar);

            app.Configure(config =>
            {
                config.AddCommand<AddFunctionCommand>("add");
                config.AddCommand<PrintAllFunctionsCommand>("print");
                config.AddCommand<InsertFunctionCommand>("insert");
                config.AddCommand<RemoveFunctionCommand>("remove");
                config.AddCommand<RemoveAllFunctionCommand>("removeall");
                config.AddCommand<ComparisonFunctionCommand>("comparison");
                config.AddCommand<MinFunctionCommand>("min");
            });
            app.Run(args);
        }
    }
}

