using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyOrganization.Configuration.Dto;

namespace MyOrganization.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyOrganizationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
