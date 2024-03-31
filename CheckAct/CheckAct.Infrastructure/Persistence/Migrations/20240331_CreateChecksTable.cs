using CheckAct.Domain.Models;
using FluentMigrator;

namespace Application.Infrastructure.Persistence.Migrations;

/// <summary>
/// Миграция для создания таблицы счетов.
/// </summary>
[Migration(20240331225300, "Создание таблицы счетов")]
public class CreateCheckTable : AutoReversingMigration
{
    /// <summary>
    /// Применяет миграцию для создания таблицы счетов.
    /// </summary>
    public override void Up()
    {
        Create.Table(Checks.TableName).InSchema("public")
            .WithColumn(nameof(Checks.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(Checks.Number)).AsInt32().NotNullable()
            .WithColumnDescription("Номер счета")
            .WithColumn(nameof(Checks.Date)).AsDate().NotNullable()
            .WithColumnDescription("Дата выставления счета")
            .WithColumn(nameof(Checks.Cost)).AsInt64().NotNullable()
            .WithColumnDescription("Сумма к оплате")
            .WithColumn(nameof(Checks.DocumentId)).AsInt32().ForeignKey(Documents.TableName, nameof(Documents.Id)).NotNullable()
            .WithColumnDescription($"FK на {Documents.TableName}.{nameof(Documents.Id)}");
    }
}