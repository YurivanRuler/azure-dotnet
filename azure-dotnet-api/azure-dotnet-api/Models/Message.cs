using System;

namespace azure_dotnet_api.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageBody { get; set; }
        public DateTime DateTime { get; set; }
    }
}
