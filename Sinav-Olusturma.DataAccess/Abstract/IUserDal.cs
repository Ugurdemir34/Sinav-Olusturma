using Sinav_Olusturma.Core.DataAccess;
using Sinav_Olusturma.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
