namespace PersonalFitnessCare.Server.Contracts
{
    using PersonalFitnessCare.Server.Models.EntityModels;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IProfileService : IService
    {
        // To stay or not
        int BaseMetabolism(int a, int b);

        int CalorieBurned(Intensity Intensity, int weight, int time, Activity activity);  // to calc how much user burning with his training

        int TotalCalorieQuentity();  // all calories needed to rich your goal.(slim in my case)

        int CurrentDailyBurned();  // daily burned

        int RemainingCalories();  // Remaining Calories to rich your Total Calorie Quentity (your goal to get slim)

        //void CreateProgram


        IQueryable<PersonalDetails> DetailsById(string UserId);

        Task<PersonalDetails> AddNew(PersonalDetails personalDetails);

        Task Edit(string UserId, PersonalDetails personalDetails);

        Task DeleteById(string UserId);
    }
}
