using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFrameworkDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();
            UseServices();
        }

        private static void UseServices()
        {
            IFoo foo = Container.GetService<IFoo>();
            foo.Foo();
        }

        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            collection.AddSingleton<IFoo, Foo>();
            collection.AddTransient<IBar, Bar>();

            Container = collection.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}
