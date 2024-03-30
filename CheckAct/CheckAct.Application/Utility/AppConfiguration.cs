using Microsoft.Extensions.Configuration;

namespace CheckAct.Application.Utility;

/// <summary>
/// Предоставляет доступ к настройкам конфигурации приложения.
/// </summary>
/// <param name="configuration">Экземпляр конфигурации.</param>
/// <remarks>Инициализирует новый экземпляр класса AppConfiguration с указанной конфигурацией.</remarks>
public class AppConfiguration(IConfiguration configuration)
{
    /// <summary>
    /// Получает строку подключения к SQL из конфигурации.
    /// </summary>
    /// <remarks>
    /// Данное свойство возвращает значение строки подключения к базе данных SQL, 
    /// которая хранится в конфигурационном файле приложения или в переменных окружения.
    /// </remarks>
    public string SqlConnectionString => configuration["SQL_CONNECTION_STRING"];
}