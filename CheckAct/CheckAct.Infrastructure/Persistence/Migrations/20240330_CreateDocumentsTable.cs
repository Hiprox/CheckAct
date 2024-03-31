using CheckAct.Domain.Models;
using FluentMigrator;

namespace Application.Infrastructure.Persistence.Migrations;

/// <summary>
/// Миграция для создания таблицы документов.
/// </summary>
[Migration(20230330033900, "Cоздание таблицы документов")]
public class CreateDocumentsTable : AutoReversingMigration
{
    /// <summary>
    /// Применяет миграцию для создания таблицы документов.
    /// </summary>
    public override void Up()
    {
        Create.Table(Documents.TableName).InSchema("public")
            .WithColumn(nameof(Documents.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(Documents.PayerContractNumber)).AsString(64).Nullable()
            .WithColumnDescription("Номер договора-заявки плательщика")
            .WithColumn(nameof(Documents.PayerContractDate)).AsDate().NotNullable()
            .WithColumnDescription("Дата договора-заявки плательщика")
            .WithColumn(nameof(Documents.RoadRouteId)).AsInt32()
            .ForeignKey(RoadRoutes.TableName, nameof(RoadRoutes.Id)).NotNullable()
            .WithColumnDescription($"FK на {RoadRoutes.TableName}.{nameof(RoadRoutes.Id)}")
            .WithColumn(nameof(Documents.PayerId)).AsInt32().ForeignKey(Payers.TableName, nameof(Payers.Id))
            .NotNullable()
            .WithColumnDescription($"FK на {Payers.TableName}.{nameof(Payers.Id)}");
    }
}