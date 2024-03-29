using Application.Domain.Models;
using FluentMigrator;

namespace Application.Infrastructure.Persistence.Migrations;

[Migration(20230330031600)]
public class CreateRoadRoutesTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table(RoadRoutes.TableName).InSchema("public")
            .WithColumn(nameof(RoadRoutes.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(RoadRoutes.Source)).AsString(512).NotNullable()
            .WithColumnDescription("Адрес прогрузки")
            .WithColumn(nameof(RoadRoutes.Destination)).AsString(512).NotNullable()
            .WithColumnDescription("Адрес разгрузки");
    }
}