using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tavisca.Applauze.Api.Models;

namespace Tavisca.Applauze.Api.MoqDatabase
{
    public interface IEmployeeRepository
    {
        IList<Employee> GetAllEmployee();
        Employee GetEmployeeById(string id);
    }
}
