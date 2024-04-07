namespace CheckAct.BusinessLogic.Dto;

#nullable disable

public record ActDto
{
    public string Number { get; init; }

    public DateTime Date { get; init; }
}