using CheckAct.BusinessLogic.Dto;

namespace CheckAct.BusinessLogic.Interfaces;

public interface IDocumentService
{
    Task CreateAsync(DocumentDto document);
}