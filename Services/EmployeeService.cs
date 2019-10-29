using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tavisca.Applauze.Api.Interfaces;
using Tavisca.Applauze.Api.Models;
using Tavisca.Applauze.Api.MoqDatabase;

namespace Tavisca.Applauze.Api.Services
{
    public class EmployeeService:IEmployeeRepository
    {
        IList<Employee> Employees;
        public EmployeeService()
        {
            Employees = new List<Employee>
            {
            new Employee {
                Id ="C21",
                Name="sai",
                Email="saivanka@gmail.com",
                PhotoUri= new Uri("http://www.contoso.com/") ,
                Tribe="enablement",
                Points=100

            },
             new Employee {
                Id ="C25",
                Name="saijola",
                Email="saijola@gmail.com",
                PhotoUri= new Uri("http://www.contoso.com/") ,
                Tribe="Orxe",
                Points=10

            },
              new Employee {
                Id ="C26",
                Name="saivjm",
                Email="saivjm@gmail.com",
                PhotoUri= new Uri("http://www.contoso.com/") ,
                Tribe="CHAI",
                Points=102

                }

            };
           
           
        }
        

        public IList<Employee> GetAllEmployee()
        {
            return Employees;
        }

        public Employee GetEmployeeById(string id)
        {
            return Employees.FirstOrDefault(Emp=>Emp.Id==id);
        }
    }
}
