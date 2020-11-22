using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public class EmployeeDto : Dto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }

    }
}

