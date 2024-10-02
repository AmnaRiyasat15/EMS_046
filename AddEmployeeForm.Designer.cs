namespace EmployeeManagementSystem
{
    partial class AddEmployeeForm
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
            this.AddEmployeeInformation = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.Button();
            this.Salary = new System.Windows.Forms.Button();
            this.DepartmentID = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.textDepartmentID = new System.Windows.Forms.TextBox();
            this.textPosition = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddEmployeeInformation
            // 
            this.AddEmployeeInformation.AutoSize = true;
            this.AddEmployeeInformation.BackColor = System.Drawing.SystemColors.Control;
            this.AddEmployeeInformation.Location = new System.Drawing.Point(427, 43);
            this.AddEmployeeInformation.Name = "AddEmployeeInformation";
            this.AddEmployeeInformation.Size = new System.Drawing.Size(197, 20);
            this.AddEmployeeInformation.TabIndex = 0;
            this.AddEmployeeInformation.Text = "Add Employee Information";
            this.AddEmployeeInformation.Click += new System.EventHandler(this.AddEmployeeInformation_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(79, 123);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(118, 57);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "FirstName";
            this.FirstName.UseVisualStyleBackColor = true;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(79, 210);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(118, 57);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "LastName";
            this.LastName.UseVisualStyleBackColor = true;
            this.LastName.Click += new System.EventHandler(this.LastName_Click);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(79, 300);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(118, 57);
            this.Salary.TabIndex = 3;
            this.Salary.Text = "Salary";
            this.Salary.UseVisualStyleBackColor = true;
            // 
            // DepartmentID
            // 
            this.DepartmentID.Location = new System.Drawing.Point(79, 394);
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Size = new System.Drawing.Size(118, 57);
            this.DepartmentID.TabIndex = 4;
            this.DepartmentID.Text = "DeptID";
            this.DepartmentID.UseVisualStyleBackColor = true;
            this.DepartmentID.Click += new System.EventHandler(this.DepartmentName_Click);
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(79, 487);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(118, 57);
            this.Position.TabIndex = 5;
            this.Position.Text = "Position";
            this.Position.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(464, 585);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(118, 57);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(278, 123);
            this.textFirstName.Multiline = true;
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(500, 50);
            this.textFirstName.TabIndex = 7;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(278, 300);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(500, 50);
            this.txtSalary.TabIndex = 8;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // textDepartmentID
            // 
            this.textDepartmentID.Location = new System.Drawing.Point(278, 394);
            this.textDepartmentID.Multiline = true;
            this.textDepartmentID.Name = "textDepartmentID";
            this.textDepartmentID.Size = new System.Drawing.Size(500, 50);
            this.textDepartmentID.TabIndex = 9;
            this.textDepartmentID.TextChanged += new System.EventHandler(this.textDepartment_TextChanged);
            // 
            // textPosition
            // 
            this.textPosition.Location = new System.Drawing.Point(278, 502);
            this.textPosition.Multiline = true;
            this.textPosition.Name = "textPosition";
            this.textPosition.Size = new System.Drawing.Size(500, 50);
            this.textPosition.TabIndex = 10;
            this.textPosition.TextChanged += new System.EventHandler(this.textPosition_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(278, 210);
            this.textLastName.Multiline = true;
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(500, 50);
            this.textLastName.TabIndex = 11;
            this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1213, 681);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textPosition);
            this.Controls.Add(this.textDepartmentID);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.DepartmentID);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.AddEmployeeInformation);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddEmployeeInformation;
        private System.Windows.Forms.Button FirstName;
        private System.Windows.Forms.Button LastName;
        private System.Windows.Forms.Button Salary;
        private System.Windows.Forms.Button DepartmentID;
        private System.Windows.Forms.Button Position;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox textDepartmentID;
        private System.Windows.Forms.TextBox textPosition;
        private System.Windows.Forms.TextBox textLastName;
    }
}