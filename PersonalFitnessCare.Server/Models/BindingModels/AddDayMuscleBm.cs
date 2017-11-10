namespace PersonalFitnessCare.Server.Models.BindingModels
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;

    using PersonalFitnessCare.Server.Models.EntityModels;
    using PersonalFitnessCare.Server.Common;
    using PersonalFitnessCare.Server.Common.Mapping;
    using PersonalFitnessCare.Server.Common.Validation;
    using AutoMapper.Configuration;


    public class AddDayMuscleBm : BaseInfoBm/*, IMapFrom<AddDayMuscle>, IHaveCustomMappings, IValidatableObject*/
    {
        public string UserId { get; set; }

        //[Required]
        //[OnlyEnglish]
        //public string Day { get; set; }

        public ICollection<ExerciseModel> Exercises { get; set; }
        

        //public static Func<AddDayMuscleBm, AddDayMuscle> AddDayMuscle
        //{
        //    get
        //    {
        //        return dayMuscle => new AddDayMuscle
        //        {
        //            OriginalFileName = dayMuscle.OriginalFileName,
        //            FileExtension = dayMuscle.FileExtension,
        //            Content = dayMuscle.ByteArrayContent
        //        };
        //    }
        //}
    }
}