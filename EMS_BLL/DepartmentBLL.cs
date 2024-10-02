using EMSDAL;
using EMSBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSBLL
{
    public class DepartmentBLL: IdepartmentBLL
    {
        private IemployeeDAL _employeeDAL;
        private IdepartmentDAL _departmentDAL;

        public DepartmentBLL(IemployeeDAL employeeDAL, IdepartmentDAL departmentDAL)
        {
            _employeeDAL = employeeDAL;
            _departmentDAL = departmentDAL;
        }

        private void ValidateAddDepartmentFields(DepartmentBO department)
        {
            try
            {
                if (String.IsNullOrEmpty(department.DepartmentID))
                {
                    throw new Exception("Department Id is empty");
                }
                if (String.IsNullOrEmpty(department.DepartmentName))
                {
                    throw new Exception("Department name is empty");
                }
                if (department.Budget <= 0)
                {
                    throw new Exception("Department Budget is invalid");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public IEnumerable<DepartmentBO> GetAllDepartments()
        {
            // Saving to the DB
            IEnumerable<DepartmentBO> departments = _departmentDAL.GetAllDepartmentsFromDB();
            return departments;
        }

        public bool AddDepartment(DepartmentBO department)
        {
            // Saving to the DB
            bool isAddedToDB = _departmentDAL.AddDepartmentToDB(department);
            return isAddedToDB;
        }
        public bool UpdateDepartment(DepartmentBO department)
        {
            // Validate Department Id
            string departmentId = _departmentDAL.GetDepartmentIdFromDB(department.DepartmentID);

            // Saving to the DB
            try
            {
                if (string.IsNullOrEmpty(departmentId))
                {
                    throw new Exception($"Department with this Id doesn't exist!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            bool isUpdated = _departmentDAL.UpdateDepartmentInDB(department);
            return isUpdated;
        }
        public bool DeleteDepartment(DepartmentBO department)
        {

            // Saving to the DB
            bool isDeleted = _departmentDAL.DeleteDepartmentFromDB(department.DepartmentID);
            return isDeleted ? true : false;
        }

        void IdepartmentBLL.ValidateAddDepartmentFields(DepartmentBO department)
        {
            throw new NotImplementedException();
        }
    }
}
