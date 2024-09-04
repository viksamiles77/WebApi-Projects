using Qinshft.Movies.DataAccess.Interfaces;
using Qinshift.Movies.DomainModels;

namespace Qinshft.Movies.DataAccess.Implementation
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly MovieRentDbContext _context;

        public UserRepository(MovieRentDbContext ctx) : base(ctx)
        {
            _context = ctx;
        }

        public User LoginUser(string username, string hashedPassword)
        {
            return _context.Users.SingleOrDefault(x => x.UserName == username && x.Password == hashedPassword);
        }
    }
}
