using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DTOs.User;

namespace Qinshift.Movies.Services.Helpers
{
    public class UserMapper
    {
        public static UserShowDto ToUserShowDto(User user)
        {
            if (user == null)
            {
                return null;
            }

            return new UserShowDto
            {
                FirstName = user.FirstName,
                UserName = user.UserName
            };
        }
    }
}
