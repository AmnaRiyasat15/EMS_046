using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    internal static class Program
    {
        public static ServiceProvider serviceProvider;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            // Register BLL services
            services.AddSingleton<EMSBLL.IemployeeBLL, EMSBLL.EmployeeBLL>();
            services.AddSingleton<EMSBLL.IdepartmentBLL, EMSBLL.DepartmentBLL>();

            // Register DAL services
            services.AddSingleton<EMSDAL.IemployeeDAL, EMSDAL.EmployeeDAL>();
            services.AddSingleton<EMSDAL.IdepartmentDAL, EMSDAL.DepartmentDAL>();

            serviceProvider = services.BuildServiceProvider();
            Application.Run(new Form1());
        }
    }
}
