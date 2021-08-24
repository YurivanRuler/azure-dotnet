using azure_dotnet_api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace azure_dotnet_api.Repositories
{
    public interface IMessagesRepository
    {
        public Task UpsertMessage(MessageEntity message);
        public Task<IEnumerable<MessageEntity>> GetMessages();
    }
}
