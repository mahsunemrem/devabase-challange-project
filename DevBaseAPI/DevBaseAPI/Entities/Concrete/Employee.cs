using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
    }
}
