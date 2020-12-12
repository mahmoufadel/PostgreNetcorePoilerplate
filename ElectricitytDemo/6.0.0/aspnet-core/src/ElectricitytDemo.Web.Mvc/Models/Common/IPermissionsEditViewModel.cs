using System.Collections.Generic;
using ElectricitytDemo.Roles.Dto;

namespace ElectricitytDemo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}