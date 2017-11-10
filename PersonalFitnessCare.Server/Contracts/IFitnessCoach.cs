namespace PersonalFitnessCare.Server.Contracts
{
    using PersonalFitnessCare.Server.Models;
    using PersonalFitnessCare.Server.Models.EntityModels;
    using System.Collections.Generic;

    public interface IFitnessCoach
    {
        int BaseMetabolism(int a, int b);

        int CalorieBurned(Intensity Intensity, int weight, int time, Activity activity);  // to calc how much user burning with his training

        int TotalCalorieQuentity();  // all calories needed to rich your goal.(slim in my case)

        int CurrentDailyBurned();  // daily burned

        int RemainingCalories();  // Remaining Calories to rich your Total Calorie Quentity (your goal to get slim)

        void PlanGenerator(ApplicationUser user);
            //  Objectives - 3 enums inside,   Intensity - 3 enums inside, FitnessExperience - 3 enumes inside.

            //  1. I have 3 fitness programes depending by Intensity level
            //  2. I have 3 fitness programes depending by Objectives level
            //  2. I have 3 fitness programes depending by FitnessExperience level


    }
}
