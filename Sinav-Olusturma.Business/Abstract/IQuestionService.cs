using Sinav_Olusturma.Entities.Concrete;
using Sinav_Olusturma.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Business.Abstract
{
    public interface IQuestionService
    {
        void Add(QuestionAddDto questionaddDto);
        void DeleteRange(List<Question> questions);
        List<Question> GetByStoryId(int storyId);
    }
}
