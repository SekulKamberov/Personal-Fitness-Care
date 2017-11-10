namespace PersonalFitnessCare.Server.Controllers
{
    using System.Threading.Tasks;
    using System.Net;
    using System.Web.Http;

    using Microsoft.AspNet.Identity;
    
    using PersonalFitnessCare.Server.Contracts;
    using PersonalFitnessCare.Server.Models.ViewModels;
    using PersonalFitnessCare.Server.Models.BindingModels;
    using PersonalFitnessCare.Server.Validation;
   

    [Authorize]
    [RoutePrefix("api/Info")]
    public class InfoController : ApiController
    {
        private readonly IFitnessService fitnessService;
        //private readonly IUserService userService;

        public InfoController(IFitnessService fitness)
        {
           
            this.fitnessService = fitness;
        }

        #region Get WorkoutDetails   

        [HttpGet]
        public IHttpActionResult WorkoutDetails(string id)
        {
            if (!this.fitnessService.ContainsDetails(id))
            {
                return this.NotFound();
            }

            DayWorkoutsVm result = fitnessService.WorkoutsById(id);
            return this.Ok(result);
        }

        #endregion

        #region Get SportDetails   

        [HttpGet]
        public IHttpActionResult SportDetails(string id)
        {
            if (!this.fitnessService.ContainsDetails(id))
            {
                return this.NotFound();
            }

            PersonalDetailsVm result = fitnessService.DetailsById(id);
            return this.Ok(result);
        }

        #endregion

        #region AddFitnessDay
        [HttpPost]
        [Route("AddDetails")]
        public IHttpActionResult AddDetails(PersonalDetailsBm personalDetails)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.fitnessService.CreatePersonalDetails(personalDetails);
            return this.StatusCode(HttpStatusCode.Created);
        }
        #endregion

        #region AddTrainingDay
        [Authorize]
        [HttpPost]
        [ValidateModel]
        public async Task<IHttpActionResult> AddTrainingDay(AddDayMuscleBm project)
        {
            var id = User.Identity.GetUserId();
            var addDayTraining = await this.fitnessService.CreateProgram(project, id);

            return this.Ok(addDayTraining.UserId);
        }
        #endregion
        
    }
}