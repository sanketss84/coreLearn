using System;
using Serilog;

// https://github.com/serilog/serilog/wiki/Getting-Started#example-application
// https://github.com/serilog/serilog/wiki/Provided-Sinks

namespace coreLearn.SeriLog.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // var log = new LoggerConfiguration()
            //             .MinimumLevel.Debug()
            //             .WriteTo.Console()
            //             .WriteTo.File("logs\\coreLearn.txt", rollingInterval: RollingInterval.Day)
            //             .CreateLogger();
            // log.Information("Hello, Serilog!");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs\\coreLearn.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            
            Log.Information("Hello, Serilog!");
            Log.CloseAndFlush();

            System.Console.WriteLine("Hello World");
        }
    }
}
