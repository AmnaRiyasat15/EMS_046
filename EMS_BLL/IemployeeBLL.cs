using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMSBO;

namespace EMSBLL
{
    public interface IemployeeBLL
    {
        void ValidateAddEmployeeFields(EmployeeBO employee);
        IEnumerable<EmployeeBO> GetAllEmployees();
        bool AddEmployee(EmployeeBO employee);
        bool UpdateEmployee(EmployeeBO employee);
        bool DeleteEmployee(EmployeeBO employee);

        IEnumerable<EmployeeBO> SearchEmployees(string searchInput);
    }
}
