using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.Models
{
    public class WorkoutModel
    {
        public WorkoutModel()
        {
            this.LiftSets = new List<LiftSet>();
        }
        public int Id { get; set; }

        [Required]
        public string? Name{ get; set; }

        public List<LiftSet> LiftSets { get; set; } = new List<LiftSet>();
    }

    public class LiftSet
    {
        public int Id { get; set; }

        [Required]
        public string? LiftName { get; set; }

        public int SetCount { get; set; }

        public decimal RepCount { get; set; }
        [Required]
        public string? RepUnit { get; set; }

        public decimal Weight { get; set; }
        public string? WeightUnit { get; set; }
    }


}
