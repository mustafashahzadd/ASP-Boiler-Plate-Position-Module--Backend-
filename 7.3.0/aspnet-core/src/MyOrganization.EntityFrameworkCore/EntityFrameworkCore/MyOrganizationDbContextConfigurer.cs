using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyOrganization.EntityFrameworkCore
{
    public static class MyOrganizationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyOrganizationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyOrganizationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
