using LinqToDB.Mapping;

namespace Application.Domain.Models;

/// <summary>
/// Документ.
/// </summary>
[Table(TableName)]
public class Documents
{
    /// <summary>
    /// Название таблицы.
    /// </summary>
    public const string TableName = "Documents";

    /// <summary>
    /// Первичный ключ.
    /// </summary>
    [PrimaryKey, Identity]
    public int Id { get; set; } = default;

    /// <summary>
    /// Номер счёта.
    /// </summary>
    [Column, NotNull] public string CheckNumber { get; set; }

    /// <summary>
    /// Дата выставления счёта.
    /// </summary>
    [Column, NotNull] public DateTime CheckDate { get; set; }

    /// <summary>
    /// Номер акта.
    /// </summary>
    [Column, NotNull] public string ActNumber { get; set; }

    /// <summary>
    /// Дата выставления акта.
    /// </summary>
    [Column, NotNull] public DateTime ActDate { get; set; }

    /// <summary>
    /// Номер договора-заявки плательщика.
    /// </summary>
    [Column, Nullable]
    public string? PayerContractNumber { get; set; }

    /// <summary>
    /// Дата договора-заявки плательщика.
    /// </summary>
    [Column, Nullable]
    public DateTime PayerContractDate { get; set; }

    /// <summary>
    /// Идентификатор маршрута.
    /// </summary>
    [Column, Nullable]
    public int RoadRouteId { get; set; }

    /// <summary>
    /// Маршрут.
    /// </summary>
    [Association(ThisKey = nameof(RoadRouteId), OtherKey = nameof(RoadRoute.Id))]
    public RoadRoutes RoadRoute { get; set; }

    /// <summary>
    /// Идентификатор плательщика.
    /// </summary>
    [Column, Nullable]
    public int PayerId { get; set; }

    /// <summary>
    /// Плательщик.
    /// </summary>
    [Association(ThisKey = nameof(PayerId), OtherKey = nameof(Payer.Id))]
    public Payers Payer { get; set; }
}