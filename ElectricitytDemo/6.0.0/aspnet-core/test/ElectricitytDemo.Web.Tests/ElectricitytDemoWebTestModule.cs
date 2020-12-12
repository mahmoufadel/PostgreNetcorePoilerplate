using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ElectricitytDemo.EntityFrameworkCore;
using ElectricitytDemo.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ElectricitytDemo.Web.Tests
{
    [DependsOn(
        typeof(ElectricitytDemoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ElectricitytDemoWebTestModule : AbpModule
    {
        public ElectricitytDemoWebTestModule(ElectricitytDemoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ElectricitytDemoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ElectricitytDemoWebMvcModule).Assembly);
        }
    }
}