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
    public partial class DeleteDepartmentForm : Form
    {
        private EMSBLL.IemployeeBLL _employeeBLL;
        private EMSBLL.IdepartmentBLL _departmentBLL;

        public DeleteDepartmentForm(EMSBLL.IemployeeBLL employeeBLL, EMSBLL.IdepartmentBLL departmentBLL)
        {
            _employeeBLL = employeeBLL;
            _departmentBLL = departmentBLL;
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var departmentId = textDeptID.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(departmentId))
                {
                    throw new Exception("Department ID is required.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return; 
            }
            DepartmentBO departmentBO = new DepartmentBO { DepartmentID = departmentId };

            bool isDeleted = _departmentBLL.DeleteDepartment(departmentBO);

            //result
            if (isDeleted)
            {
                MessageBox.Show("Department deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to delete departmen.");
            }
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
