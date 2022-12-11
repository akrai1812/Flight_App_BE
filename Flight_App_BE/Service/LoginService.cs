﻿using Flight_App_BE.Models;
using Flight_App_BE.UserCred;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_App_BE.Service
{
    public class LoginService : ILoginService
    {
        private readonly IUserService _userService;
        private readonly ITokenGeneration _tokenGeneration;
        public LoginService(IUserService userService, ITokenGeneration tokenGeneration)
        {
            _userService = userService;
            _tokenGeneration = tokenGeneration;
        }
        public Login login(Login userCreds)
        {
            var user = _userService.GetAllUser().FirstOrDefault(u => u.Email == userCreds.Email);
            if (user != null)
            {



                if (user.Password != userCreds.Password)
                {
                    return null;
                }
                userCreds.Password = user.Password;
                userCreds.token = _tokenGeneration.GenerateToken(userCreds);
                return userCreds;
            }
            return null;
        }
        public Login Register(User user)
        {



            var userDetails = _userService.AddUser(user);
            if (userDetails != null)
                return new Login
                {
                    Email = user.Email,
                    token = _tokenGeneration.GenerateToken(new Login { Email = user.Email })
                };
            return null;
        }
    }
}
