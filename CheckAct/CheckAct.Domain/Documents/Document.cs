using LinqToDB.Mapping;
using CheckAct.Domain.Acts;
using CheckAct.Domain.Checks;
using CheckAct.Domain.Payers;

namespace CheckAct.Domain.Documents;

/// <summary>
/// Документ.
/// </summary>
[Table(TableName)]
public class Document : IAggregateRoot
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
    [Association(ThisKey = nameof(Id), OtherKey = nameof(Act.DocumentId))]
    public Act Act { get; set; }

    /// <summary>
    /// Список счетов.
    /// </summary>
    [Association(ThisKey = nameof(Id), OtherKey = nameof(Check.DocumentId))]
    public ICollection<Check> Checks { get; set; }

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
    public RoadRoutes.RoadRoute RoadRoute { get; set; }

    /// <summary>
    /// Идентификатор плательщика.
    /// </summary>
    [Column, NotNull]
    public int PayerId { get; set; }

    /// <summary>
    /// Плательщик.
    /// </summary>
    [Association(ThisKey = nameof(PayerId), OtherKey = nameof(Payer.Id))]
    public Payer Payer { get; set; }

    /// <summary>
    /// Сумма к оплате.
    /// </summary>
    [Column, NotNull]
    public long Cost { get; set; }
}