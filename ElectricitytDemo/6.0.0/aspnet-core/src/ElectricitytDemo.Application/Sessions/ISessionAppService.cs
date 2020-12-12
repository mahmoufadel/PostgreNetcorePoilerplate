using System.Threading.Tasks;
using Abp.Application.Services;
using ElectricitytDemo.Sessions.Dto;

namespace ElectricitytDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
