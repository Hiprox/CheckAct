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
            RoadRoutes =
            [
                .. source.RoadRoutes.Select((x, i) => new RoadRoute
                {
                    Order = i + 1,
                    Source = x.SourceRoute,
                    SourceDate = x.SourceDate,
                    Destination = x.DestinationRoute,
                    DestinationDate = x.DestinationDate,
                }).OrderBy(x => x.Order)
            ],
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