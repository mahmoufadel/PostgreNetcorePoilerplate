using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ElectricitytDemo.Web.Views
{
    public abstract class ElectricitytDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ElectricitytDemoRazorPage()
        {
            LocalizationSourceName = ElectricitytDemoConsts.LocalizationSourceName;
        }
    }
}
