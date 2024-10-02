namespace EmployeeManagementSystem
{
    partial class UpdateDepartmentForm
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
            this.DeptID = new System.Windows.Forms.Button();
            this.textDeptName = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.textDeptID = new System.Windows.Forms.TextBox();
            this.UpdateDept = new System.Windows.Forms.Button();
            this.Budget = new System.Windows.Forms.Button();
            this.DeptName = new System.Windows.Forms.Button();
            this.UpdateDepartmentInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeptID
            // 
            this.DeptID.Location = new System.Drawing.Point(255, 113);
            this.DeptID.Name = "DeptID";
            this.DeptID.Size = new System.Drawing.Size(118, 57);
            this.DeptID.TabIndex = 38;
            this.DeptID.Text = "DeptID";
            this.DeptID.UseVisualStyleBackColor = true;
            // 
            // textDeptName
            // 
            this.textDeptName.Location = new System.Drawing.Point(437, 200);
            this.textDeptName.Multiline = true;
            this.textDeptName.Name = "textDeptName";
            this.textDeptName.Size = new System.Drawing.Size(500, 50);
            this.textDeptName.TabIndex = 37;
            this.textDeptName.TextChanged += new System.EventHandler(this.textDeptName_TextChanged);
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(437, 290);
            this.txtBudget.Multiline = true;
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(500, 50);
            this.txtBudget.TabIndex = 34;
            this.txtBudget.TextChanged += new System.EventHandler(this.txtBudget_TextChanged);
            // 
            // textDeptID
            // 
            this.textDeptID.Location = new System.Drawing.Point(437, 113);
            this.textDeptID.Multiline = true;
            this.textDeptID.Name = "textDeptID";
            this.textDeptID.Size = new System.Drawing.Size(500, 50);
            this.textDeptID.TabIndex = 33;
            this.textDeptID.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // UpdateDept
            // 
            this.UpdateDept.Location = new System.Drawing.Point(528, 397);
            this.UpdateDept.Name = "UpdateDept";
            this.UpdateDept.Size = new System.Drawing.Size(118, 57);
            this.UpdateDept.TabIndex = 32;
            this.UpdateDept.Text = "Update";
            this.UpdateDept.UseVisualStyleBackColor = true;
            this.UpdateDept.Click += new System.EventHandler(this.Update_Click);
            // 
            // Budget
            // 
            this.Budget.Location = new System.Drawing.Point(255, 283);
            this.Budget.Name = "Budget";
            this.Budget.Size = new System.Drawing.Size(118, 57);
            this.Budget.TabIndex = 28;
            this.Budget.Text = "Budget";
            this.Budget.UseVisualStyleBackColor = true;
            // 
            // DeptName
            // 
            this.DeptName.Location = new System.Drawing.Point(255, 193);
            this.DeptName.Name = "DeptName";
            this.DeptName.Size = new System.Drawing.Size(118, 57);
            this.DeptName.TabIndex = 27;
            this.DeptName.Text = "DeptName";
            this.DeptName.UseVisualStyleBackColor = true;
            // 
            // UpdateDepartmentInformation
            // 
            this.UpdateDepartmentInformation.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateDepartmentInformation.Location = new System.Drawing.Point(420, 21);
            this.UpdateDepartmentInformation.Name = "UpdateDepartmentInformation";
            this.UpdateDepartmentInformation.Size = new System.Drawing.Size(392, 54);
            this.UpdateDepartmentInformation.TabIndex = 26;
            this.UpdateDepartmentInformation.Text = "Update Department Information";
            this.UpdateDepartmentInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 588);
            this.Controls.Add(this.DeptID);
            this.Controls.Add(this.textDeptName);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.textDeptID);
            this.Controls.Add(this.UpdateDept);
            this.Controls.Add(this.Budget);
            this.Controls.Add(this.DeptName);
            this.Controls.Add(this.UpdateDepartmentInformation);
            this.Name = "UpdateDepartmentForm";
            this.Text = "UpdateDepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeptID;
        private System.Windows.Forms.TextBox textDeptName;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox textDeptID;
        private System.Windows.Forms.Button UpdateDept;
        private System.Windows.Forms.Button Budget;
        private System.Windows.Forms.Button DeptName;
        private System.Windows.Forms.Label UpdateDepartmentInformation;
    }
}