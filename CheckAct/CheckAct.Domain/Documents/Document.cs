using LinqToDB.Mapping;
using CheckAct.Domain.Acts;
using CheckAct.Domain.Checks;
using CheckAct.Domain.Payers;
using CheckAct.Domain.RoadRoutes;

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
    public IEnumerable<Check> Checks { get; set; }

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
    /// Маршрут.
    /// </summary>
    [Association(ThisKey = nameof(Id), OtherKey = nameof(RoadRoute.Id))]
    public IEnumerable<RoadRoute> RoadRoutes { get; set; }

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
}