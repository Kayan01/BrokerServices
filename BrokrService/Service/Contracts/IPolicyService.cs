using BrokrService.Models;

namespace BrokrService.Service.Contracts
{
    public interface IPolicyService
    {
        Task<ResponseModel> PolicySetUpAsync(PolicyDto policy);
    }
}
