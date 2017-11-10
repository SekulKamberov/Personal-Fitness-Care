namespace PersonalFitnessCare.Server.Models
{
    public class PeopleRequestModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Url { get; set; }

        public BodyType Body { get; set; }
    }
}
