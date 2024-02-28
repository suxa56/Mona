using Mona.Dto;

namespace Mona.Service;

public interface IMessageService
{ 
    void CreateMessage(string text);
    Task<IEnumerable<string>> GetMessages();
}