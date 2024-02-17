using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;


namespace MyOrganization.Position.DTO
{
    [AutoMap(typeof(Positions.Position))]
    public class GetPositonOutput
    {
        public string PositionType { get; set; }
        public string PositionName { get; set; }
        public string WorkDescription { get; set; }

    }
}
