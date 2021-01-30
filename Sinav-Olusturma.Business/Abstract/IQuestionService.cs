using Sinav_Olusturma.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Business.Abstract
{
    public interface IQuestionService
    {
        void Add(QuestionAddDto questionaddDto);
    }
}
