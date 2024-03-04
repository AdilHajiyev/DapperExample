using Dapper1.Entities;
using Dapper1.Repositories;
using Dapper1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapper1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        EmployeeService EmployeeService { get; set; }

        public EmployeesController(EmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }

        [HttpGet]
        public Employee GetEmployeeById(int id) {
            return EmployeeService.GetEmployeeById(id);
        }
    }
}

            //controller -> service -> Repository