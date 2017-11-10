namespace PersonalFitnessCare.Server.Models.EntityModels
{
    using System.Collections.Generic;

    public class SportResults  // za vsqka muskulna grupa 
    {
        public SportResults()
        {
            this.MuscleExercises = new HashSet<MuscleExercises>();
        }

        public MuscleExercises MuscleExercise { get; set; }

        public string User_Id { get; set; }

        public int PersonalDetailsId { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }

        public virtual ICollection<MuscleExercises> MuscleExercises { get; set; }

        public int RestSets { get; set; }

        public int RestReps { get; set; } 

        public int RestExercises { get; set; }

        //public int Weights { get; set; }

        // NextLevel - class or enum to calculate next level, goals are separated by levels
        //public NextLevel NextLevel { get; set; }  

    }
}