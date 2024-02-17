using System.Threading.Tasks;
using MyOrganization.Configuration.Dto;

namespace MyOrganization.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
