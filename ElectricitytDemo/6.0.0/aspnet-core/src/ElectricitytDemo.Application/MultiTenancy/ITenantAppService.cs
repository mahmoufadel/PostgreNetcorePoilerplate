using Abp.Application.Services;
using ElectricitytDemo.MultiTenancy.Dto;

namespace ElectricitytDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

