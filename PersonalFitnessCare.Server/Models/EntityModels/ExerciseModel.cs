using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalFitnessCare.Server.Models.EntityModels
{
    public class ExerciseModel
    {
        public string Id { get; set; }

        public string AddDayMuscleId { get; set; }

        public string Day { get; set; }

        public string Muscle { get; set; }

        public string First { get; set; }

        public string Second { get; set; }

        public string Third { get; set; }

        public string Forth { get; set; }
    }
}