using LinqToDB.Mapping;

namespace CheckAct.Domain.Models;

/// <summary>
/// Маршрут.
/// </summary>
[Table(TableName)]
public class RoadRoutes
{
    /// <summary>
    /// Название таблицы.
    /// </summary>
    public const string TableName = "RoadRoutes";

    /// <summary>
    /// Первичный ключ.
    /// </summary>
    [PrimaryKey, Identity]
    public int Id { get; set; } = default;

    /// <summary>
    /// Адрес погрузки.
    /// </summary>
    [Column, NotNull] public string Source { get; set; }

    /// <summary>
    /// Адрес разгрузки.
    /// </summary>
    [Column, NotNull] public string Destination { get; set; }
}