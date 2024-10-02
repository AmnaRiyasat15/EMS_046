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
    public partial class DMSform : Form
    {
        public DMSform()
        {
            InitializeComponent();
        }

        private void AddDept_Click(object sender, EventArgs e)
        {
            var employeeBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IemployeeBLL>();
            var departmentBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IdepartmentBLL>();

            AddDepartmentForm addDepartmentForm = new AddDepartmentForm(employeeBLL, departmentBLL);
            addDepartmentForm.Show();
        }

        private void DeleteDept_Click(object sender, EventArgs e)
        {
            var employeeBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IemployeeBLL>();
            var departmentBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IdepartmentBLL>(); 

            DeleteDepartmentForm deleteDepartmentForm = new DeleteDepartmentForm(employeeBLL, departmentBLL);
            deleteDepartmentForm.Show();
        }

        private void UpdateDept_Click(object sender, EventArgs e)
        {
            var employeeBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IemployeeBLL>();
            var departmentBLL = Program.serviceProvider.GetRequiredService<EMSBLL.IdepartmentBLL>();

            UpdateDepartmentForm updateDepartmentForm = new UpdateDepartmentForm(employeeBLL, departmentBLL);
             updateDepartmentForm.Show();
        }
    }
}
