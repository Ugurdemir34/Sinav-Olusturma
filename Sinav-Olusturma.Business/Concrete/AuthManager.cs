using Sinav_Olusturma.Business.Abstract;
using Sinav_Olusturma.Entities.Concrete;
using Sinav_Olusturma.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }
        public User Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetAdmin(userForLoginDto.Username, userForLoginDto.Password);
            return userToCheck;

        }
    }
}
