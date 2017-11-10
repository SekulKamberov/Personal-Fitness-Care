namespace PersonalFitnessCare.Server.Services
{
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;

    using PersonalFitnessCare.Server.Repositories;
    using PersonalFitnessCare.Server.Contracts;
    using PersonalFitnessCare.Server.Common;
    using PersonalFitnessCare.Server.Models.EntityModels;
    using PersonalFitnessCare.Server.Models.BindingModels;
    using PersonalFitnessCare.Server.Models.ViewModels;

    public class FitnessService : FitnessCalculationService, IFitnessService
    {
        private readonly IRepository<AddDayMuscle> dayWorkout;
        private readonly IRepository<PersonalDetails> personalDetails;
        //private readonly IUnitOfWork unitOfWork;

        public FitnessService(IRepository<AddDayMuscle> fitness, IRepository<PersonalDetails> details)
        {
            this.dayWorkout = fitness;
            this.personalDetails = details;
        }
        //Enable-Migration
        public async Task<AddDayMuscle> CreateProgram(AddDayMuscleBm dayMuscle, string id)
        {
            AddDayMuscle program = this.Calculate(id);
            AddDayMuscle userProgram = new AddDayMuscle()
            {
                UserId = dayMuscle.UserId,
                Exercises = dayMuscle.Exercises,
                /*Day = dayMuscle.Day,*//* Muscle = dayMuscle.Muscle,*/
                Sets = program.Sets, Reps = program.Reps, RestSets = program.RestSets, RestExercises = program.RestExercises
            };
            this.dayWorkout.Add(userProgram);
            await this.dayWorkout.SaveChangesAsync();

            return userProgram;  // To Do: Mapping from entity model to binding model !
        }

        private AddDayMuscle Calculate(string Id)
        {
            PersonalDetails model = personalDetails.All().Where(u => u.UserId == Id).FirstOrDefault();

            var sets = model.SportResults.Sets = ValidationConstants.Sets * ((int)model.FitnessExperience + 1); // base 2 sets
            var reps = model.SportResults.Reps = ValidationConstants.Reps - ((int)model.FitnessExperience - 2);  // base 10 reps
            var restSets = model.SportResults.RestSets = ValidationConstants.RestSets + ((int)model.FitnessExperience + 1); // 3 min base rest Sets
            var restExercises = model.SportResults.RestExercises = ValidationConstants.RestExercises + ((int)model.FitnessExperience + 1); // 3 min base rest Exercises

            var addDayMuscle = new AddDayMuscle
            {
                Sets = sets,
                Reps = reps,
                RestSets = restSets,
                RestExercises = restExercises
            };

            return addDayMuscle;
        }

        public bool ContainsDetails(object id)
        {
            return this.personalDetails.GetById(id) != null;
        }

        public void CreatePersonalDetails(PersonalDetailsBm details)
        {
            PersonalDetails model = Mapper.Instance.Map<PersonalDetailsBm, PersonalDetails>(details);
            this.personalDetails.Add(model);
            this.personalDetails.SaveChanges();
        }


        public DayWorkoutsVm WorkoutsById(string Id)
        {
            AddDayMuscle workoutDetails = dayWorkout.All().Where(u => u.UserId == Id).FirstOrDefault();
            DayWorkoutsVm vm = Mapper.Instance.Map<AddDayMuscle, DayWorkoutsVm>(workoutDetails);
            return vm;
        }

        public PersonalDetailsVm DetailsById(string Id)
        {
            PersonalDetails sportDetails = personalDetails.All().Where(u => u.UserId == Id).FirstOrDefault();
            //AddDayMuscle fitnessProgram = dayMuscle.All().Where(u => u.UserId == Id).FirstOrDefault();
            PersonalDetailsVm vm = Mapper.Instance.Map<PersonalDetails, PersonalDetailsVm>(sportDetails);
            return vm;
        }

        public void EditDetails(int id, EditDetailsBm bind, out bool isValid)
        {
            isValid = true;
            PersonalDetails model = personalDetails.GetById(id);
            model.Id = bind.Id;
            model.UserId = bind.UserId;
            model.FitnessExperience = bind.FitnessExperience;
            model.IntensityLevel = bind.IntensityLevel;
            model.Workouts = bind.Workouts;
            model.GoalTime = bind.GoalTime;
            model.Activity = bind.Activity;
            model.CardioActivity = bind.CardioActivity;
            model.Objectives = bind.Objectives;
            model.SportResults = bind.SportResults;
            if (this.personalDetails.GetById(bind.UserId) == null)
            {
                isValid = false;
                return;
            }

            this.personalDetails.SaveChanges();
        }      
    }
}