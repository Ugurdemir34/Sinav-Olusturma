using Autofac;
using Sinav_Olusturma.Business.Abstract;
using Sinav_Olusturma.Business.Concrete;
using Sinav_Olusturma.DataAccess.Abstract;
using Sinav_Olusturma.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<StoryManager>().As<IStoryService>();
            builder.RegisterType<EfStoryDal>().As<IStoryDal>();

            builder.RegisterType<QuestionManager>().As<IQuestionService>();
            builder.RegisterType<EfQuestionDal>().As<IQuestionDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
          
        }
    }
}
