using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ElectricitytDemo.Authorization;

namespace ElectricitytDemo
{
    [DependsOn(
        typeof(ElectricitytDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ElectricitytDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ElectricitytDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ElectricitytDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
