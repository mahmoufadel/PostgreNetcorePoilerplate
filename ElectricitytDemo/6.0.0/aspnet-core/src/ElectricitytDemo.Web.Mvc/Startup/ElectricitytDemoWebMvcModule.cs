using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ElectricitytDemo.Configuration;

namespace ElectricitytDemo.Web.Startup
{
    [DependsOn(typeof(ElectricitytDemoWebCoreModule))]
    public class ElectricitytDemoWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ElectricitytDemoWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ElectricitytDemoNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ElectricitytDemoWebMvcModule).GetAssembly());
        }
    }
}
