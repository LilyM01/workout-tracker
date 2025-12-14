using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.Models
{
    public class LogInModel
    {
        public int Id { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
