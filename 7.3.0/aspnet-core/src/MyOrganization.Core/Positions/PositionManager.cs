using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyOrganization.Positions
{
    public class PositionManager : DomainService, IPositionManager
    {
        private readonly IRepository<Position> _positionRepository; 

        public PositionManager(IRepository<Position> positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public async Task<Position> Create(Position position)
        {
            var existingPosition = await _positionRepository.FirstOrDefaultAsync(p => p.Id == position.Id);
            if (existingPosition != null)
            {
                throw new UserFriendlyException("Position already exists!");
            }
            else
            {
                return await _positionRepository.InsertAsync(position);
            }
        }

        public void Delete(int id)
        {
            var existingPosition =  _positionRepository.FirstOrDefault(p => p.Id == id);
            if (existingPosition == null)
            {
                throw new UserFriendlyException("Position not found!");
            }
            else
            {
                 _positionRepository.Delete(existingPosition.Id);
            }
        }

       public  IEnumerable<Position> GetAllList()
        {
            return _positionRepository.GetAllList();
        }
           
        public Position GetPositionByID(int id)
        {
            return _positionRepository.Get(id);
        }

        public async Task<Position> Update(Position position)
        {
              var positionToUpdate = await _positionRepository.GetAsync(position.Id);
           // var existingPosition = await _positionRepository.FirstOrDefaultAsync(p => p.Id == position.Id);

            if (positionToUpdate == null)
            {
                throw new UserFriendlyException("Position not found!");
            }
            else
            {
                positionToUpdate.PositionType = position.PositionType;
                positionToUpdate.PositionName = position.PositionName;
                positionToUpdate.WorkDescription = position.WorkDescription;

                return await _positionRepository.UpdateAsync(positionToUpdate);
            }
        }
    }
}
