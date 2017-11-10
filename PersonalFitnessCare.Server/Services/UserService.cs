namespace PersonalFitnessCare.Server.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    using PersonalFitnessCare.Server.Models;
    using PersonalFitnessCare.Server.Repositories;

    public class UsersService /*: IUsersService*/
    {
        private readonly IRepository<ApplicationUser> users;
        //private readonly IRemoteDataService remoteData;

        public UsersService(IRepository<ApplicationUser> users)
        {
            this.users = users;
            //this.remoteData = remoteData;
        }

        public async Task<string> UserIdByUsername(string username)
        {
            return await this.users
                .All()
                .Where(u => u.UserName == username)
                .Select(u => u.Id)
                .FirstOrDefaultAsync();
        }
    }
}