using Sinav_Olusturma.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Entities.Dtos
{
    public class StoryAddDto:IDto
    {
        public string Id { get; set; }
        public string Title { get; set; }


        public string Description { get; set; }
        public string Link { get; set; }
    }
}
