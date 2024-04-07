using Boxed.Mapping;
using CheckAct.BusinessLogic.Dto;
using CheckAct.Domain.Acts;
using CheckAct.Domain.Checks;
using CheckAct.Domain.Documents;
using CheckAct.Domain.Payers;
using CheckAct.Domain.RoadRoutes;

namespace CheckAct.BusinessLogic.Mappers;

public class DocumentImmutableMapper : IImmutableMapper<DocumentDto, Document>
{
    public Document Map(DocumentDto source)
    {
        return new Document
        {
            PayerContractNumber = source.PayerContractNumber,
            PayerContractDate = source.PayerContractDate,
            RoadRoute = new RoadRoute
            {
                Source = source.RoadRoute.SourceRoute,
                SourceDate = source.RoadRoute.SourceDate,
                Destination = source.RoadRoute.DestinationRoute,
                DestinationDate = source.RoadRoute.DestinationDate
            },
            Payer = new Payer
            {
                Company = source.Payer.Company,
                Address = source.Payer.Address,
                Inn = source.Payer.Inn,
                CodeType = source.Payer.CodeType,
                Code = source.Payer.Code,
                Bank = source.Payer.Bank,
                SettlementAccount = source.Payer.SettlementAccount,
                CorrespondentAccount = source.Payer.CorrespondentAccount,
                Bic = source.Payer.Bic
            },
            Act = new Act
            {
                Number = source.Act.Number,
                Date = source.Act.Date,
            },
            Checks =
            [
                .. source.Checks.Select(x => new Check
                {
                    Number = x.Number,
                    Date = x.Date,
                    Cost = x.Cost,
                })
            ]
        };
    }
}