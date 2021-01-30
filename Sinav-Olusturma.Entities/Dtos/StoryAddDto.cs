using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Entities.Dtos
{
    public class StoryAddDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
