using System;
using EMSBO;
using EMSBLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class AddEmployeeForm : Form
    {
        private EMSBLL.IemployeeBLL _employeeBLL;
        private EMSBLL.IdepartmentBLL _departmentBLL;

        public AddEmployeeForm(EMSBLL.IemployeeBLL employeeBLL, EMSBLL.IdepartmentBLL departmentBLL)
        {
            _employeeBLL = employeeBLL;
            _departmentBLL = departmentBLL;
            InitializeComponent();
        }
        private void AddEmployeeInformation_Click(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textDepartment_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textPosition_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
           
            var firstName = textFirstName.Text;
            var lastName = textLastName.Text;
            var position = textPosition.Text;
            var departmentID = textDepartmentID.Text;
            var salary = txtSalary.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    throw new Exception("First Name is required.");
                }
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    throw new Exception("Last Name is required.");
                }
                if (string.IsNullOrWhiteSpace(position))
                {
                    throw new Exception("Position is required.");
                }
                if (string.IsNullOrWhiteSpace(salary))
                {
                    throw new Exception("Salary is required.");
                }
                if (string.IsNullOrWhiteSpace(departmentID))
                {
                    throw new Exception("Department name is required.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string employeeId = Guid.NewGuid().ToString();
            EmployeeBO employeeBO = new EmployeeBO { EmployeeID = employeeId, FirstName = firstName, LastName = lastName, Position = position, Salary = Convert.ToInt32(salary), DepartmentID = departmentID };
            bool isEmployeeAdded = _employeeBLL.AddEmployee(employeeBO);
            if (isEmployeeAdded)
            {
                MessageBox.Show("Employee added");
                Close();
            }
            else
            {
                MessageBox.Show("Employee not added");
                Close();
            }
        }

        private void LastName_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentName_Click(object sender, EventArgs e)
        {

        }
    }
}
