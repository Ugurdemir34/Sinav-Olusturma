using Sinav_Olusturma.Core.DataAccess.EntityFramework;
using Sinav_Olusturma.DataAccess.Abstract;
using Sinav_Olusturma.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.DataAccess.Concrete.EntityFramework
{
    public class EfStoryDal : EfEntityRepositoryBase<Story, SinavContext>, IStoryDal
    {
    }
}
