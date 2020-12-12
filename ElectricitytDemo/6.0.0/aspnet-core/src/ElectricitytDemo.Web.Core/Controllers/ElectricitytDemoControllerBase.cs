using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ElectricitytDemo.Controllers
{
    public abstract class ElectricitytDemoControllerBase: AbpController
    {
        protected ElectricitytDemoControllerBase()
        {
            LocalizationSourceName = ElectricitytDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
