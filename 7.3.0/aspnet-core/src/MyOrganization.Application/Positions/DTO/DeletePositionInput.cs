using Abp.Application.Services.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using Swashbuckle.SwaggerUi;
using MyOrganization.Positions;
using Abp.AutoMapper;

namespace MyOrganization.Positions
{

    [AutoMap(typeof(Positions.Position))]
    public class DeletePositionInput 
    {
        public int Id { get; set; }
        
    }
}
