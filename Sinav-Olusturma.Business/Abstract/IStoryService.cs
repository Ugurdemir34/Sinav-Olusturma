using Sinav_Olusturma.Entities.Concrete;
using Sinav_Olusturma.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Business.Abstract
{
    public interface IStoryService
    {
        void Add(StoryAddDto storyaddDto);
        void Delete(Story story);
        int LastIndex(StoryAddDto storyAddDto);
        List<Story> GetAll();
        Story GetById(int id);
        
    }
}
