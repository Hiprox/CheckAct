using CheckAct.Domain.Payers;
using FluentMigrator;

namespace Application.Infrastructure.Persistence.Migrations;

/// <summary>
/// Миграция для создания таблицы плательщиков.
/// </summary>
[Migration(20230330031600, "Cоздание таблицы плательщиков")]
public class CreatePayersTable : AutoReversingMigration
{
    /// <summary>
    /// Применяет миграцию для создания таблицы плательщиков.
    /// </summary>
    public override void Up()
    {
        Create.Table(Payer.TableName).InSchema("public")
            .WithColumn(nameof(Payer.Id)).AsInt32().PrimaryKey().Identity()
            .WithColumn(nameof(Payer.Company)).AsString(256).NotNullable()
            .WithColumnDescription("Название организации")
            .WithColumn(nameof(Payer.Address)).AsString(512).NotNullable()
            .WithColumnDescription("Юридический адрес организации")
            .WithColumn(nameof(Payer.Inn)).AsString(12).NotNullable()
            .WithColumnDescription("ИНН")
            .WithColumn(nameof(Payer.CodeType)).AsInt32().NotNullable()
            .WithColumnDescription("Тип кода")
            .WithColumn(nameof(Payer.Code)).AsString(15).NotNullable()
            .WithColumnDescription("Код")
            .WithColumn(nameof(Payer.Bank)).AsString(256).NotNullable()
            .WithColumnDescription("Банк")
            .WithColumn(nameof(Payer.SettlementAccount)).AsString(20).NotNullable()
            .WithColumnDescription("Расчетный счет")
            .WithColumn(nameof(Payer.CorrespondentAccount)).AsString(20).NotNullable()
            .WithColumnDescription("Кореспондентский счет")
            .WithColumn(nameof(Payer.Bic)).AsString(9).NotNullable()
            .WithColumnDescription("БИК");
    }
}