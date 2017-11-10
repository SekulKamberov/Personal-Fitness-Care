namespace PersonalFitnessCare.Server.Services
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using PersonalFitnessCare.Server.Contracts;
    using PersonalFitnessCare.Server.Models.EntityModels;
    using PersonalFitnessCare.Server.Repositories;

    public class ProfileService : IProfileService  
    {
        private readonly IRepository<PersonalDetails> profileDetails;

        public ProfileService(IRepository<PersonalDetails> profiles)
        {
            this.profileDetails = profiles;
        }


        public Task<PersonalDetails> AddNew(PersonalDetails personalDetails)
        {
            throw new NotImplementedException();
        }

        public int BaseMetabolism(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int CalorieBurned(Intensity Intensity, int weight, int time, Activity activity)
        {
            throw new NotImplementedException();
        }

        public int CurrentDailyBurned()
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(string UserId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PersonalDetails> DetailsById(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(string UserId, PersonalDetails personalDetails)
        {
            throw new NotImplementedException();
        }

        public int RemainingCalories()
        {
            throw new NotImplementedException();
        }

        public int TotalCalorieQuentity()
        {
            throw new NotImplementedException();
        }
    }
}