using Azure.Data.Tables;
using azure_dotnet_api.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace azure_dotnet_api.Repositories
{
    public class MessagesRepository : IMessagesRepository
    {
        private readonly IConfiguration _configuration;

        public MessagesRepository(IConfiguration configure)
        {
            _configuration = configure;
        }

        public async Task UpsertMessage(MessageEntity message)
        {
            if (message == null)
            {
                throw new ArgumentException("Message cannot be null");
            }

            TableClient tableClient = await GetTableClient();

            await tableClient.UpsertEntityAsync(message);
        }

        public async Task<IEnumerable<MessageEntity>> GetMessages()
        {
            TableClient tableClient = await GetTableClient();
            return tableClient.Query<MessageEntity>();
        }

        public TableServiceClient GetTableServiceClient()
        {
            string connectionString = _configuration.GetConnectionString("StorageConnectionString");
            return new TableServiceClient(connectionString);
        }

        public async Task<TableClient> GetTableClient()
        {
            string tableName = "Messages";
            TableClient tableClient = GetTableServiceClient().GetTableClient(tableName);
            await CreateTableIfNotExists(tableClient);
            return tableClient;
        }

        public async Task CreateTableIfNotExists(TableClient tableClient)
        {
            await tableClient.CreateIfNotExistsAsync();
        }
    }
}
