using CheckAct.Domain.Models;
using FluentMigrator;

namespace Application.Infrastructure.Persistence.Migrations;

[Migration(20230330032300)]
public class CreatePayersTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table(Payers.TableName).InSchema("public")
            .WithColumn(nameof(Payers.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(Payers.Company)).AsString(256).NotNullable()
            .WithColumnDescription("Название организации")
            .WithColumn(nameof(Payers.Address)).AsString(512).NotNullable()
            .WithColumnDescription("Юридический адрес организации")
            .WithColumn(nameof(Payers.Inn)).AsString(12).NotNullable()
            .WithColumnDescription("ИНН")
            .WithColumn(nameof(Payers.CodeType)).AsInt32().NotNullable()
            .WithColumnDescription("Тип кода")
            .WithColumn(nameof(Payers.Code)).AsString(15).NotNullable()
            .WithColumnDescription("Код")
            .WithColumn(nameof(Payers.Bank)).AsString(256).NotNullable()
            .WithColumnDescription("Банк")
            .WithColumn(nameof(Payers.SettlementAccount)).AsString(20).NotNullable()
            .WithColumnDescription("Расчетный счет")
            .WithColumn(nameof(Payers.CorrespondentAccount)).AsString(20).NotNullable()
            .WithColumnDescription("Кореспондентский счет")
            .WithColumn(nameof(Payers.Bic)).AsString(9).NotNullable()
            .WithColumnDescription("БИК");
    }
}