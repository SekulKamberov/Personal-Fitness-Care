namespace PersonalFitnessCare.Server
{
    using System.Data.Entity;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using AutoMapper;

    using PersonalFitnessCare.Server.Migrations;
    using PersonalFitnessCare.Server.Models;
    using PersonalFitnessCare.Server.Models.EntityModels;
    using PersonalFitnessCare.Server.Models.BindingModels;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

            ConfigureMapper();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMapper()  // tova e configuracia na maper-a
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<AddDayMuscle, AddDayMuscleBm>();
                expression.CreateMap<AddDayMuscleBm, AddDayMuscle>();
                expression.CreateMap<PersonalDetails, PersonalDetailsBm>();
                expression.CreateMap<PersonalDetailsBm, PersonalDetails>();
            });
        }
    }
}
