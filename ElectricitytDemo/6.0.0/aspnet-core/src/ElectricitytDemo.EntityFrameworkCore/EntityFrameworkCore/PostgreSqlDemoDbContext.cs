using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ElectricitytDemo.Authorization.Roles;
using ElectricitytDemo.Authorization.Users;
using ElectricitytDemo.MultiTenancy;
using Abp.Localization;

namespace ElectricitytDemo.EntityFrameworkCore
{
    public class ElectricitytDemoDbContext : AbpZeroDbContext<Tenant, Role, User, ElectricitytDemoDbContext>
    {
        public ElectricitytDemoDbContext(DbContextOptions<ElectricitytDemoDbContext> options)
            : base(options)
        {
        }

        // add these lines to override max length of property
        // we should set max length smaller than the PostgreSQL allowed size (10485760)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
