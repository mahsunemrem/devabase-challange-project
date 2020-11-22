using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Services.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    /// <summary>
    /// SHORT METODU FRONT-END TARAFINDA YAPILDI.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("get-employees")]
        public IActionResult Get(int currentPage)
        {

            var result = _employeeService.GetList();

            if (result.Success)
            {

                int maxRows = 10;
                var listPagination = result.Data.Skip((currentPage - 1) * maxRows).Take(maxRows).ToList();
                double pageCount = Math.Ceiling((double)((decimal)result.Data.Count() / Convert.ToDecimal(maxRows)));
                var employeePagination = new EmployeePaginationViewModel() { Employees = listPagination, ListCount = result.Data.Count(), CurrentPage = currentPage, PageCount = (int)pageCount };


                return Ok(employeePagination);
            }
            else
            {
                return NotFound();
            }


        }


        [HttpGet("{get-employee}")]
        public IActionResult Get(Guid id)
        {
            var result = _employeeService.Get(c => c.Id == id);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost("add-employee")]
        public IActionResult Post(EmployeeDto model)
        {
            IResult result;

            if (model.Id == Guid.Empty)
            {
                model.Id = Guid.NewGuid();
                result = _employeeService.Add(model);
            }
            else
            {
                result = _employeeService.Update(model);
            }

            if (result.Success)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }





        [HttpDelete("delete-employee")]
        public IActionResult Delete(Guid id)
        {

            var result = _employeeService.DeleteById(id);

            if (result.Success)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
