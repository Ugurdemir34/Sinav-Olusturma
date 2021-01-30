using Sinav_Olusturma.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Entities.Dtos
{
    public class QuestionAddDto:IDto
    {
        public string Title { get; set; }
        public string OptionA { get; set; }
        public int StoryId { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
}
