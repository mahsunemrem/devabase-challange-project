namespace Business.Services.Abstract
{
    using Core.Utilities.Results;
    using Entities.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IEmployeeService
    {
        IDataResult<List<EmployeeDto>> GetList(Expression<Func<EmployeeDto, bool>> filter = null);
        IDataResult<EmployeeDto> Get(Expression<Func<EmployeeDto, bool>> filter = null);
        IResult Add(EmployeeDto model);
        IResult Delete(EmployeeDto model);
        IResult DeleteById(Guid id);
        IResult Update(EmployeeDto model);
    }
}
