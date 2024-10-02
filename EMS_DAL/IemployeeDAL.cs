using EMSBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSDAL
{
    public interface IemployeeDAL
    {
        string GetEmployeeIdFromDB(string employeeId);
        EmployeeBO GetEmployeeFromDB(string employeeId);

        IEnumerable<EmployeeBO> GetAllEmployees();
        int GetConsumedBudgetFromDB(String departmentId);

        bool AddEmployeeToDB(EmployeeBO employee, string departmentId);
        bool UpdateEmployeeInDB(EmployeeBO employee, string departmentId);

        bool DeleteEmployeeFromDB(string employeeId);

        IEnumerable<EmployeeBO> SearchEmployees(string searchInput);
    }
}
