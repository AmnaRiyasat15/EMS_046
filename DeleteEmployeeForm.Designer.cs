namespace EmployeeManagementSystem
{
    partial class DeleteEmployeeForm
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
            this.DeleteEmp = new System.Windows.Forms.Button();
            this.textEmpID = new System.Windows.Forms.TextBox();
            this.EmpID = new System.Windows.Forms.Button();
            this.DeleteEmpInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteEmp
            // 
            this.DeleteEmp.Location = new System.Drawing.Point(366, 307);
            this.DeleteEmp.Name = "DeleteEmp";
            this.DeleteEmp.Size = new System.Drawing.Size(118, 57);
            this.DeleteEmp.TabIndex = 15;
            this.DeleteEmp.Text = "DeleteEmp";
            this.DeleteEmp.UseVisualStyleBackColor = true;
            this.DeleteEmp.Click += new System.EventHandler(this.DeleteEmp_Click);
            // 
            // textEmpID
            // 
            this.textEmpID.Location = new System.Drawing.Point(250, 181);
            this.textEmpID.Multiline = true;
            this.textEmpID.Name = "textEmpID";
            this.textEmpID.Size = new System.Drawing.Size(500, 50);
            this.textEmpID.TabIndex = 14;
            this.textEmpID.TextChanged += new System.EventHandler(this.textEmpID_TextChanged);
            // 
            // EmpID
            // 
            this.EmpID.Location = new System.Drawing.Point(51, 181);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(118, 57);
            this.EmpID.TabIndex = 13;
            this.EmpID.Text = "EmpID";
            this.EmpID.UseVisualStyleBackColor = true;
            // 
            // DeleteEmpInformation
            // 
            this.DeleteEmpInformation.AutoSize = true;
            this.DeleteEmpInformation.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteEmpInformation.Location = new System.Drawing.Point(310, 86);
            this.DeleteEmpInformation.Name = "DeleteEmpInformation";
            this.DeleteEmpInformation.Size = new System.Drawing.Size(215, 20);
            this.DeleteEmpInformation.TabIndex = 12;
            this.DeleteEmpInformation.Text = "Delete Employee Information";
            this.DeleteEmpInformation.Click += new System.EventHandler(this.DeleteEmpInformation_Click);
            // 
            // DeleteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteEmp);
            this.Controls.Add(this.textEmpID);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.DeleteEmpInformation);
            this.Name = "DeleteEmployeeForm";
            this.Text = "DeleteEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteEmp;
        private System.Windows.Forms.TextBox textEmpID;
        private System.Windows.Forms.Button EmpID;
        private System.Windows.Forms.Label DeleteEmpInformation;
    }
}