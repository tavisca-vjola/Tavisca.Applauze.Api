using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tavisca.Applauze.Api.Models;
using Tavisca.Applauze.Api.MoqDatabase;

namespace Tavisca.Applauze.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _Employee;
            public EmployeeController(IEmployeeRepository Employee)
        {
            _Employee = Employee;
        }
        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _Employee.GetAllEmployee();
            
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public Employee GetEmployee(string id)
        {
            return _Employee.GetEmployeeById(id);
        }

    }
}
