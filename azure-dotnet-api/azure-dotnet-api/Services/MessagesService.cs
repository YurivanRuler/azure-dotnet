using azure_dotnet_api.Models;
using azure_dotnet_api.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace azure_dotnet_api.Services
{
    public class MessagesService : IMessagesService
    {
        private readonly IMessagesRepository _messagesRepository;

        public MessagesService(IMessagesRepository messagesRepository)
        {
            _messagesRepository = messagesRepository;
        }

        public async Task AddMessageAsync(MessageEntity message)
        {
            await _messagesRepository.UpsertMessage(message);
        }

        public Task<IEnumerable<MessageEntity>> GetMessages()
        {
            return _messagesRepository.GetMessages();
        }
    }
}
