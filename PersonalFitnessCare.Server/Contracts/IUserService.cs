namespace PersonalFitnessCare.Server.Contracts
{
    using PersonalFitnessCare.Server.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IUserService
    {
        IQueryable<ApplicationUser> ByUsername(string username);

        Task<ApplicationUser> Account(string username, string password);

        Task<IEnumerable<string>> SearchByUsername(string username);

        Task<ICollection<ApplicationUser>> CollaboratorsFromCommaSeparatedValues(string collaborators, string currentUserUsername = null);

        Task<bool> UserIsCollaboratorInProject(int projectId, string userName);

        //Task<RemoteUserProfile> ProfileInfo(string username);

        Task<int> UserIdByUsername(string username);

        Task<bool> UserIsAdmin(string username);
    }
}
