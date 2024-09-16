using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Qinshift.Movies.DTOs.User;
using Qinshift.Movies.Services.Interfaces;
using Serilog;

namespace Qinshift.Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("all")]
        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(_userService.GetAllUsers());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public IActionResult RegisterUser([FromBody] RegisterUserDto registerUserDto)
        {
            try
            {
                var result = _userService.RegisterUser(registerUserDto);
                if (result < 0) return BadRequest("An error occured!");
                return StatusCode(StatusCodes.Status201Created, "User created successfully!");
            }
            catch (Exception ex)
            {
                Log.Error("Register new user failed.", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult LoginUser([FromBody] UserDto userDto)
        {
            try
            {
                UserLoginResponseDto user = _userService.LoginUser(userDto.UserName, userDto.Password);
                return Ok(user);
            }
            catch (Exception ex)
            {
                Log.Error("Error while login user.", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
