using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NameGen.Configs;
using NameGen.Services;
using NameGen.Services.Implementations;
using System;

namespace NameGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();
            var main = serviceProvider.GetService<INameGenService>();

            var numberToGenerate = args.Length == 0 ? 15 : int.Parse(args[0]);

            main.GenerateName(numberToGenerate);

            while (Console.ReadLine() != "x")
            {
                main.GenerateName(numberToGenerate);
            };

        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
                .AddSingleton<INameGenService, NameGenService>()
                .AddTransient<IRandomEventHandler, RandomEventHandler>()
                .AddSingleton<IConfigs, Configs.Configs>()
                ;
        }
    }
    
}
