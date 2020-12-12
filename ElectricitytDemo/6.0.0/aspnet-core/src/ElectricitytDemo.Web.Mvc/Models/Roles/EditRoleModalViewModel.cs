using Abp.AutoMapper;
using ElectricitytDemo.Roles.Dto;
using ElectricitytDemo.Web.Models.Common;

namespace ElectricitytDemo.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
