using BrokrService.Models;

namespace BrokrService.Service.Contracts
{
    public interface IClientService
    {
        Task<string> ClientSetUp(ClientDto client);
    }
}
