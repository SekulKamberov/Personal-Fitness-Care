namespace PersonalFitnessCare.Server.Models.EntityModels
{
    public class MuscleExercises  // Za vseki muscle group se slagat exercises 
    {

        public string User_Id { get; set; }

        public MuscleGroups MuscleGroup { get; set; }

        public Exercises Exercise { get; set; }

        public int Weight { get; set; }

        //public int RestSet { get; set; }

        //public int RestExercise { get; set; }

        // May be more properties about Objectives or FitnessExpiriance
    }
}