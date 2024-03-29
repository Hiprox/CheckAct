using LinqToDB.Mapping;

namespace Application.Domain.Models;

/// <summary>
/// Плательщик.
/// </summary>
[Table(TableName)]
public class Payers
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
    /// Название компании.
    /// </summary>
    [Column, NotNull] public string Company { get; set; }

    /// <summary>
    /// Юридический адрес компании.
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
    /// Расчетный счёт.
    /// </summary>
    [Column, NotNull] public string SettlementAccount { get; set; }

    /// <summary>
    /// Кореспондентский счёт.
    /// </summary>
    [Column, NotNull] public string CorrespondentAccount { get; set; }
    
    /// <summary>
    /// БИК.
    /// </summary>
    [Column, NotNull] public string RcBic { get; set; }
}