using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.ComponentModel.DataAnnotations;
using PersonalFitnessCare.Server.Models.EntityModels;
using System.Data.Entity;

namespace PersonalFitnessCare.Server.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        public string DisplayName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public Country Country { get; set; }

        [Required]
        public Gander Gander { get; set; }

        [Required]
        public Objectives Objectives { get; set; }

        //new properties
        [Required]
        public FitnessExperience FitnessExperience { get; set; }

        [Required]
        public Intensity IntensityLevel { get; set; }

        [Required]
        public int Workouts { get; set; }  // Weekly workouts

        [Required]
        public int GoalTime { get; set; }  // in months

        [Required]
        public Activity Activity { get; set; }

        [Required]
        public CardioActivity CardioActivity { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
        public IDbSet<AddDayMuscle> DayExercises { get; set; }

        public IDbSet<ExerciseModel> Exercises { get; set; }
    }
}