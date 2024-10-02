namespace EmployeeManagementSystem
{
    partial class DeleteDepartmentForm
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
            this.textDeptID = new System.Windows.Forms.TextBox();
            this.DeptID = new System.Windows.Forms.Button();
            this.DeleteDeptInformation = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDeptID
            // 
            this.textDeptID.Location = new System.Drawing.Point(250, 237);
            this.textDeptID.Multiline = true;
            this.textDeptID.Name = "textDeptID";
            this.textDeptID.Size = new System.Drawing.Size(500, 50);
            this.textDeptID.TabIndex = 10;
            this.textDeptID.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // DeptID
            // 
            this.DeptID.Location = new System.Drawing.Point(51, 237);
            this.DeptID.Name = "DeptID";
            this.DeptID.Size = new System.Drawing.Size(118, 57);
            this.DeptID.TabIndex = 9;
            this.DeptID.Text = "DeptID";
            this.DeptID.UseVisualStyleBackColor = true;
            // 
            // DeleteDeptInformation
            // 
            this.DeleteDeptInformation.AutoSize = true;
            this.DeleteDeptInformation.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteDeptInformation.Location = new System.Drawing.Point(310, 142);
            this.DeleteDeptInformation.Name = "DeleteDeptInformation";
            this.DeleteDeptInformation.Size = new System.Drawing.Size(230, 20);
            this.DeleteDeptInformation.TabIndex = 8;
            this.DeleteDeptInformation.Text = "Delete Department Information";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(366, 363);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 57);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.textDeptID);
            this.Controls.Add(this.DeptID);
            this.Controls.Add(this.DeleteDeptInformation);
            this.Name = "DeleteDepartmentForm";
            this.Text = "DeleteDepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDeptID;
        private System.Windows.Forms.Button DeptID;
        private System.Windows.Forms.Label DeleteDeptInformation;
        private System.Windows.Forms.Button Delete;
    }
}