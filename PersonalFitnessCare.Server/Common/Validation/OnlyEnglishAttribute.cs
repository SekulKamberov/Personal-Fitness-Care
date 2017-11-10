namespace PersonalFitnessCare.Server.Common.Validation
{
    using PersonalFitnessCare.Server.Common.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class OnlyEnglishAttribute : ValidationAttribute
    {
        public OnlyEnglishAttribute()
        {
            this.ErrorMessage = ValidationConstants.OnlyEnglishErrorMessage;
        }

        public override bool IsValid(object value)
        {
            var valueAsString = value as string;
            if (valueAsString != null)
            {
                return valueAsString.All(symbol => !char.IsLetter(symbol) || symbol.IsEnglishLetter());
            }
            return true;
        }
    }
}