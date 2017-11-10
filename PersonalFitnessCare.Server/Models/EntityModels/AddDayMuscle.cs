namespace PersonalFitnessCare.Server.Models.EntityModels
{
    using PersonalFitnessCare.Server.Common.Validation;
    using PersonalFitnessCare.Server.Models.BindingModels;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AddDayMuscle
    {
        public AddDayMuscle()
        {
            this.Exercises = new HashSet<ExerciseModel>();
        }
        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual ICollection<ExerciseModel> Exercises { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }

        public int RestSets { get; set; }

        public int RestExercises { get; set; }
    }
}