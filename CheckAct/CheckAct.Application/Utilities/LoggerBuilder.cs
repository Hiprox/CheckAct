using System.Reflection;
using Serilog;
using Serilog.Events;

namespace CheckAct.Application.Utilities;

public class LoggerBuilder
{
    public ILogger Build()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version;

        var loggerConfiguration = new LoggerConfiguration();

        // Enrich
        loggerConfiguration.Enrich.WithProperty("Version", version);

        // Write to ...
        loggerConfiguration.WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day,
            restrictedToMinimumLevel: LogEventLevel.Debug);

        return loggerConfiguration.CreateLogger();
    }
}