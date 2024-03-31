namespace CheckAct.Domain;

/// <summary>
/// Корень сущности.
/// </summary>
/// <remarks>Отвечает за согласованность графа объектов.</remarks>
public interface IAggregateRoot
{
    public int Id { get; set; }
}