using EMSBO;
using System;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSDAL
{
    public class EmployeeDAL : IemployeeDAL
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public string GetEmployeeIdFromDB(string employeeId)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                string id = null;
                try
                {
                    string query = "SELECT * FROM Employee where EmployeeId = @EmployeeId";
                    EmployeeBO employeeBO = connect.QueryFirstOrDefault<EmployeeBO>(query, new { EmployeeId = employeeId });

                    if (employeeId == null)
                    {
                        throw new Exception("Employee with this id doesn't exist!!!");
                    }
                    id = employeeBO.EmployeeID;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return id;
            }
        }
        public EmployeeBO GetEmployeeFromDB(string employeeId)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Employee where EmployeeId = @EmployeeId";
                    EmployeeBO employeeBO = connect.QueryFirstOrDefault<EmployeeBO>(query, new { EmployeeId = employeeId });

                    if (employeeId == null)
                    {
                        throw new Exception("Employee with this id doesn't EXIST");
                    }
                    return employeeBO;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return null;
            }
        }

        public IEnumerable<EmployeeBO> GetAllEmployees()
        {
            using (var connect = new SqlConnection(connectionString))
            {
                IEnumerable<EmployeeBO> employees = null;
                try
                {
                    string query = "SELECT * FROM Employee";
                    employees = connect.Query<EmployeeBO>(query);

                    if (employees.Count() <= 0)
                    {
                        throw new Exception("Sorry, there are no employees!!!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return employees;
            }
        }
        public int GetConsumedBudgetFromDB(String departmentId)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(SALARY) FROM EMPLOYEE WHERE DEPARTMENTID = @DepartmentId";
                var totalSalary = connect.QuerySingleOrDefault<decimal?>(query, new { DepartmentId = departmentId });
                int consumedBudget = Convert.ToInt32(totalSalary);
                return consumedBudget > 0 ? consumedBudget : 0;
            }
        }
        public bool AddEmployeeToDB(EmployeeBO employee, string departmentId)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employee VALUES(@EmployeeId, @FirstName, @LastName, @Position, @Salary, @DepartmentId)";
                int count = connect.Execute(query, new { EmployeeId = employee.EmployeeID, FirstName = employee.FirstName, LastName = employee.LastName, Position = employee.Position, Salary = employee.Salary, DepartmentId = departmentId });
                return count > 0;
            }
        }
        public bool UpdateEmployeeInDB(EmployeeBO employee, string departmentId)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Position = @Position, Salary = @Salary, DepartmentId = @DepartmentId where EmployeeId = @EmployeeId";
                int count = connect.Execute(query, new { EmployeeId = employee.EmployeeID, FirstName = employee.FirstName, LastName = employee.LastName, Position = employee.Position, Salary = employee.Salary, DepartmentId = departmentId });
                return count > 0;
            }
        }

        public bool DeleteEmployeeFromDB(string employeeId)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Employee where EmployeeId = @EmployeeId";
                int count = connect.Execute(query, new { EmployeeId = employeeId });
                return count > 0;
            }
        }


        public IEnumerable<EmployeeBO> SearchEmployees(string searchInput)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                IEnumerable<EmployeeBO> employees = null;
                try
                { 
                    string query = "SELECT * FROM Employee E JOIN Department D ON E.DepartmentId = D.DepartmentId WHERE FirstName = @searchInput OR LastName = @searchInput OR Position = @searchInput OR DepartmentName = @searchInput";
                    employees = connect.Query<EmployeeBO>(query, new { searchInput });

                    if (employees.Count() <= 0)
                    {
                        throw new Exception("Sorry, there are no employees!!!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return employees;
            }
        }
    }
}
