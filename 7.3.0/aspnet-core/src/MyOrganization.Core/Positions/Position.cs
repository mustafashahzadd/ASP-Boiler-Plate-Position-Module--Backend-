using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MyOrganization.Positions
{

    
    public class Position : FullAuditedEntity
    {
        [Required(ErrorMessage = "Position type is required.")]
        [StringLength(50, ErrorMessage = "Position type cannot exceed 50 characters.")]
        public string PositionType { get; set; }

        [StringLength(100, ErrorMessage = "Position name cannot exceed 100 characters.")]
        public string PositionName { get; set; }

        [Required(ErrorMessage = "Work description is required.")]
        [StringLength(200, ErrorMessage = "Work description cannot exceed 200 characters.")]
        public string WorkDescription { get; set; }
    }
}
