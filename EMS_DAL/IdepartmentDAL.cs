using EMSBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSDAL
{
    public interface IdepartmentDAL
    {
        string GetDepartmentIdFromDB(string departmentName);
        int GetDepartmentBudgetFromDB(string departmentId);

        IEnumerable<DepartmentBO> GetAllDepartmentsFromDB();
        bool AddDepartmentToDB(DepartmentBO department);
        bool UpdateDepartmentInDB(DepartmentBO department);
        bool DeleteDepartmentFromDB(string departmentId);
    }
}
