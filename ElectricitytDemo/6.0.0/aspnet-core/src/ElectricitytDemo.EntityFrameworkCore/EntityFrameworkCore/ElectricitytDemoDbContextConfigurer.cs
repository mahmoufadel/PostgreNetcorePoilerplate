using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ElectricitytDemo.EntityFrameworkCore
{
  /*  public static class ElectricitytDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ElectricitytDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ElectricitytDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }*/

    public static class ElectricitytDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ElectricitytDemoDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ElectricitytDemoDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
