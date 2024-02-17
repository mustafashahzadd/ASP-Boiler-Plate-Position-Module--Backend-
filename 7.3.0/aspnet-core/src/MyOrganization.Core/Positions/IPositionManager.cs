using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrganization.Positions
{
    public interface IPositionManager : IDomainService
    {
        IEnumerable<Position> GetAllList();
        Position GetPositionByID(int id);
        Task<Position> Create(Position position);
        Task<Position> Update(Position position);
        void Delete(int  id);
    }
}
