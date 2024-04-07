namespace CheckAct.BusinessLogic.Dto;

public record CheckDto
{
    public string Number { get; init; }

    public DateTime Date { get; init; }

    public long Cost { get; init; }
}