namespace PersonalFitnessCare.Server.Models.BindingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using PersonalFitnessCare.Server.Common;
    using PersonalFitnessCare.Server.Common.Validation;

    public class BaseInfoBm
    {
        private string liveDemoUrl;

        [Required]
        [MinLength(ValidationConstants.MinProjectTitleLength, ErrorMessage = ValidationConstants.MinLengthErrorMessage)]
        [MaxLength(ValidationConstants.MaxProjectTitleLength, ErrorMessage = ValidationConstants.MaxLengthErrorMessage)]
        [OnlyEnglish]
        public string Title { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinProjectDescriptionLength, ErrorMessage = ValidationConstants.MinLengthErrorMessage)]
        [MaxLength(ValidationConstants.MaxProjectDescriptionLength, ErrorMessage = ValidationConstants.MaxLengthErrorMessage)]
        [OnlyEnglish]
        public string Description { get; set; }

        [MinLength(ValidationConstants.MinProjectEmbedVideoSource, ErrorMessage = ValidationConstants.MinLengthErrorMessage)]
        [MaxLength(ValidationConstants.MaxProjectEmbedVideoSource, ErrorMessage = ValidationConstants.MaxLengthErrorMessage)]
        public string VideoEmbedSource { get; set; }

    }
}