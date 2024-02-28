using Microsoft.AspNetCore.SignalR;
using Mona.Service;

namespace Mona.Hub;

public class SimpleHub(IMessageService service) : Hub<IHubInterfaces>
{
    public async Task Send(string message)
    { 
        service.CreateMessage(message);
        await Clients.All.ReceiveMessage(message);
    }

    public async Task<IEnumerable<string>> GetHistory()
    {
        var messages = await service.GetMessages();
        return messages;
    }
}