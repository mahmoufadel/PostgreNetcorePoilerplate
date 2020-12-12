using Abp.Application.Services.Dto;

namespace ElectricitytDemo.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

