using System;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFCResourceManagement
{
    public static class clsLog
    {
        public static void logger_INFO(string sMessage)
        {
            Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();
            Log.Information(sMessage);

            Log.CloseAndFlush();

        }

        public static void logger_ERROR(string sMessage)
        {
            Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();
            Log.Error(sMessage);

            Log.CloseAndFlush();

        }

        public static void logger_DEBUG(string sMessage)
        {
            Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();
            Log.Debug(sMessage);

            Log.CloseAndFlush();

        }

        public static void logger_FALTAL(string sMessage)
        {
            Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();
            Log.Fatal(sMessage);

            Log.CloseAndFlush();

        }

        public static void logger_VERBOSE(string sMessage)
        {
            Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();
            Log.Verbose(sMessage);

            Log.CloseAndFlush();

        }
    }
}
