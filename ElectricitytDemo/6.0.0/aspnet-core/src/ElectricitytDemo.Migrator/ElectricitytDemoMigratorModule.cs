using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ElectricitytDemo.Configuration;
using ElectricitytDemo.EntityFrameworkCore;
using ElectricitytDemo.Migrator.DependencyInjection;

namespace ElectricitytDemo.Migrator
{
    [DependsOn(typeof(ElectricitytDemoEntityFrameworkModule))]
    public class ElectricitytDemoMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ElectricitytDemoMigratorModule(ElectricitytDemoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ElectricitytDemoMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ElectricitytDemoConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ElectricitytDemoMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
