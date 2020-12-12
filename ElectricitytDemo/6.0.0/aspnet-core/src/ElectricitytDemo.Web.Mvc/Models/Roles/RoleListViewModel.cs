using System.Collections.Generic;
using ElectricitytDemo.Roles.Dto;

namespace ElectricitytDemo.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
