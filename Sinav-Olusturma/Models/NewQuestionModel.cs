using Microsoft.AspNetCore.Mvc.Rendering;
using Sinav_Olusturma.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav_Olusturma.Models
{
    public class NewQuestionModel
    {
        public string StoryTitle { get; set; }
        public string StoryLink { get; set; }
        public Question Question1 { get; set; }
        public Question Question2 { get; set; }
        public Question Question3 { get; set; }
        public Question Question4 { get; set; }
        public List<SelectListItem> StoryTitles { get; set; }
        public Story Story { get; set; }
    }
}
