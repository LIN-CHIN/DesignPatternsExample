using Microsoft.Extensions.DependencyInjection;
using System;

namespace Flyweight
{
	class Program
	{
		static void Main(string[] args)
		{
			var serviceProvider = new ServiceCollection()
									.AddSingleton<Application>()
									.BuildServiceProvider();

			serviceProvider.GetService<Application>().Start();
		}
	}
}
