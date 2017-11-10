namespace PersonalFitnessCare.Server.Common.Configurations
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using AutoMapper;

    using PersonalFitnessCare.Server.Common.Mapping;
    using PersonalFitnessCare.Server.Models.BindingModels;
    using PersonalFitnessCare.Server.Models.EntityModels;
    using PersonalFitnessCare.Server.Models.ViewModels;

    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddDayMuscleBm, AddDayMuscle>();  // i posle dobavqm samo .ProjectTo<AddDayMuscle>() i zapisvam v bazata tva na servic-a
            CreateMap<AddDayMuscle, AddDayMuscleBm>();
            CreateMap<AddDayMuscle, DayWorkoutsVm>();
        }
        //public static void RegisterMappings(params Assembly[] assemblies)
        //{
        //    Mapper.Configuration.ConstructServicesUsing(t => DependencyResolver.Current.GetService(t));

        //    var types = new List<Type>();
        //    foreach (var assembly in assemblies)
        //    {
        //        types.AddRange(assembly.GetExportedTypes());
        //    }

        //    LoadStandardMappings(types);
        //    LoadCustomMappings(types);

        //    ExplicitMaps.AddMaps(Mapper.Configuration);
        //}

        //private static void LoadStandardMappings(IEnumerable<Type> types)
        //{
        //    var maps = types.SelectMany(t => t.GetInterfaces(), (t, i) => new { t, i })
        //        .Where(
        //            type =>
        //                type.i.IsGenericType && type.i.GetGenericTypeDefinition() == typeof(IMapFrom<>) &&
        //                !type.t.IsAbstract
        //                && !type.t.IsInterface)
        //        .Select(type => new { Source = type.i.GetGenericArguments()[0], Destination = type.t });

        //    foreach (var map in maps)
        //    {
        //        Mapper.CreateMap(map.Source, map.Destination);
        //        Mapper.CreateMap(map.Destination, map.Source);
        //    }
        //}

        //private static void LoadCustomMappings(IEnumerable<Type> types)
        //{
        //    var maps =
        //        types.SelectMany(t => t.GetInterfaces(), (t, i) => new { t, i })
        //            .Where(
        //                type =>
        //                    typeof(IHaveCustomMappings).IsAssignableFrom(type.t) && !type.t.IsAbstract &&
        //                    !type.t.IsInterface)
        //            .Select(type => (IHaveCustomMappings)Activator.CreateInstance(type.t));

        //    foreach (var map in maps)
        //    {
        //        map.CreateMappings(Mapper.Configuration);
        //    }
        //}
    }
}