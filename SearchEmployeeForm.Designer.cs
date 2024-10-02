namespace EmployeeManagementSystem
{
    partial class SearchEmployeeForm
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
            this.SearchEmployee = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.textDeptID = new System.Windows.Forms.TextBox();
            this.SearchINPUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchEmployee
            // 
            this.SearchEmployee.Location = new System.Drawing.Point(187, 51);
            this.SearchEmployee.Name = "SearchEmployee";
            this.SearchEmployee.Size = new System.Drawing.Size(319, 34);
            this.SearchEmployee.TabIndex = 0;
            this.SearchEmployee.Text = "Search Employee Form";
            this.SearchEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(286, 268);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(118, 57);
            this.Search.TabIndex = 33;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textDeptID
            // 
            this.textDeptID.Location = new System.Drawing.Point(84, 193);
            this.textDeptID.Multiline = true;
            this.textDeptID.Name = "textDeptID";
            this.textDeptID.Size = new System.Drawing.Size(500, 50);
            this.textDeptID.TabIndex = 27;
            this.textDeptID.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // SearchINPUT
            // 
            this.SearchINPUT.Location = new System.Drawing.Point(84, 107);
            this.SearchINPUT.Name = "SearchINPUT";
            this.SearchINPUT.Size = new System.Drawing.Size(500, 57);
            this.SearchINPUT.TabIndex = 30;
            this.SearchINPUT.Text = "FirstName,LastName, Position, DeptID";
            this.SearchINPUT.UseVisualStyleBackColor = true;
            // 
            // SearchEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchINPUT);
            this.Controls.Add(this.textDeptID);
            this.Controls.Add(this.SearchEmployee);
            this.Name = "SearchEmployeeForm";
            this.Text = "SearchEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchEmployee;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textDeptID;
        private System.Windows.Forms.Button SearchINPUT;
    }
}