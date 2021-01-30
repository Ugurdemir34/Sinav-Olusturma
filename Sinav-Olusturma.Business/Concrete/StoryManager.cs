using Sinav_Olusturma.Business.Abstract;
using Sinav_Olusturma.DataAccess.Abstract;
using Sinav_Olusturma.Entities.Concrete;
using Sinav_Olusturma.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Business.Concrete
{
    public class StoryManager : IStoryService
    {
        private IStoryDal _storyDal;
        public StoryManager(IStoryDal storyDal)
        {
            _storyDal = storyDal;
        }
        public void Add(StoryAddDto storyaddDto)
        {
            var story = new Story()
            {
                //Content = storyaddDto.Content,
                Description = storyaddDto.Description,
                Id = storyaddDto.Id,
                Link = storyaddDto.Link,
                //Thumbnail = storyaddDto.Thumbnail,
                Title = storyaddDto.Title
            };
            _storyDal.Add(story);

        }
    }
}
