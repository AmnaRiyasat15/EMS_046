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
    public partial class UpdateDepartmentForm : Form
    {
        private EMSBLL.IemployeeBLL _employeeBLL;
        private EMSBLL.IdepartmentBLL _departmentBLL;

        public UpdateDepartmentForm(EMSBLL.IemployeeBLL employeeBLL, EMSBLL.IdepartmentBLL departmentBLL)
        {
            _employeeBLL = employeeBLL;
            _departmentBLL = departmentBLL;
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var departmentId = textDeptID.Text;
            var departmentName = textDeptName.Text;
            var budget = txtBudget.Text;

            try
            {
                //Validating the inputs
                if (string.IsNullOrWhiteSpace(departmentId))
                {
                    throw new Exception("Department ID is required.");
                }
                if (string.IsNullOrWhiteSpace(departmentName))
                {
                    throw new Exception("Department name is required.");
                }
                if (string.IsNullOrWhiteSpace(budget))
                {
                    throw new Exception("Budget is required.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            DepartmentBO departmentBO = new DepartmentBO
            {
                DepartmentID = departmentId,
                DepartmentName = departmentName,
                Budget = Convert.ToInt32(budget)
            };

            bool isUpdated = _departmentBLL.UpdateDepartment(departmentBO);
            if (isUpdated)
            {
                MessageBox.Show("Department updated successfully.");
                Close(); 
            }
            else
            {
                MessageBox.Show("Department update failed.");
            }
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDeptName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBudget_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
