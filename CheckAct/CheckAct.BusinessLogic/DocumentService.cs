using Boxed.Mapping;
using CheckAct.BusinessLogic.Dto;
using CheckAct.BusinessLogic.Interfaces;
using CheckAct.Domain.Documents;

namespace CheckAct.BusinessLogic;

public class DocumentService(IDocumentStore documentStore, IImmutableMapper<DocumentDto, Document> mapper)
    : IDocumentService
{
    public async Task CreateAsync(DocumentDto dto)
    {
        // Validate(dto);

        var document = mapper.Map(dto);

        document = await documentStore.Add(document);
        document = null;
    }
}