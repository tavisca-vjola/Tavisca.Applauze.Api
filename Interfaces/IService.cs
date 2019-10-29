using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tavisca.Applauze.Api.Interfaces
{
    public interface IService<out OutputObject, in InputObject>
    {
        OutputObject GetAllEmployee();
        OutputObject GetEmployeeById(string id);

        OutputObject GetAllKudosEmployees();

        OutputObject GetAllShoutoutEmployees();
        OutputObject GetAllEmployeeAcheivement();
        OutputObject GetEmployeeTimeLine();


    }
}
