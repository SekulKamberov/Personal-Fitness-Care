namespace PersonalFitnessCare.Server.Models.EntityModels
{
    using System.ComponentModel.DataAnnotations;

    public class PersonalDetails  
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        public FitnessExperience FitnessExperience { get; set; }

        [Required]
        public Intensity IntensityLevel { get; set; }

        [Required]
        public int Workouts { get; set; }  // Weekly workouts

        [Required]
        public int GoalTime { get; set; }  // in months

        [Required]
        public Activity Activity { get; set; }

        [Required]
        public CardioActivity CardioActivity { get; set; }

        [Required]
        public Objectives Objectives { get; set; }

        [Required]
        public SportResults SportResults { get; set; }
    }
}