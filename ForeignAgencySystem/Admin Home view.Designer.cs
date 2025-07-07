
namespace ForeignAgencySystem
{
    partial class Admin_Home_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Home_view));
            this.btn_Emp_Registor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Emp_Registor
            // 
            this.btn_Emp_Registor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Emp_Registor.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_Registor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Emp_Registor.Location = new System.Drawing.Point(300, 231);
            this.btn_Emp_Registor.Name = "btn_Emp_Registor";
            this.btn_Emp_Registor.Size = new System.Drawing.Size(728, 59);
            this.btn_Emp_Registor.TabIndex = 1;
            this.btn_Emp_Registor.Text = "Employee Registration";
            this.btn_Emp_Registor.UseVisualStyleBackColor = false;
            this.btn_Emp_Registor.Click += new System.EventHandler(this.btn_Emp_Registor_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_Emp_Registor);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 2;
            // 
            // Admin_Home_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Home_view";
            this.Text = "Admin_Home_view";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Emp_Registor;
        private System.Windows.Forms.Panel panel1;
    }
}