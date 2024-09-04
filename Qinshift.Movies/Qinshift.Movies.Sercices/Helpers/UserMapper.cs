using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DTOs.User;

namespace Qinshift.Movies.Services.Helpers
{
    public class UserMapper
    {
        public static UserDto ToUserShowDto(User user)
        {
            if (user == null)
            {
                return null;
            }

            return new UserDto
            {
                UserName = user.UserName,
            };
        }
    }
}
