using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkPLanningService.Domain.Enum;

namespace WorkPLanningService.Domain
{
    public class ShiftSchedule
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public  Shift  Shift { get; set; }
        [Required]
        public string ShiftHours { get; set; }
        [Required]
        public DateTime DateTime{ get; set; }
        public User User { get; set; }
    }
}
