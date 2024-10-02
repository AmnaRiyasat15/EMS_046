namespace EmployeeManagementSystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeFeature = new System.Windows.Forms.Button();
            this.DepartmentFeature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(428, 22);
            this.label1.MaximumSize = new System.Drawing.Size(170, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to EMS\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeFeature
            // 
            this.EmployeeFeature.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.EmployeeFeature.Location = new System.Drawing.Point(84, 106);
            this.EmployeeFeature.Name = "EmployeeFeature";
            this.EmployeeFeature.Size = new System.Drawing.Size(181, 76);
            this.EmployeeFeature.TabIndex = 1;
            this.EmployeeFeature.Text = "Employee";
            this.EmployeeFeature.UseVisualStyleBackColor = false;
            this.EmployeeFeature.Click += new System.EventHandler(this.EmployeeFeature_Click);
            // 
            // DepartmentFeature
            // 
            this.DepartmentFeature.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DepartmentFeature.Location = new System.Drawing.Point(684, 106);
            this.DepartmentFeature.Name = "DepartmentFeature";
            this.DepartmentFeature.Size = new System.Drawing.Size(181, 76);
            this.DepartmentFeature.TabIndex = 2;
            this.DepartmentFeature.Text = "Department";
            this.DepartmentFeature.UseVisualStyleBackColor = false;
            this.DepartmentFeature.Click += new System.EventHandler(this.DepartmentFeature_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.DepartmentFeature);
            this.Controls.Add(this.EmployeeFeature);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmployeeFeature;
        private System.Windows.Forms.Button DepartmentFeature;
    }
}

