using CheckAct.Domain.Models;
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
        Create.Table(Acts.TableName).InSchema("public")
            .WithColumn(nameof(Acts.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(Acts.Number)).AsInt32().NotNullable()
            .WithColumnDescription("Номер акта")
            .WithColumn(nameof(Acts.Date)).AsDate().NotNullable()
            .WithColumnDescription("Дата выставления акта")
            .WithColumn(nameof(Acts.DocumentId)).AsInt32().ForeignKey(Documents.TableName, nameof(Documents.Id)).NotNullable()
            .WithColumnDescription($"FK на {Documents.TableName}.{nameof(Documents.Id)}");
    }
}