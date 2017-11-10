namespace PersonalFitnessCare.Server.Contracts
{
    using PersonalFitnessCare.Server.Models.BindingModels;
    using PersonalFitnessCare.Server.Models.EntityModels;
    using PersonalFitnessCare.Server.Models.ViewModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IFitnessService
    {
        bool ContainsDetails(object id);

        void CreatePersonalDetails(PersonalDetailsBm details);

        void EditDetails(int id, EditDetailsBm bind, out bool isValid);

        DayWorkoutsVm WorkoutsById(string Id);

        PersonalDetailsVm DetailsById(string Id);

        Task<AddDayMuscle> CreateProgram(AddDayMuscleBm daymuscle, string id);
    }
}
       