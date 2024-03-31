using CheckAct.Domain.Documents;
using LinqToDB;
using LinqToDB.Data;

namespace CheckAct.Infrastructure.Stores;

public class DocumentStore(IDataContext db) : IDocumentStore
{
    private ITable<Document> _documents = db.GetTable<Document>();

    public Task<Document> Add(Document entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Document>> FindAll()
    {
        throw new NotImplementedException();
    }

    public Task<Document> FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Task Remove(int id)
    {
        throw new NotImplementedException();
    }
}