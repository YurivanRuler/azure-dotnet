using azure_dotnet_api.Models;
using System.Collections.Generic;

namespace azure_dotnet_api.Services
{
    public interface IMessagesService
    {
        IList<Message> GetMessages();
    }
}
