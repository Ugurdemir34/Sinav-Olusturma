using Sinav_Olusturma.Business.Abstract;
using Sinav_Olusturma.DataAccess.Abstract;
using Sinav_Olusturma.Entities.Concrete;
using Sinav_Olusturma.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetAdmin(string username, string password)
        {
            var user = _userDal.Get(i => i.Username == username && i.Password == password);
            var user2 = _userDal.GetList();
            return user;
            
            
        }

        
    }
}
