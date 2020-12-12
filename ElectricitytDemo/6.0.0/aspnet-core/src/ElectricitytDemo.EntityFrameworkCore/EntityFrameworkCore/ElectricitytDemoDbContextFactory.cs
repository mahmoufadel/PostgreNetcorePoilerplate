using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ElectricitytDemo.Configuration;
using ElectricitytDemo.Web;

namespace ElectricitytDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ElectricitytDemoDbContextFactory : IDesignTimeDbContextFactory<ElectricitytDemoDbContext>
    {
        public ElectricitytDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ElectricitytDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ElectricitytDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ElectricitytDemoConsts.ConnectionStringName));

            return new ElectricitytDemoDbContext(builder.Options);
        }

		
	}
}
