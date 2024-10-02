using EMSBO;
using EMSDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSBLL
{
    public class EmployeeBLL: IemployeeBLL
    {
        private IemployeeDAL _employeeDAL;
        private IdepartmentDAL _departmentDAL;

        //Validation
        public EmployeeBLL(IemployeeDAL employeeDAL, IdepartmentDAL departmentDAL)
        {
            _employeeDAL = employeeDAL;
            _departmentDAL = departmentDAL;
        }

        public void ValidateAddEmployeeFields(EmployeeBO employee)
        {
            try
            {
                if (String.IsNullOrEmpty(employee.EmployeeID))
                {
                    throw new Exception("Employee Id is empty");
                }
                if (string.IsNullOrEmpty(employee.FirstName))
                {
                    throw new Exception("First name is empty");
                }
                if (string.IsNullOrEmpty(employee.LastName))
                {
                    throw new Exception("Last name is empty");
                }
                if (string.IsNullOrEmpty(employee.Position))
                {
                    throw new Exception("Position is empty");
                }
                if (employee.Salary < 0)
                {
                    throw new Exception("Salary is invalid");
                }
                if (string.IsNullOrEmpty(employee.DepartmentID))
                {
                    throw new Exception("Department ID is empty");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public IEnumerable<EmployeeBO> GetAllEmployees()
        {
            // Saving to the DB
            IEnumerable<EmployeeBO> employees = _employeeDAL.GetAllEmployees();
            return employees;
        }


        public bool AddEmployee(EmployeeBO employee)
        {
            bool result = false;
            try
            {
                string departmentId = employee.DepartmentID;

                // Checking whether the department exists using the DepartmentID
                string validDepartmentId = _departmentDAL.GetDepartmentIdFromDB(departmentId);
                if (string.IsNullOrEmpty(validDepartmentId))
                {
                    throw new Exception("Department with this ID doesn't exist!!!");
                }

                // Checking the Department budget
                int departmentBudget = _departmentDAL.GetDepartmentBudgetFromDB(departmentId);
                if (departmentBudget == -1)
                {
                    throw new Exception("Department budget is invalid!!!");
                }

                // Checking if employee salary is within the department budget range
                if (employee.Salary <= 0 || employee.Salary > departmentBudget)
                {
                    throw new Exception("Employee salary is invalid!!!");
                }

                // Checking the consumed department budget
                int consumedBudget = _employeeDAL.GetConsumedBudgetFromDB(departmentId);
                if (consumedBudget + employee.Salary > departmentBudget)
                {
                    throw new Exception("Department budget is not enough to accommodate the employee!!!");
                }

                //add the employee
                bool isEmployeeAdded = _employeeDAL.AddEmployeeToDB(employee, departmentId);
                result = isEmployeeAdded;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }


        public bool UpdateEmployee(EmployeeBO employee)
        {
            try
            {
                //whether the employee is valid or not
                EmployeeBO employeeBO = _employeeDAL.GetEmployeeFromDB(employee.EmployeeID);
                if (employeeBO == null)
                {
                    throw new Exception("Employee with this id doesn't exist!!!");
                }

                //Department budget
                int departmentBudget = _departmentDAL.GetDepartmentBudgetFromDB(employeeBO.DepartmentID);

                if (departmentBudget == -1)
                {
                    throw new Exception("Department budget is invalid!!!");
                }

                //new salary is in range of department budget
                if (employee.Salary <= 0 || employee.Salary > departmentBudget)
                {
                    throw new Exception("Employee salary is invalid!!!");
                }

                // consumed department budget
                int consumedBudget = _employeeDAL.GetConsumedBudgetFromDB(employeeBO.DepartmentID);
                if (consumedBudget - employeeBO.Salary + employee.Salary > departmentBudget)
                {
                    throw new Exception("Department budget is not enough to accomadate the employee!!!");
                }

                bool isEmployeeUpdated = _employeeDAL.UpdateEmployeeInDB(employee, employeeBO.DepartmentID);
                return isEmployeeUpdated;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }


        public bool DeleteEmployee(EmployeeBO employee)
        {
            //Saving to the DB
            string employeeId = _employeeDAL.GetEmployeeIdFromDB(employee.EmployeeID);
            bool isDeleted = _employeeDAL.DeleteEmployeeFromDB(employeeId);
            return isDeleted ? true : false;
        }


        void IemployeeBLL.ValidateAddEmployeeFields(EmployeeBO employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeBO> SearchEmployees(string searchInput)
        {
            return _employeeDAL.SearchEmployees(searchInput);
        }
    }
}
