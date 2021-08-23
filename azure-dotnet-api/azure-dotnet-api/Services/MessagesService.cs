using azure_dotnet_api.Models;
using System;
using System.Collections.Generic;

namespace azure_dotnet_api.Services
{
    public class MessagesService : IMessagesService
    {
        public IList<Message> GetMessages()
        {
            List<Message> messages = new();
            messages.Add(new Message() { Id = 1, MessageBody = "First Message", DateTime = DateTime.Now });
            messages.Add(new Message() { Id = 2, MessageBody = "Second Message", DateTime = DateTime.Now });
            messages.Add(new Message() { Id = 3, MessageBody = "Third Message", DateTime = DateTime.Now });
            messages.Add(new Message() { Id = 4, MessageBody = "Fourth Message", DateTime = DateTime.Now });
            messages.Add(new Message() { Id = 5, MessageBody = "Fifth Message", DateTime = DateTime.Now });

            return messages;
        }
    }
}
