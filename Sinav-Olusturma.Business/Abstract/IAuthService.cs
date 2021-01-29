using Sinav_Olusturma.Entities.Concrete;
using Sinav_Olusturma.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Business.Abstract
{
    public interface IAuthService
    {
        User Login(UserForLoginDto userForLoginDto);
    }
}
