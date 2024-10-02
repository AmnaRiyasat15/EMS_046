using Microsoft.Extensions.DependencyInjection;
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
    public partial class EMSform : Form
    {
        public EMSform()
        {
            InitializeComponent();
        }

        private void EMSform_Load(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            var employeeBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IemployeeBLL>();
            var departmentBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IdepartmentBLL>();

            AddEmployeeForm addEmployee = new AddEmployeeForm(employeeBLL, departmentBLL);
            addEmployee.Show();
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            //form to take inputs
            var employeeBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IemployeeBLL>();
            var departmentBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IdepartmentBLL>();

            UpdateEmployeeForm updateEmployee = new UpdateEmployeeForm(employeeBLL, departmentBLL);
            updateEmployee.Show();
        }

        private void SearchForEmployee_Click(object sender, EventArgs e)
        {
            var employeeBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IemployeeBLL>();
            var departmentBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IdepartmentBLL>();

            SearchEmployeeForm search = new SearchEmployeeForm(employeeBLL, departmentBLL);
            search.Show();
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            var employeeBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IemployeeBLL>();
            var departmentBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IdepartmentBLL>();

            DeleteEmployeeForm deleteEmployee = new DeleteEmployeeForm(employeeBLL, departmentBLL);
            deleteEmployee.Show();
        }
    }
}
