using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyOrganization.Controllers
{
    public abstract class MyOrganizationControllerBase: AbpController
    {
        protected MyOrganizationControllerBase()
        {
            LocalizationSourceName = MyOrganizationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
