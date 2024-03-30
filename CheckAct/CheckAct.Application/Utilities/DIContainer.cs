﻿using CheckAct.Utils.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Serilog;

namespace CheckAct.Application.Utilities;

public static class DIContainer
{
    private static readonly Lazy<ServiceProvider> LazyServiceProvider = new(InitializeServiceProvider);

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