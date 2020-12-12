using System.Collections.Generic;
using ElectricitytDemo.Roles.Dto;

namespace ElectricitytDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
