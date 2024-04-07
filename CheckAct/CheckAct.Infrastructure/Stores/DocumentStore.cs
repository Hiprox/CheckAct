using CheckAct.Domain.Documents;
using LinqToDB;
using LinqToDB.Data;

namespace CheckAct.Infrastructure.Stores;

#nullable enable

public class DocumentStore() : IDocumentStore
{
    public async Task<Document> Add(Document entity)
    {
        await using var db = new CheckActContext();
        await using var transaction = await db.BeginTransactionAsync();
        try
        {
            entity.RoadRouteId = await db.InsertWithInt32IdentityAsync(entity.RoadRoute);
            
            entity.PayerId = await db.InsertWithInt32IdentityAsync(entity.Payer);

            var docId = await db.InsertWithInt32IdentityAsync(entity);

            foreach (var check in entity.Checks)
            {
                check.DocumentId = docId;
            }

            await db.BulkCopyAsync(entity.Checks);

            entity.Act.DocumentId = docId;
            await db.InsertAsync(entity.Act);

            await transaction.CommitAsync();
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }

        return entity;
    }

    public async Task<List<Document>> FindAll()
    {
        await using var db = new CheckActContext();

        return await db.Documents.ToListAsync();
    }

    public async Task<Document?> FindById(int id)
    {
        await using var db = new CheckActContext();

        return await db.Documents.Where((_, i) => i == id).FirstOrDefaultAsync();
    }

    public async Task Remove(int id)
    {
        await using var db = new CheckActContext();

        await db.Documents.Where(x => x.Id == id).DeleteAsync();
    }
}