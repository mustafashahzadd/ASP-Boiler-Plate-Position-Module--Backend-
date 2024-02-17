using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyOrganization.Configuration;

namespace MyOrganization.Web.Host.Startup
{
    [DependsOn(
       typeof(MyOrganizationWebCoreModule))]
    public class MyOrganizationWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyOrganizationWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyOrganizationWebHostModule).GetAssembly());
        }
    }
}
