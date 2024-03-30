using System.Reflection;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace CheckAct.Utils.Services;

/// <summary>
/// Сервис для выполнения миграций базы данных.
/// </summary>
public class MigrationService(Serilog.ILogger? logger = null)
{
    private Serilog.ILogger? _logger => logger;

    /// <summary>
    /// Проверяет наличие и, при необходимости, выполняет миграции для указанной базы данных.
    /// </summary>
    /// <param name="connectionString">Строка подключения к базе данных.</param>
    /// <param name="migrationAssembly">Сборка, содержащая миграции для базы данных.</param>
    public void EnsureDbExists(string connectionString, Assembly migrationAssembly)
    {
        _logger?.Information("Подготовка и запуск миграций");

        var serviceProvider = CreateServices(connectionString, migrationAssembly);
        using var scope = serviceProvider.CreateScope();
        UpdateDatabase(scope.ServiceProvider);
    }

    /// <summary>
    /// Конфигурирует сервисы для выполнения миграций.
    /// </summary>
    /// <param name="connectionString">Строка подключения к базе данных.</param>
    /// <param name="migrationAssembly">Сборка, содержащая миграции для базы данных.</param>
    /// <returns>Поставщик сервисов для выполнения миграций.</returns>
    private static ServiceProvider CreateServices(string connectionString, Assembly migrationAssembly)
        => new ServiceCollection()
            .AddFluentMigratorCore()
            .ConfigureRunner(builder => builder
                .AddPostgres()
                .WithGlobalConnectionString(connectionString)
                .ScanIn(migrationAssembly).For.Migrations()) // через рефлексию подбор того, что относится к миграциям
            .BuildServiceProvider(false);

    /// <summary>
    /// Выполняет обновление базы данных при необходимости.
    /// </summary>
    /// <param name="serviceProvider">Сервис-поставщик для работы с миграциями.</param>
    private void UpdateDatabase(IServiceProvider serviceProvider)
    {
        var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

        try
        {
            runner.MigrateUp();
            _logger?.Information("Миграция выполнена успешно.");
        }
        catch (Exception ex)
        {
            _logger?.Error(ex, "Исключение при выполнении миграции.");
        }
    }
}