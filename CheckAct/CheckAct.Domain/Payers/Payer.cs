using LinqToDB.Mapping;

namespace CheckAct.Domain.Payers;

/// <summary>
/// Плательщик.
/// </summary>
[Table(TableName)]
public class Payer : IAggregateRoot
{
    /// <summary>
    /// Название таблицы.
    /// </summary>
    public const string TableName = "Payers";

    /// <summary>
    /// Первичный ключ.
    /// </summary>
    [PrimaryKey, Identity]
    public int Id { get; set; } = default;

    /// <summary>
    /// Название организации.
    /// </summary>
    [Column, NotNull] public string Company { get; set; }

    /// <summary>
    /// Юридический адрес организации.
    /// </summary>
    [Column, NotNull] public string Address { get; set; }

    /// <summary>
    /// ИНН.
    /// </summary>
    [Column, NotNull] public string Inn { get; set; }

    /// <summary>
    /// Тип кода.
    /// </summary>
    [Column, NotNull] public string CodeType { get; set; }

    /// <summary>
    /// Код.
    /// </summary>
    [Column, NotNull] public string Code { get; set; }

    /// <summary>
    /// Банк.
    /// </summary>
    [Column, NotNull] public string Bank { get; set; }

    /// <summary>
    /// Расчетный счет.
    /// </summary>
    [Column, NotNull] public string SettlementAccount { get; set; }

    /// <summary>
    /// Кореспондентский счет.
    /// </summary>
    [Column, NotNull] public string CorrespondentAccount { get; set; }

    /// <summary>
    /// БИК.
    /// </summary>
    [Column, NotNull] public string Bic { get; set; }
}