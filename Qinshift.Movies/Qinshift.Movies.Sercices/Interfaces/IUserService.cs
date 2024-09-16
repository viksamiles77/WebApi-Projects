using Qinshift.Movies.DTOs.User;

namespace Qinshift.Movies.Services.Interfaces
{
    public interface IUserService
    {
        List<UserShowDto> GetAllUsers();
        int RegisterUser(RegisterUserDto registerUserDto);

        UserLoginResponseDto LoginUser(string username, string password);
    }
}
