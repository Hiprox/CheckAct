namespace CheckAct.Domain;

public interface IStore<TEntity>
    where TEntity : IAggregateRoot
{
    Task<TEntity?> FindById(int id);
    Task<List<TEntity>> FindAll();
    Task<TEntity> Add(TEntity entity);
    Task Remove(int id);
}