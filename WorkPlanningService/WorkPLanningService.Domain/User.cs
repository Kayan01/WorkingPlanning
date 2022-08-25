using System.ComponentModel.DataAnnotations;

namespace WorkPLanningService.Domain
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
        public ShiftSchedule ShiftSchedule { get; set; }
    }
}