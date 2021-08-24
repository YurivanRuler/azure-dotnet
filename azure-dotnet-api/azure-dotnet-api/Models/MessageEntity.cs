using Azure;
using Azure.Data.Tables;
using System;

namespace azure_dotnet_api.Models
{
    public class MessageEntity : ITableEntity
    {
        public MessageEntity()
        {
        }

        public MessageEntity(string message)
        {
            PartitionKey = DateTime.Now.ToString("yyyy-MM-dd");
            RowKey = Guid.NewGuid().ToString();
            Message = message;
        }

        public string Message { get; set; }

        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}
