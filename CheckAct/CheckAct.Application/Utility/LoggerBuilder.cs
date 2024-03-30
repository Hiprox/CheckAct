using System.Reflection;
using Serilog;
using Serilog.Events;

namespace CheckAct.Application.Utility;

/// <summary>
/// Класс для создания экземпляра логгера.
/// </summary>
public class LoggerBuilder
{
    /// <summary>
    /// Создает и возвращает экземпляр логгера с настроенной конфигурацией.
    /// </summary>
    /// <returns>Экземпляр настроенного логгера.</returns>
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