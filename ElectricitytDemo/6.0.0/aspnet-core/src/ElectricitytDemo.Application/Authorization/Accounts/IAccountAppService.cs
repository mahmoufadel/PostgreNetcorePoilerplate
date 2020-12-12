using System.Threading.Tasks;
using Abp.Application.Services;
using ElectricitytDemo.Authorization.Accounts.Dto;

namespace ElectricitytDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
