namespace PersonalFitnessCare.Server.Models
{
    public class PeopleFilterModel
    {
        public PeopleFilterModel()
        {
            this.Page = 1;
        }

        public string Name { get; set; }

        public int? Age { get; set; }

        public BodyType? Body { get; set; }

        public int Page { get; set; }
    }
}
