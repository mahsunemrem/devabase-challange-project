using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels
{
    public class EmployeePaginationViewModel
    {
        public List<EmployeeDto> Employees { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public int ListCount { get; set; }
    }
}
