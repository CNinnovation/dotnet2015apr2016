using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConfigurationFilesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DefineConfiguration(args);
            ShowConfiguration();
        }

        private static void ShowConfiguration()
        {
            var data = Configuration["Data:DefaultConnection:ConnectionString"];
            WriteLine(data);
            WriteLine(Configuration["one"]);
        }

        private static void DefineConfiguration(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json").AddCommandLine(args).AddXmlFile("appsettings.xml", optional: true);
            Configuration = config.Build();
        }

        public static IConfigurationRoot Configuration { get; private set; }


    }
}
