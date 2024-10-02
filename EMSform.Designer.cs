namespace EmployeeManagementSystem
{
    partial class EMSform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddEmployee = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.ReadEmployee = new System.Windows.Forms.Button();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.SearchForEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEmployee
            // 
            this.AddEmployee.AutoSize = true;
            this.AddEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddEmployee.Location = new System.Drawing.Point(289, 85);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(156, 63);
            this.AddEmployee.TabIndex = 0;
            this.AddEmployee.Text = "AddEmployee";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.AutoSize = true;
            this.UpdateEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateEmployee.Location = new System.Drawing.Point(289, 203);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(156, 63);
            this.UpdateEmployee.TabIndex = 1;
            this.UpdateEmployee.Text = "UpdateEmployee";
            this.UpdateEmployee.UseVisualStyleBackColor = false;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // ReadEmployee
            // 
            this.ReadEmployee.AutoSize = true;
            this.ReadEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReadEmployee.Location = new System.Drawing.Point(297, 414);
            this.ReadEmployee.Name = "ReadEmployee";
            this.ReadEmployee.Size = new System.Drawing.Size(156, 63);
            this.ReadEmployee.TabIndex = 2;
            this.ReadEmployee.Text = "ReadEmployee";
            this.ReadEmployee.UseVisualStyleBackColor = false;
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.AutoSize = true;
            this.DeleteEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DeleteEmployee.Location = new System.Drawing.Point(297, 514);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(156, 63);
            this.DeleteEmployee.TabIndex = 3;
            this.DeleteEmployee.Text = "DeleteEmployee";
            this.DeleteEmployee.UseVisualStyleBackColor = false;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            // 
            // SearchForEmployee
            // 
            this.SearchForEmployee.AutoSize = true;
            this.SearchForEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchForEmployee.Location = new System.Drawing.Point(289, 309);
            this.SearchForEmployee.Name = "SearchForEmployee";
            this.SearchForEmployee.Size = new System.Drawing.Size(164, 63);
            this.SearchForEmployee.TabIndex = 4;
            this.SearchForEmployee.Text = "SearchForEmployee";
            this.SearchForEmployee.UseVisualStyleBackColor = false;
            this.SearchForEmployee.Click += new System.EventHandler(this.SearchForEmployee_Click);
            // 
            // EMSform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.SearchForEmployee);
            this.Controls.Add(this.DeleteEmployee);
            this.Controls.Add(this.ReadEmployee);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Name = "EMSform";
            this.Text = "EMSform";
            this.Load += new System.EventHandler(this.EMSform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.Button ReadEmployee;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.Button SearchForEmployee;
    }
}