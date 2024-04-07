using CheckAct.Domain.Enums;

namespace CheckAct.BusinessLogic.Dto;

public record PayerDto
{
    public string Company { get; init; }

    public string Address { get; init; }

    public string Inn { get; init; }

    public CodeType CodeType { get; init; }

    public string Code { get; init; }

    public string Bank { get; init; }

    public string SettlementAccount { get; init; }

    public string CorrespondentAccount { get; init; }

    public string Bic { get; init; }
}