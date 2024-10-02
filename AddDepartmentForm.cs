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
    public partial class AddDepartmentForm : Form
    {
        private EMSBLL.IemployeeBLL _employeeBLL;
        private EMSBLL.IdepartmentBLL _departmentBLL;

        public AddDepartmentForm(EMSBLL.IemployeeBLL employeeBLL, EMSBLL.IdepartmentBLL departmentBLL)
        {
            _employeeBLL = employeeBLL;
            _departmentBLL = departmentBLL;
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var departmentName = textDeptName.Text;
            var budget = textDeptBudget.Text;

            try
            {
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
            }

            string departmentId = Guid.NewGuid().ToString();
            DepartmentBO departmentBO = new DepartmentBO { DepartmentID = departmentId, DepartmentName = departmentName, Budget = Convert.ToInt32(budget) };
            bool isAdded = _departmentBLL.AddDepartment(departmentBO);
            if (isAdded)
            {
                MessageBox.Show("Department added");
                Close();
            }
            else
            {
                MessageBox.Show("Department not added");
                Close();
            }
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
