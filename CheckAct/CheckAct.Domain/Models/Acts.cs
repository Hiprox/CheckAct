using LinqToDB.Mapping;

namespace CheckAct.Domain.Models;

/// <summary>
/// Акт.
/// </summary>
[Table(TableName)]
public class Acts
{
    /// <summary>
    /// Название таблицы.
    /// </summary>
    public const string TableName = "Acts";

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
    /// Идентификатор документа которому принаделжит счет.
    /// </summary>
    [Column, NotNull]
    public int DocumentId { get; set; }

    /// <summary>
    /// Документ которому принадлежит счет.
    /// </summary>
    [Association(ThisKey = nameof(DocumentId), OtherKey = nameof(Document.Id))]
    public Documents Document { get; set; }
}