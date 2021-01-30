using Sinav_Olusturma.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sinav_Olusturma.Entities.Concrete
{
    public class Story :IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
       // public string Content { get; set; }
        //public string Thumbnail { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        //Navigation Property
        public List<Question> Questions { get; set; }
    }
}
