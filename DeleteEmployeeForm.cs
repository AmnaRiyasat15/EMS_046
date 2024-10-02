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
    public partial class DeleteEmployeeForm : Form
    {
        private EMSBLL.IemployeeBLL _employeeBLL;
        private EMSBLL.IdepartmentBLL _departmentBLL;

        public DeleteEmployeeForm(EMSBLL.IemployeeBLL employeeBLL, EMSBLL.IdepartmentBLL departmentBLL)
        {
            _employeeBLL = employeeBLL;
            _departmentBLL = departmentBLL;
            InitializeComponent();
        }

        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            
            var employeeId = textEmpID.Text;

            //validation
            try
            {
                if (string.IsNullOrWhiteSpace(employeeId))
                {
                    throw new Exception("Employee ID is required.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return; 
            }

            EmployeeBO employeeBO = new EmployeeBO { EmployeeID = employeeId };

            bool isDeleted = _employeeBLL.DeleteEmployee(employeeBO);

            //result
            if (isDeleted)
            {
                MessageBox.Show("Employee deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to delete employee. Please check the Employee ID.");
            }
        }

        private void DeleteEmpInformation_Click(object sender, EventArgs e)
        {

        }

        private void textEmpID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
