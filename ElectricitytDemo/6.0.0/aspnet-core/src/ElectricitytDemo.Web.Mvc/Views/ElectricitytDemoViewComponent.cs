using Abp.AspNetCore.Mvc.ViewComponents;

namespace ElectricitytDemo.Web.Views
{
    public abstract class ElectricitytDemoViewComponent : AbpViewComponent
    {
        protected ElectricitytDemoViewComponent()
        {
            LocalizationSourceName = ElectricitytDemoConsts.LocalizationSourceName;
        }
    }
}
