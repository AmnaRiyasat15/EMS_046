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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeFeature_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
            EMSform empForm = new EMSform();
            //Display the EmployeeManagementForm
            empForm.Show();
        }

        private void DepartmentFeature_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
            DMSform deptForm = new DMSform();
            //Display the EmployeeManagementForm
            deptForm.Show();
        }
    }
}
