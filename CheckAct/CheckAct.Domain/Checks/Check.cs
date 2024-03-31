using CheckAct.Domain.Documents;
using LinqToDB.Mapping;

namespace CheckAct.Domain.Checks;

/// <summary>
/// Счет.
/// </summary>
[Table(TableName)]
public class Check : IAggregateRoot
{
    /// <summary>
    /// Название таблицы.
    /// </summary>
    public const string TableName = "Checks";

    /// <summary>
    /// Первичный ключ.
    /// </summary>
    [PrimaryKey, Identity]
    public int Id { get; set; }

    /// <summary>
    /// Номер.
    /// </summary>
    [Column, NotNull]
    public string Number { get; set; }

    /// <summary>
    /// Дата.
    /// </summary>
    [Column, NotNull]
    public DateTime Date { get; set; }

    /// <summary>
    /// Цена.
    /// </summary>
    [Column, NotNull]
    public long Cost { get; set; }

    /// <summary>
    /// Идентификатор документа которому принаделжит счет.
    /// </summary>
    [Column, NotNull]
    public int DocumentId { get; set; }

    /// <summary>
    /// Документ которому принадлежит счет.
    /// </summary>
    [Association(ThisKey = nameof(DocumentId), OtherKey = nameof(Document.Id))]
    public Document Document { get; set; }
}