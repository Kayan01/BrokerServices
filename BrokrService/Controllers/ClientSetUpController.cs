using BrokrService.Models;
using BrokrService.Service;
using BrokrService.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrokrService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientSetUpController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientSetUpController(IClientService clientService)
        {
            _clientService = clientService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(ResponseModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> ClientSetUpAsync(ClientDto client)
        {
            string clientNo =  await _clientService.ClientSetUp(client);
            return Ok(clientNo);
        }
    }
}
