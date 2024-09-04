﻿using Microsoft.IdentityModel.Tokens;
using Qinshft.Movies.DataAccess.Interfaces;
using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DTOs.Movie;
using Qinshift.Movies.DTOs.User;
using Qinshift.Movies.Services.Helpers;
using Qinshift.Movies.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Qinshift.Movies.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //public List<UserShowDto> GetAllMovies()
        //{
        //    var users = _userRepository.GetAll();
        //    var userListDto = new List<UserShowDto>();
        //    foreach (var user in users)
        //    {
        //        var userShowDto = UserMapper.ToUserShowDto(user);
        //        userListDto.Add(userShowDto);
        //    }
        //    return userListDto;
        //}

        public UserLoginResponseDto LoginUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Please input username and password!");
            }

            MD5 md5CryptoService = MD5.Create();

            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            byte[] hashBytes = md5CryptoService.ComputeHash(passwordBytes);
            string hashedPassword = Encoding.ASCII.GetString(hashBytes);

            var user = _userRepository.LoginUser(username, password);

            if (user == null) throw new Exception("User not found!");

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] secretKeyBytes = Encoding.ASCII.GetBytes("this is my custom Secret key for authentication");

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                SecurityAlgorithms.HmacSha256),

                Subject = new ClaimsIdentity(
                    new[]
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim("userFullName", $"{user.FirstName}{user.LastName}"),
                    })
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            var userModel = new UserLoginResponseDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Token = tokenHandler.WriteToken(token) // Converting from SecurityToken object to string
            };

            return userModel;
        }

        public int RegisterUser(RegisterUserDto registerUserDto)
        {
            if (string.IsNullOrEmpty(registerUserDto.UserName) ||
                string.IsNullOrEmpty(registerUserDto.Password))
            {
                throw new Exception("Please input username and password!");
            }

            MD5 md5CryptoServiceProvider = MD5.Create();

            byte[] passwordBytes = Encoding.ASCII.GetBytes(registerUserDto.Password);

            byte[] hashBytes = md5CryptoServiceProvider.ComputeHash(passwordBytes);

            string hashedPassword = Encoding.ASCII.GetString(hashBytes);

            User user = new User
            {
                FirstName = registerUserDto.FirstName,
                LastName = registerUserDto.LastName,
                UserName = registerUserDto.UserName,
                Password = hashedPassword
            };

            return _userRepository.Add(user);
        }
    }
}
