using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyOrganization.EntityFrameworkCore;
using MyOrganization.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyOrganization.Web.Tests
{
    [DependsOn(
        typeof(MyOrganizationWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyOrganizationWebTestModule : AbpModule
    {
        public MyOrganizationWebTestModule(MyOrganizationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyOrganizationWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyOrganizationWebMvcModule).Assembly);
        }
    }
}