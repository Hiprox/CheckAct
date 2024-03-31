using CheckAct.Domain.Models;
using FluentMigrator;

namespace Application.Infrastructure.Persistence.Migrations;

/// <summary>
/// Миграция для создания таблицы маршрутов.
/// </summary>
[Migration(20230330031600, "Создание таблицы маршрутов")]
public class CreateRoadRoutesTable : AutoReversingMigration
{
    /// <summary>
    /// Применяет миграцию для создания таблицы маршрутов.
    /// </summary>
    public override void Up()
    {
        Create.Table(RoadRoutes.TableName).InSchema("public")
            .WithColumn(nameof(RoadRoutes.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(RoadRoutes.Source)).AsString(512).NotNullable()
            .WithColumnDescription("Адрес погрузки")
            .WithColumn(nameof(RoadRoutes.SourceDate)).AsDate().NotNullable()
            .WithColumnDescription("Дата погрузки")
            .WithColumn(nameof(RoadRoutes.Destination)).AsString(512).NotNullable()
            .WithColumnDescription("Адрес разгрузки")
            .WithColumn(nameof(RoadRoutes.DestinationDate)).AsDate().NotNullable()
            .WithColumnDescription("Дата разгрузки");
    }
}