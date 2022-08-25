using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkPLanningService.Domain.Enum;

namespace WorkPlanningService.Application.Dto.ResponseDto
{
    public class ShiftScheduleResponseDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Shift Shift { get; set; }
        public string ShiftHours { get; set; }
        public DateTime DateTime { get; set; }
    }
}
