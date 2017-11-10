namespace PersonalFitnessCare.Server.Models.EntityModels
{
    using System.Collections.Generic;

    public class UserProgram
    {
        ICollection<SportResults> SportResults { get; set; }
    }
}