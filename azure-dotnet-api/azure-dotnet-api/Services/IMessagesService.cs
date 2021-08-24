using azure_dotnet_api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace azure_dotnet_api.Services
{
    public interface IMessagesService
    {
        Task<IEnumerable<MessageEntity>> GetMessages();
        Task AddMessageAsync(MessageEntity message);
    }
}
