namespace PersonalFitnessCare.Server.Models.BindingModels
{
    using System.Collections.Generic;
    using PersonalFitnessCare.Server.Models.EntityModels;

    public class ExerciseModelBm
    {
        public string Day { get; set; }

        public string Muscle { get; set; }

        public string First { get; set; }

        public string Second { get; set; }

        public string Third { get; set; }

        public string Forth { get; set; }

        //public ICollection<Exercise> Exercises { get; set; }
    }
}