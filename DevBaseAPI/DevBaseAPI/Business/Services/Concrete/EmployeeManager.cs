namespace Business.Services.Concrete
{
    using AutoMapper;
    using Business.Constants;
    using Business.Services.Abstract;
    using Business.Statics;
    using Business.ValidationRules.FluentValidation;
    using Core.Aspects.Autofac.Caching;    
    using Core.Aspects.Autofac.Validation;    
    using Core.Utilities.Results;
    using DataAccess.Abstract;
    using Entities.Concrete;
    using Entities.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public class EmployeeManager : IEmployeeService
    {

        private IEmployeeDal _EmployeeDal;
        private IMapper _Mapper;
        public EmployeeManager(IEmployeeDal dal, IMapper Mapper)
        {
            _EmployeeDal = dal;
            _Mapper = Mapper;
        }
        //[CacheAspect(duration: 120)]
        public IDataResult<List<EmployeeDto>> GetList(Expression<Func<EmployeeDto, bool>> filter = null)
        {
            var entityFilter = _Mapper.Map<Expression<Func<Employee, bool>>>(filter);
            var dto = _Mapper.Map<List<EmployeeDto>>(_EmployeeDal.GetList(entityFilter, IncludeStatic.IncludeEmployee).ToList());
            return new SuccessDataResult<List<EmployeeDto>>(dto);
        }

        public IDataResult<EmployeeDto> Get(Expression<Func<EmployeeDto, bool>> filter = null)
        {
            var entityFilter = _Mapper.Map<Expression<Func<Employee, bool>>>(filter);
            var dto = _Mapper.Map<EmployeeDto>(_EmployeeDal.Get(entityFilter, IncludeStatic.IncludeEmployee));
            return new SuccessDataResult<EmployeeDto>(dto);
        }

        [ValidationAspect(typeof(EmployeeValidator), Priority = 1)]
        [CacheRemoveAspect("IEmployeeService.GetList")]
        
        public IResult Add(EmployeeDto model)
        {
            var entity = _Mapper.Map<Employee>(model);
            _EmployeeDal.Add(entity);
            return new SuccessResult(Messages.EmployeeAdded);
        }
        [CacheRemoveAspect("IEmployeeService.GetList")]
        
        public IResult Update(EmployeeDto model)
        {
            var entity = _Mapper.Map<Employee>(model);
            _EmployeeDal.Update(entity);
            return new SuccessResult(Messages.EmployeeUpdated);
        }
        [CacheRemoveAspect("IEmployeeService.GetList")]
        
        public IResult Delete(EmployeeDto model)
        {
            var entity = _Mapper.Map<Employee>(model);
            _EmployeeDal.Delete(entity);
            return new SuccessResult(Messages.EmployeeDeleted);
        }

        [CacheRemoveAspect("IEmployeeService.GetList")]
        public IResult DeleteById(Guid id)
        {
            var result=Get(c => c.Id == id);

            if (result.Data!=null)
            {
                _EmployeeDal.Delete(_Mapper.Map<Employee>(result.Data));
                return new SuccessResult(Messages.EmployeeDeleted);
            }

            else
            {
                return new ErrorResult();
            }

          
        }
    }
}

