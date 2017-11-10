namespace PersonalFitnessCare.Server.Extensions
{
    using System.Linq;
    using Models;

    public static class QueryableExtensions
    {
        public static IQueryable<PeopleRequestModel> ToFilteredPeople(this IQueryable<PeopleRequestModel> query, PeopleFilterModel filters)
        {
            if (filters == null)
            {
                return query;
            }

            if (!string.IsNullOrWhiteSpace(filters.Name))
            {
                query = query.Where(c => c.Name.ToLower().Contains(filters.Name.ToLower()));
            }

            if (filters.Age != null)
            {
                query = query.Where(c => c.Age == filters.Age);
            }

            if (filters.Body != null)
            {
                query = query.Where(c => c.Body == filters.Body);
            }

            var skip = (filters.Page - 1) * 3;
            var take = 3;

            query = query
                .OrderByDescending(c => c.Id)
                .Skip(skip)
                .Take(take);

            return query;
        }
    }
}
