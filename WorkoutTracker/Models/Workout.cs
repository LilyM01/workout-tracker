using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.Models
{
    public class Workout
    {
        public int Id { get; set; }

        [Required]
        public string? Name{ get; set; }

        public List<LiftSet>? LiftSets { get; set; } = new List<LiftSet>();
        //list of lifttypes
    }
}
