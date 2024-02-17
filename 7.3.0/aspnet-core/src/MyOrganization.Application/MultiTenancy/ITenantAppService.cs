using Abp.Application.Services;
using MyOrganization.MultiTenancy.Dto;

namespace MyOrganization.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

