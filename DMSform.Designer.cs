namespace EmployeeManagementSystem
{
    partial class DMSform
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
            this.AddDept = new System.Windows.Forms.Button();
            this.ReadDept = new System.Windows.Forms.Button();
            this.DeleteDept = new System.Windows.Forms.Button();
            this.UpdateDept = new System.Windows.Forms.Button();
            this.AllDept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddDept
            // 
            this.AddDept.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddDept.Location = new System.Drawing.Point(309, 81);
            this.AddDept.Name = "AddDept";
            this.AddDept.Size = new System.Drawing.Size(167, 78);
            this.AddDept.TabIndex = 0;
            this.AddDept.Text = "AddDept";
            this.AddDept.UseVisualStyleBackColor = false;
            this.AddDept.Click += new System.EventHandler(this.AddDept_Click);
            // 
            // ReadDept
            // 
            this.ReadDept.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReadDept.Location = new System.Drawing.Point(309, 183);
            this.ReadDept.Name = "ReadDept";
            this.ReadDept.Size = new System.Drawing.Size(167, 78);
            this.ReadDept.TabIndex = 1;
            this.ReadDept.Text = "ReadDept";
            this.ReadDept.UseVisualStyleBackColor = false;
            // 
            // DeleteDept
            // 
            this.DeleteDept.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DeleteDept.Location = new System.Drawing.Point(309, 290);
            this.DeleteDept.Name = "DeleteDept";
            this.DeleteDept.Size = new System.Drawing.Size(167, 78);
            this.DeleteDept.TabIndex = 2;
            this.DeleteDept.Text = "DeleteDept";
            this.DeleteDept.UseVisualStyleBackColor = false;
            this.DeleteDept.Click += new System.EventHandler(this.DeleteDept_Click);
            // 
            // UpdateDept
            // 
            this.UpdateDept.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateDept.Location = new System.Drawing.Point(309, 401);
            this.UpdateDept.Name = "UpdateDept";
            this.UpdateDept.Size = new System.Drawing.Size(167, 78);
            this.UpdateDept.TabIndex = 3;
            this.UpdateDept.Text = "UpdateDept";
            this.UpdateDept.UseVisualStyleBackColor = false;
            this.UpdateDept.Click += new System.EventHandler(this.UpdateDept_Click);
            // 
            // AllDept
            // 
            this.AllDept.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AllDept.Location = new System.Drawing.Point(309, 512);
            this.AllDept.Name = "AllDept";
            this.AllDept.Size = new System.Drawing.Size(167, 78);
            this.AllDept.TabIndex = 4;
            this.AllDept.Text = "AllDept";
            this.AllDept.UseVisualStyleBackColor = false;
            // 
            // DMSform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.AllDept);
            this.Controls.Add(this.UpdateDept);
            this.Controls.Add(this.DeleteDept);
            this.Controls.Add(this.ReadDept);
            this.Controls.Add(this.AddDept);
            this.Name = "DMSform";
            this.Text = "DMSform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddDept;
        private System.Windows.Forms.Button ReadDept;
        private System.Windows.Forms.Button DeleteDept;
        private System.Windows.Forms.Button UpdateDept;
        private System.Windows.Forms.Button AllDept;
    }
}