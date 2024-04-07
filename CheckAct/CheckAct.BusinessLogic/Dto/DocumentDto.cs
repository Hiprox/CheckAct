namespace CheckAct.BusinessLogic.Dto;

#nullable disable

public record DocumentDto
{
    public string PayerContractNumber { get; init; }

    public DateTime PayerContractDate { get; init; }

    public RoadRouteDto RoadRoute { get; init; }

    public ActDto Act { get; init; }

    public List<CheckDto> Checks { get; init; }

    public PayerDto Payer { get; init; }
}