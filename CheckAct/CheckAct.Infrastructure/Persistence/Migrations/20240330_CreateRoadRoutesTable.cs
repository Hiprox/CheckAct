using CheckAct.Domain.RoadRoutes;
using FluentMigrator;

namespace Application.Infrastructure.Persistence.Migrations;

/// <summary>
/// Миграция для создания таблицы маршрутов.
/// </summary>
[Migration(20230330033900, "Создание таблицы маршрутов")]
public class CreateRoadRoutesTable : AutoReversingMigration
{
    /// <summary>
    /// Применяет миграцию для создания таблицы маршрутов.
    /// </summary>
    public override void Up()
    {
        Create.Table(RoadRoute.TableName).InSchema("public")
            .WithColumn(nameof(RoadRoute.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(RoadRoute.Order)).AsInt32().NotNullable()
            .WithColumnDescription("Порядковый номер")
            .WithColumn(nameof(RoadRoute.Source)).AsString(512).NotNullable()
            .WithColumnDescription("Адрес погрузки")
            .WithColumn(nameof(RoadRoute.SourceDate)).AsDate().NotNullable()
            .WithColumnDescription("Дата погрузки")
            .WithColumn(nameof(RoadRoute.Destination)).AsString(512).NotNullable()
            .WithColumnDescription("Адрес разгрузки")
            .WithColumn(nameof(RoadRoute.DestinationDate)).AsDate().NotNullable()
            .WithColumnDescription("Дата разгрузки");
    }
}