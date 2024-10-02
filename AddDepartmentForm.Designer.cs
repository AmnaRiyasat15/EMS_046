namespace EmployeeManagementSystem
{
    partial class AddDepartmentForm
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
            this.AddDepartmentInformation = new System.Windows.Forms.Label();
            this.textDeptBudget = new System.Windows.Forms.TextBox();
            this.textDeptName = new System.Windows.Forms.TextBox();
            this.Budget = new System.Windows.Forms.Button();
            this.DeptName = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddDepartmentInformation
            // 
            this.AddDepartmentInformation.AutoSize = true;
            this.AddDepartmentInformation.BackColor = System.Drawing.SystemColors.Control;
            this.AddDepartmentInformation.Location = new System.Drawing.Point(330, 37);
            this.AddDepartmentInformation.Name = "AddDepartmentInformation";
            this.AddDepartmentInformation.Size = new System.Drawing.Size(212, 20);
            this.AddDepartmentInformation.TabIndex = 1;
            this.AddDepartmentInformation.Text = "Add Department Information";
            // 
            // textDeptBudget
            // 
            this.textDeptBudget.Location = new System.Drawing.Point(250, 240);
            this.textDeptBudget.Multiline = true;
            this.textDeptBudget.Name = "textDeptBudget";
            this.textDeptBudget.Size = new System.Drawing.Size(500, 50);
            this.textDeptBudget.TabIndex = 15;
            this.textDeptBudget.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // textDeptName
            // 
            this.textDeptName.Location = new System.Drawing.Point(250, 153);
            this.textDeptName.Multiline = true;
            this.textDeptName.Name = "textDeptName";
            this.textDeptName.Size = new System.Drawing.Size(500, 50);
            this.textDeptName.TabIndex = 14;
            this.textDeptName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // Budget
            // 
            this.Budget.Location = new System.Drawing.Point(51, 240);
            this.Budget.Name = "Budget";
            this.Budget.Size = new System.Drawing.Size(118, 57);
            this.Budget.TabIndex = 13;
            this.Budget.Text = "Budget";
            this.Budget.UseVisualStyleBackColor = true;
            // 
            // DeptName
            // 
            this.DeptName.Location = new System.Drawing.Point(51, 153);
            this.DeptName.Name = "DeptName";
            this.DeptName.Size = new System.Drawing.Size(118, 57);
            this.DeptName.TabIndex = 12;
            this.DeptName.Text = "DeptName";
            this.DeptName.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(376, 333);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(118, 57);
            this.Submit.TabIndex = 16;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.textDeptBudget);
            this.Controls.Add(this.textDeptName);
            this.Controls.Add(this.Budget);
            this.Controls.Add(this.DeptName);
            this.Controls.Add(this.AddDepartmentInformation);
            this.Name = "AddDepartmentForm";
            this.Text = "AddDepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddDepartmentInformation;
        private System.Windows.Forms.TextBox textDeptBudget;
        private System.Windows.Forms.TextBox textDeptName;
        private System.Windows.Forms.Button Budget;
        private System.Windows.Forms.Button DeptName;
        private System.Windows.Forms.Button Submit;
    }
}