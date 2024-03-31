using LinqToDB.Mapping;

namespace CheckAct.Domain.Models;

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
    /// Акт.
    /// </summary>
    [Association(ThisKey = nameof(Id), OtherKey = nameof(Acts.DocumentId))]
    public Acts Act { get; set; }

    /// <summary>
    /// Список счетов.
    /// </summary>
    [Association(ThisKey = nameof(Id), OtherKey = nameof(Models.Checks.DocumentId))]
    public ICollection<Checks> Checks { get; set; }

    /// <summary>
    /// Номер договора-заявки плательщика.
    /// </summary>
    [Column, Nullable]
    public string? PayerContractNumber { get; set; }

    /// <summary>
    /// Дата договора-заявки плательщика.
    /// </summary>
    [Column, NotNull]
    public DateTime PayerContractDate { get; set; }

    /// <summary>
    /// Идентификатор маршрута.
    /// </summary>
    [Column, NotNull]
    public int RoadRouteId { get; set; }

    /// <summary>
    /// Маршрут.
    /// </summary>
    [Association(ThisKey = nameof(RoadRouteId), OtherKey = nameof(RoadRoute.Id))]
    public RoadRoutes RoadRoute { get; set; }

    /// <summary>
    /// Идентификатор плательщика.
    /// </summary>
    [Column, NotNull]
    public int PayerId { get; set; }

    /// <summary>
    /// Плательщик.
    /// </summary>
    [Association(ThisKey = nameof(PayerId), OtherKey = nameof(Payer.Id))]
    public Payers Payer { get; set; }

    /// <summary>
    /// Сумма к оплате.
    /// </summary>
    [Column, NotNull]
    public long Cost { get; set; }
}