using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();

            Run();
        }


        public static IServiceProvider Container { get; private set; }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IMyService, MyService>();
            services.AddTransient<Client>();
            Container = services.BuildServiceProvider();
        }

        private static void Run()
        {
            Client client = Container.GetService<Client>();
            client.Doit();
        }

    }
}
