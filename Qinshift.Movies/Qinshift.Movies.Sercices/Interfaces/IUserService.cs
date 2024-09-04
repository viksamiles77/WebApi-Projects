using Qinshift.Movies.DTOs.User;

namespace Qinshift.Movies.Services.Interfaces
{
    public interface IUserService
    {
        List<UserShowDto> GetAllMovies();
        int RegisterUser(RegisterUserDto registerUserDto);

        UserLoginResponseDto LoginUser(string username, string password);
    }
}
