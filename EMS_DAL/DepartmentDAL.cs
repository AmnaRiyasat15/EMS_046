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
    public class DepartmentDAL: IdepartmentDAL
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public string GetDepartmentIdFromDB(string departmentName)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                string id = null;
                try
                {
                    string query = "SELECT * FROM DEPARTMENT where DepartmentName = @DepartmentName";
                    DepartmentBO departmentBO = connect.QueryFirstOrDefault<DepartmentBO>(query, new { DepartmentName = departmentName });

                    if (departmentBO == null)
                    {
                        throw new Exception("Department with this name doesn't exist!!!");
                    }
                    id = departmentBO.DepartmentID;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return id;
            }
        }
        public int GetDepartmentBudgetFromDB(string departmentId)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                int budget = -1;
                try
                {
                    string query = "SELECT * FROM DEPARTMENT where DepartmentId = @DepartmentId";
                    DepartmentBO departmentBO = connect.QueryFirstOrDefault<DepartmentBO>(query, new { DepartmentId = departmentId });

                    if (departmentBO == null)
                    {
                        throw new Exception("Department with this id doesn't exist!!!");
                    }
                    budget = departmentBO.Budget;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return budget;
            }
        }

        public IEnumerable<DepartmentBO> GetAllDepartmentsFromDB()
        {
            using (var connect = new SqlConnection(connectionString))
            {
                IEnumerable<DepartmentBO> departments = null;
                try
                {
                    string query = "SELECT * FROM DEPARTMENT";
                    departments = connect.Query<DepartmentBO>(query);

                    if (departments.Count() <= 0)
                    {
                        throw new Exception("Sorry, there are no departments!!!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return departments;
            }
        }
        public bool AddDepartmentToDB(DepartmentBO department)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Department (DepartmentId, DepartmentName, Budget) VALUES (@DepartmentId, @DepartmentName, @Budget)";
                int count = connect.Execute(query, department);
                return count > 0;
            }
        }
        public bool UpdateDepartmentInDB(DepartmentBO department)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                string query = "UPDATE Department SET DepartmentName = @DepartmentName, Budget = @Budget where DepartmentId = @DepartmentId";
                int count = connect.Execute(query, department);
                return count > 0;
            }
        }
        public bool DeleteDepartmentFromDB(string departmentId)
        {
            using (var connect = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Department where DepartmentId = @DepartmentId";
                int count = connect.Execute(query, new { DepartmentId = departmentId });
                return count > 0;
            }
        }
    }
}
