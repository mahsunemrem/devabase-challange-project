using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;


namespace Business.AutoMapperProfile
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
		    CreateMap<Employee, EmployeeDto>(); 
		    CreateMap<EmployeeDto, Employee>(); 

        }
    }
}

