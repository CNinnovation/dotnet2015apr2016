using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory loggerFactory = new LoggerFactory()
                .AddConsole().AddDebug();

            ILogger logger = loggerFactory.CreateLogger<Program>();

            logger.LogInformation("Main Method");

            Console.ReadLine();
        }
    }
}
