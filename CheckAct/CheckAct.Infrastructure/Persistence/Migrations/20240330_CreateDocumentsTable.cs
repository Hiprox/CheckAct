using CheckAct.Domain.Documents;
using CheckAct.Domain.Payers;
using CheckAct.Domain.RoadRoutes;
using FluentMigrator;

namespace Application.Infrastructure.Persistence.Migrations;

/// <summary>
/// Миграция для создания таблицы документов.
/// </summary>
[Migration(20230330031600, "Cоздание таблицы документов")]
public class CreateDocumentsTable : AutoReversingMigration
{
    /// <summary>
    /// Применяет миграцию для создания таблицы документов.
    /// </summary>
    public override void Up()
    {
        Create.Table(Document.TableName).InSchema("public")
            .WithColumn(nameof(Document.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(Document.PayerContractNumber)).AsString(64).Nullable()
            .WithColumnDescription("Номер договора-заявки плательщика")
            .WithColumn(nameof(Document.PayerContractDate)).AsDate().NotNullable()
            .WithColumnDescription("Дата договора-заявки плательщика")
            .WithColumn(nameof(Document.PayerId)).AsInt32().ForeignKey(Payer.TableName, nameof(Payer.Id))
            .NotNullable()
            .WithColumnDescription($"FK на {Payer.TableName}.{nameof(Payer.Id)}");
    }
}