using DocumentFormat.OpenXml.Drawing.Charts;

namespace CheckAct.BusinessLogic.Dto;

#nullable disable

public record RoadRouteDto
{
    public string SourceRoute { get; init; }

    public DateTime SourceDate { get; init; }

    public string DestinationRoute { get; init; }

    public DateTime DestinationDate { get; init; }
}