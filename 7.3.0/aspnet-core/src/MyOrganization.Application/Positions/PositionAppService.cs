using Abp.Application.Services;
using MyOrganization.Position.DTO;
using MyOrganization.Positions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyOrganization.Position;

namespace MyOrganization.Positions
{
    public class PositionAppService : ApplicationService, IPositionAppService
    {
        private readonly IPositionManager positionManager;

        public PositionAppService(IPositionManager positionManager)
        {
            this.positionManager = positionManager;
        }

        public async Task Create(CreatePositionInput input)
        {
            var output = ObjectMapper.Map<Position>(input);
            await positionManager.Create(output);
        }

        public void  Delete(int input)
        {
           // var output = ObjectMapper.Map<Position>(input);
             positionManager.Delete(input);
        }

        public async Task<IEnumerable<GetPositonOutput>> Get()
        {
            var getAll = positionManager.GetAllList().ToList();
            return ObjectMapper.Map<IEnumerable<GetPositonOutput>>(getAll);
        }

        public async Task Update(UpdatePositionInput input)
        {
            var output = ObjectMapper.Map<Position>(input);
            await positionManager.Update(output);
        }
    }
}
