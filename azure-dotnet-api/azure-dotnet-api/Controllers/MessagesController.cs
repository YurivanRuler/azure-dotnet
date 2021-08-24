using azure_dotnet_api.Models;
using azure_dotnet_api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace azure_dotnet_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly IMessagesService _messagesService;

        public MessagesController(IMessagesService messagesService)
        {
            _messagesService = messagesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMessages()
        {
            return Ok(await _messagesService.GetMessages());
        }

        [HttpPost]
        public async Task<IActionResult> PostMessageAsync(MessageModel message)
        {
            MessageEntity messageEntity = new(message.Message);

            await _messagesService.AddMessageAsync(messageEntity);
            return Ok();
        }
    }
}
