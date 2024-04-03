using CheckAct.Domain.Documents;

namespace CheckAct.Infrastructure.Stores;

public class DocumentStore() : IDocumentStore
{
    public Task<Document> Add(Document entity)
    {
        using var db = new CheckActContext();

        throw new NotImplementedException();
    }

    public Task<List<Document>> FindAll()
    {
        using var db = new CheckActContext();

        throw new NotImplementedException();
    }

    public Task<Document> FindById(int id)
    {
        using var db = new CheckActContext();

        throw new NotImplementedException();
    }

    public Task Remove(int id)
    {
        using var db = new CheckActContext();

        throw new NotImplementedException();
    }
}