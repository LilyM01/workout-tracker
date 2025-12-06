using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.Models
{
    public class LiftType
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
