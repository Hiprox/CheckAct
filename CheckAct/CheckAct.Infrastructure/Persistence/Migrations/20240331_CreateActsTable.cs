using CheckAct.Domain.Acts;
using CheckAct.Domain.Documents;
using FluentMigrator;

namespace Application.Infrastructure.Persistence.Migrations;

/// <summary>
/// Миграция для создания таблицы актов.
/// </summary>
[Migration(20240331230100, "Создание таблицы актов")]
public class CreateActsTable : AutoReversingMigration
{
    /// <summary>
    /// Применяет миграцию для создания таблицы актов.
    /// </summary>
    public override void Up()
    {
        Create.Table(Act.TableName).InSchema("public")
            .WithColumn(nameof(Act.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(Act.Number)).AsInt32().NotNullable()
            .WithColumnDescription("Номер акта")
            .WithColumn(nameof(Act.Date)).AsDate().NotNullable()
            .WithColumnDescription("Дата выставления акта")
            .WithColumn(nameof(Act.DocumentId)).AsInt32().ForeignKey(Document.TableName, nameof(Document.Id)).NotNullable()
            .WithColumnDescription($"FK на {Document.TableName}.{nameof(Document.Id)}");
    }
}