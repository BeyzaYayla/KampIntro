using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class Gamer : IEntity
    {
        public int Id { get; set; }
        public long IdentityNumber { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int BirthYear { get; set; }
    }
}
