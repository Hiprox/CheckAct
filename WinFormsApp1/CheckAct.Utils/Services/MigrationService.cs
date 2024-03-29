using System.Reflection;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace CheckAct.Utils.Services;

public class MigrationService
{
    public static Serilog.ILogger? Logger { get; set; }

    private static string _connectionString;

    /// <summary>
    /// Установить строку подключения к базе данных.
    /// </summary>
    /// <param name="connectionString"></param>
    public static void SetConnectionString(string connectionString)
    {
        _connectionString = connectionString;
    }

    /// <summary>
    /// Проверка и при необходимости выполнение миграции подключённой БД
    /// </summary>
    public static void EnsureDBExists()
    {
        Logger?.Information("Подготовка и запуск миграций");

        var serviceProvider = CreateServices(_connectionString);
        using var scope = serviceProvider.CreateScope();
        UpdateDatabase(scope.ServiceProvider);
    }

    /// <summary>
    /// Конфигурирование сервисов для выполнения миграции
    /// </summary>
    /// <param name="connectionString">Строка подключения к БД</param>
    private static ServiceProvider CreateServices(string connectionString)
        => new ServiceCollection()
            .AddFluentMigratorCore()
            .ConfigureRunner(builder => builder
                .AddPostgres()
                .WithGlobalConnectionString(connectionString)
                .ScanIn(Assembly.GetExecutingAssembly()).For.Migrations()) // через рефлексию подбор того, что относится к миграциям
            .BuildServiceProvider(false);

    /// <summary>
    /// Выполнение обновления базы данных при необходимости
    /// </summary>
    /// <param name="serviceProvider">Сервис для обработки</param>
    private static void UpdateDatabase(IServiceProvider serviceProvider)
    {
        var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

        try
        {
            runner.MigrateUp();
        }
        catch (Exception ex)
        {
            Logger?.Error(ex, "Исключение при выполнении миграции: {Exception}");
        }
    }
}