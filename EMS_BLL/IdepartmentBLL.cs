using EMSBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSBLL
{
    public interface IdepartmentBLL
    {
        void ValidateAddDepartmentFields(DepartmentBO department);

        IEnumerable<DepartmentBO> GetAllDepartments();

        bool AddDepartment(DepartmentBO department);
        bool UpdateDepartment(DepartmentBO department);
        bool DeleteDepartment(DepartmentBO department);
    }
}
