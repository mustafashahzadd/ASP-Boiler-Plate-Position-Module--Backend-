using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyOrganization.Authorization;

namespace MyOrganization
{
    [DependsOn(
        typeof(MyOrganizationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyOrganizationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyOrganizationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyOrganizationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
