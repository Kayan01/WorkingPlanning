using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPlanningService.Application.Dto.RequestDto
{
    public class ShiftScheduleRequestDto
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string ShiftHours { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
