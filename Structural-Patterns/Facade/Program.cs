using Facade.ExternalSystem;
using Facade.Facade;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                                    .AddSingleton<Application>()
                                    .AddSingleton<ISubSystem, Facade2>()
                                    .AddTransient<SubSystem1>()
                                    .AddTransient<SubSystem2>()
                                    .BuildServiceProvider();

            serviceProvider.GetService<Application>().Start();
        }
    }
}
