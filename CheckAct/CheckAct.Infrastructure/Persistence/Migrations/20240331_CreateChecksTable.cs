using CheckAct.Domain.Checks;
using CheckAct.Domain.Documents;
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
        Create.Table(Check.TableName).InSchema("public")
            .WithColumn(nameof(Check.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(Check.Number)).AsString(32).NotNullable()
            .WithColumnDescription("Номер счета")
            .WithColumn(nameof(Check.Date)).AsDate().NotNullable()
            .WithColumnDescription("Дата выставления счета")
            .WithColumn(nameof(Check.Cost)).AsInt64().NotNullable()
            .WithColumnDescription("Сумма к оплате")
            .WithColumn(nameof(Check.DocumentId)).AsInt32().ForeignKey(Document.TableName, nameof(Document.Id)).NotNullable()
            .WithColumnDescription($"FK на {Document.TableName}.{nameof(Document.Id)}");
    }
}