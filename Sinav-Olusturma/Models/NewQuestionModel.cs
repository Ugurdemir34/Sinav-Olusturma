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
        public string StoryContent { get; set; }
        public List<Question> Questions { get; set; }
        public List<SelectListItem> StoryTitles { get; set; }
    }
}
