using Abp.Authorization;
using ElectricitytDemo.Authorization.Roles;
using ElectricitytDemo.Authorization.Users;

namespace ElectricitytDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
