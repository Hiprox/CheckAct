using CheckAct.Domain.Documents;
using LinqToDB.Mapping;

namespace CheckAct.Domain.RoadRoutes;

/// <summary>
/// Маршрут.
/// </summary>
[Table(TableName)]
public class RoadRoute : IAggregateRoot
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
    /// Порядковый номер.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Адрес погрузки.
    /// </summary>
    [Column, NotNull]
    public string Source { get; set; }

    /// <summary>
    /// Дата погрузки.
    /// </summary>
    [Column, NotNull]
    public DateTime SourceDate { get; set; }

    /// <summary>
    /// Адрес разгрузки.
    /// </summary>
    [Column, NotNull]
    public string Destination { get; set; }

    /// <summary>
    /// Дата разгрузки.
    /// </summary>
    [Column, NotNull]
    public DateTime DestinationDate { get; set; }

    /// <summary>
    /// Идентификатор документа.
    /// </summary>
    [Column, NotNull]
    public int DocumentId { get; set; }

    /// <summary>
    /// Документ.
    /// </summary>
    [Association(ThisKey = nameof(DocumentId), OtherKey = nameof(Document.Id))]
    public Document Document { get; set; }
}