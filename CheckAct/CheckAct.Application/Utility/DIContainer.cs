using System;
using Boxed.Mapping;
using CheckAct.BusinessLogic;
using CheckAct.BusinessLogic.Dto;
using CheckAct.BusinessLogic.Interfaces;
using CheckAct.BusinessLogic.Mappers;
using CheckAct.Domain.Documents;
using CheckAct.Infrastructure.Stores;
using CheckAct.Utils.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace CheckAct.Application.Utility;

/// <summary>
/// Класс-контейнер для управления зависимостями (DI) в приложении.
/// </summary>
public static class DIContainer
{
    private static readonly Lazy<ServiceProvider> LazyServiceProvider = new(InitializeServiceProvider);

    /// <summary>
    /// Получает поставщика служб (ServiceProvider), который предоставляет доступ к зарегистрированным службам.
    /// </summary>
    public static ServiceProvider ServiceProvider => LazyServiceProvider.Value;

    private static ServiceProvider InitializeServiceProvider()
    {
        var serviceCollection = new ServiceCollection();

        // Добавляем наши сервисы
        ConfigureServices(serviceCollection);

        return serviceCollection.BuildServiceProvider();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        // Регистрирует конфигурацию приложения, загружая её из переменных окружения.
        services.AddSingleton<IConfiguration>(_ =>
            new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build());

        // Регистрируем конфиг приложения
        services.AddSingleton<AppConfiguration>();
        
        // Регистрируем LoggerBuilder
        services.AddSingleton<LoggerBuilder>();

        // Регистрируем Serilog логгер
        services.AddSingleton(_ =>
        {
            var loggerBuilder = ServiceProvider.GetService<LoggerBuilder>();
            return Log.Logger = loggerBuilder.Build();
        });

        // Регистрируем MigrationService
        services.AddSingleton(_ =>
        {
            var logger = ServiceProvider.GetService<ILogger>();
            return new MigrationService(logger);
        });

        // Mappers
        services.AddSingleton<IImmutableMapper<DocumentDto, Document>, DocumentImmutableMapper>();

        // Business Logic
        services.AddSingleton<IDocumentService, DocumentService>();
        
        // Infrastructure
        services.AddSingleton<IDocumentStore, DocumentStore>();
    }

    /// <summary>
    /// Конфиг приложения.
    /// </summary>
    public static AppConfiguration Config => ServiceProvider.GetService<AppConfiguration>();

    /// <summary>
    /// Мигратор.
    /// </summary>
    public static MigrationService Migrator => ServiceProvider.GetService<MigrationService>();

}