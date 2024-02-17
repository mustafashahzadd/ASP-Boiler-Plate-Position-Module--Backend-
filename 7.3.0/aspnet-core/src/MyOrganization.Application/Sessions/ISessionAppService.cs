using System.Threading.Tasks;
using Abp.Application.Services;
using MyOrganization.Sessions.Dto;

namespace MyOrganization.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
