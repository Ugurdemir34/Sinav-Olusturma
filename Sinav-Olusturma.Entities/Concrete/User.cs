using Sinav_Olusturma.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
