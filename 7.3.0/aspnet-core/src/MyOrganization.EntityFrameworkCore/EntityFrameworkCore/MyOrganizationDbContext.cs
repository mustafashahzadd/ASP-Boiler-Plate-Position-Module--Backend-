using Microsoft.EntityFrameworkCore;
using MyOrganization.Positions;
using Abp.Zero.EntityFrameworkCore;
using MyOrganization.Authorization.Roles;
using MyOrganization.Authorization.Users;
using MyOrganization.MultiTenancy;

namespace MyOrganization.EntityFrameworkCore
{
    public class MyOrganizationDbContext : AbpZeroDbContext<Tenant, Role, User, MyOrganizationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DbSet<Position> Postions { get; set; }
        public MyOrganizationDbContext(DbContextOptions<MyOrganizationDbContext> options)
            : base(options)
        {
        }
    }
}
