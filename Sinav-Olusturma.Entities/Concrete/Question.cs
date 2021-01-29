using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Entities.Concrete
{
    public class Question
    {
        public int Id { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
        //Navigation Property
        public Story Story { get; set; }
    }
}
