namespace PersonalFitnessCare.Server.Models.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class PersonalDetailsBm
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        public string FitnessExperience { get; set; }

        [Required]
        public string IntensityLevel { get; set; }

        [Required]
        public int Workouts { get; set; }  // Weekly workouts

        [Required]
        public int GoalTime { get; set; }  // in months

        [Required]
        public string Activity { get; set; }

        [Required]
        public string CardioActivity { get; set; }

        [Required]
        public string Objectives { get; set; }

        [Required]
        public string SportResults { get; set; }
    }
}