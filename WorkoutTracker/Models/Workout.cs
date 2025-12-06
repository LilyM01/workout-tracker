using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.Models
{
    public class Workout
    {
        public int Id { get; set; }

        [Required]
        public string? Name{ get; set; }

        //list of lifttypes
    }
}
