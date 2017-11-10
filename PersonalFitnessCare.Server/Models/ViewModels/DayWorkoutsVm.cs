namespace PersonalFitnessCare.Server.Models.ViewModels
{
    public class DayWorkoutsVm
    {
        public string UserId { get; set; }

        public string Day { get; set; }

        public string MuscleGroup { get; set; }

        public string FirstExercise { get; set; }

        public string SecondExercise { get; set; }

        public string ThirdExercise { get; set; }

        public string ForthExercise { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }

        public int RestSets { get; set; }

        public int RestExercises { get; set; }
    }
}