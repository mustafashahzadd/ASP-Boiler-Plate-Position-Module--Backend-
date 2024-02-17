using Abp.Application.Services;
using MyOrganization.Position.DTO;
using MyOrganization.Positions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyOrganization.Position
{
    public interface IPositionAppService : IApplicationService
    {
        Task<IEnumerable<GetPositonOutput>> Get();
        Task Create(CreatePositionInput input);
        Task Update(UpdatePositionInput input);
        void Delete(int  input);
        // GetPositonOutput GetPositionById(GetPositonOutput input);
    }
}
