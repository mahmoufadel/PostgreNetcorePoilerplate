using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ElectricitytDemo.Configuration;

namespace ElectricitytDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(ElectricitytDemoWebCoreModule))]
    public class ElectricitytDemoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ElectricitytDemoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ElectricitytDemoWebHostModule).GetAssembly());
        }
    }
}
