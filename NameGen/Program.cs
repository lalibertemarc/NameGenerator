﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
                ;
        }
    }
    
}