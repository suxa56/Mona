using Microsoft.EntityFrameworkCore;
using Mona.Context;
using Mona.Model;

namespace Mona.Service;

public class MessageService(MessageContext context) : IMessageService
{
    public async void CreateMessage(string text)
    {
        if (string.IsNullOrEmpty(text)) return;
        context.Messages.Add(new MessageItem { Text = text });
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<string>> GetMessages()
    {
       return await context.Messages.AsNoTracking().Select(item => item.Text ).ToListAsync();
    }
}