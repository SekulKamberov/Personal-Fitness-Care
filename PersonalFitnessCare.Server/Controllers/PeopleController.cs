namespace PersonalFitnessCare.Server.Controllers
{
    using System.Web.Http;
    using System.Linq;
    using Models;
    using System.Collections.Generic;
    using Extensions;

    public class PeopleController : ApiController
    {
        private List<PeopleRequestModel> peoplesData = new List<PeopleRequestModel>
        {
            new PeopleRequestModel
            {
                Id = 1,
                Name = "Champ",
                Age = 3,
                Body = BodyType.Muscular,
                Url = "http://www.fitnflexed.com/sites/default/files/public/julian.jpg"
            },
            new PeopleRequestModel
            {
                Id = 2,
                Name = "Mimi",
                Age = 2,
                Body = BodyType.Slim,
                Url = "https://s-media-cache-ak0.pinimg.com/originals/e4/21/30/e421302467f939908f643f24bfd4e588.jpg"
            },
            new PeopleRequestModel
            {
                Id = 3,
                Name = "Ivan",
                Age = 25,
                Body = BodyType.Slim,
                Url = "http://www.onlymyhealth.com/imported/images/Articles%20Body%20Images/2011/August/4/Skinny-Guy.jpg"
            },
            new PeopleRequestModel
            {
                Id = 4,
                Name = "Poli",
                Age = 10,
                Body = BodyType.Fat,
                Url = "https://img.chicuu.com/product/original/clip/productpic/Plus-Size-Curve-Body-conscious-Asymmetric-Color-Block-Dress-LC60441-38958.jpg"
            },
        };

        public IHttpActionResult Get([FromUri]PeopleFilterModel model)
        {
            var result = this.peoplesData
                .AsQueryable()
                .ToFilteredPeople(model)
                .Take(10)
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Post(PeopleRequestModel model)
        {
            if (model != null)
            {
                model.Id = peoplesData.Count + 1;
                peoplesData.Add(model);
            }

            return Ok(model.Id);
        }
    }
}
