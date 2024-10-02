using EMSBO;
using System;
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
    public partial class UpdateEmployeeForm : Form
    {
        private EMSBLL.IemployeeBLL _employeeBLL;
        private EMSBLL.IdepartmentBLL _departmentBLL;

        public UpdateEmployeeForm(EMSBLL.IemployeeBLL employeeBLL, EMSBLL.IdepartmentBLL departmentBLL)
        {
            _employeeBLL = employeeBLL;
            _departmentBLL = departmentBLL;
            InitializeComponent();
        }

        private void UpdateEmployeeInformation_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var employeeId = textEmpID.Text; 
            var firstName = textEmpID.Text;
            var lastName = textLastName.Text;
            var position = textPosition.Text;
            var departmentID = textDepartmentID.Text;
            var salary = txtSalary.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(employeeId))
                {
                    throw new Exception("Employee ID is required.");
                }
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
                    throw new Exception("Department ID is required.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                EmployeeBO employeeBO = new EmployeeBO
                {
                    EmployeeID = employeeId,
                    FirstName = firstName,
                    LastName = lastName,
                    Position = position,
                    Salary = Convert.ToInt32(salary),
                    DepartmentID = departmentID
                };

                bool isEmployeeUpdated = _employeeBLL.UpdateEmployee(employeeBO);

                if (isEmployeeUpdated)
                {
                    MessageBox.Show("Employee updated successfully!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to update the employee.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDepartmentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
