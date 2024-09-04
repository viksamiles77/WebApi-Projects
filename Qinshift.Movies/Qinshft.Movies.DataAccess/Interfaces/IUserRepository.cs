using Qinshift.Movies.DomainModels;

namespace Qinshft.Movies.DataAccess.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User LoginUser(string username, string hashedPassword);
    }
}
