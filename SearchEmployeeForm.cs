using EMSBLL;
using EMSDAL;
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
    public partial class SearchEmployeeForm : Form
    {
        private EMSBLL.IemployeeBLL _employeeBLL;
        private EMSBLL.IdepartmentBLL _departmentBLL;

        public SearchEmployeeForm(EMSBLL.IemployeeBLL employeeBLL, EMSBLL.IdepartmentBLL departmentBLL)
        {
            _employeeBLL = employeeBLL;
            _departmentBLL = departmentBLL;
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchInput = SearchINPUT.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(searchInput))
                {
                    MessageBox.Show("Input is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var employees = _employeeBLL.SearchEmployees(searchInput);

                ResultsForm resultsForm = new ResultsForm();

                //Loading employee data into ResultsForm
                resultsForm.LoadEmployeeData(employees);
                resultsForm.Show();
            }
            catch (Exception ex)
            {
                // Handle any unexpected exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
