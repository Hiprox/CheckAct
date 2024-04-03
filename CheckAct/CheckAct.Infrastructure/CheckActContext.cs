using CheckAct.Domain.Acts;
using CheckAct.Domain.Checks;
using CheckAct.Domain.Documents;
using CheckAct.Domain.Payers;
using CheckAct.Domain.RoadRoutes;
using LinqToDB.Data;
using LinqToDB;

namespace CheckAct.Infrastructure;

public class CheckActContext() : DataConnection(_dataOptions)
{
    private static DataOptions _dataOptions;

    public ITable<Document> Documents => this.GetTable<Document>();

    public ITable<Act> Acts => this.GetTable<Act>();

    public ITable<Check> Checks => this.GetTable<Check>();

    public ITable<Payer> Payers => this.GetTable<Payer>();

    public ITable<RoadRoute> RoadRoutes => this.GetTable<RoadRoute>();

    public static void SetOptions(DataOptions options)
    {
        _dataOptions = options;
    }
}
