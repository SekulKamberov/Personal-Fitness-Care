namespace PersonalFitnessCare.Server.Models.EntityModels
{
    using System.Collections.Generic;

    public class FitnessProgram
    {
        public FitnessProgram()
        {
            this.DayMuscles = new HashSet<AddDayMuscle>();          
        }

        public string UserId { get; set; }

        public int PersonalDetailsId { get; set; }

        public PersonalDetails PersonalDetails { get; set; }

        public AddDayMuscle AddDayMuscle { get; set; }

        public virtual ICollection<AddDayMuscle> DayMuscles { get; set; }
    }
}