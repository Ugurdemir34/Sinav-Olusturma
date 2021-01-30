using Sinav_Olusturma.Business.Abstract;
using Sinav_Olusturma.DataAccess.Abstract;
using Sinav_Olusturma.Entities.Concrete;
using Sinav_Olusturma.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private IQuestionDal _questionDal;
        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }
        public void Add(QuestionAddDto questionaddDto)
        {
            var question = new Question
            {
                StoryId = questionaddDto.StoryId,
                CorrectOption = questionaddDto.CorrectOption,
                OptionA = questionaddDto.OptionA,
                OptionB = questionaddDto.OptionB,
                OptionC = questionaddDto.OptionC,
                OptionD = questionaddDto.OptionD,
                Title = questionaddDto.Title
            };
            _questionDal.Add(question);
        }

        public void DeleteRange(List<Question> questions)
        {
            _questionDal.DeleteRange(questions);
        }

        public List<Question> GetByStoryId(int storyId)
        {
            return _questionDal.GetList(i => i.StoryId == storyId);
        }
    }
}
