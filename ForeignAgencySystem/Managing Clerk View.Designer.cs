
namespace ForeignAgencySystem
{
    partial class Managing_Clerk_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managing_Clerk_View));
            this.btn_Emp_Registor = new System.Windows.Forms.Button();
            this.btn_visa = new System.Windows.Forms.Button();
            this.btn_Client_Details = new System.Windows.Forms.Button();
            this.btn_postIssies = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Emp_Registor
            // 
            this.btn_Emp_Registor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Emp_Registor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_Registor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Emp_Registor.Location = new System.Drawing.Point(444, 556);
            this.btn_Emp_Registor.Name = "btn_Emp_Registor";
            this.btn_Emp_Registor.Size = new System.Drawing.Size(474, 45);
            this.btn_Emp_Registor.TabIndex = 2;
            this.btn_Emp_Registor.Text = "Request Medical Test";
            this.btn_Emp_Registor.UseVisualStyleBackColor = false;
            // 
            // btn_visa
            // 
            this.btn_visa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_visa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_visa.Location = new System.Drawing.Point(444, 288);
            this.btn_visa.Name = "btn_visa";
            this.btn_visa.Size = new System.Drawing.Size(474, 45);
            this.btn_visa.TabIndex = 3;
            this.btn_visa.Text = "Update Visa Status";
            this.btn_visa.UseVisualStyleBackColor = false;
            this.btn_visa.Click += new System.EventHandler(this.btn_visa_Click);
            // 
            // btn_Client_Details
            // 
            this.btn_Client_Details.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Client_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Client_Details.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Client_Details.Location = new System.Drawing.Point(444, 384);
            this.btn_Client_Details.Name = "btn_Client_Details";
            this.btn_Client_Details.Size = new System.Drawing.Size(474, 45);
            this.btn_Client_Details.TabIndex = 4;
            this.btn_Client_Details.Text = "View Client Details";
            this.btn_Client_Details.UseVisualStyleBackColor = false;
            this.btn_Client_Details.Click += new System.EventHandler(this.btn_Client_Details_Click);
            // 
            // btn_postIssies
            // 
            this.btn_postIssies.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_postIssies.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_postIssies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_postIssies.Location = new System.Drawing.Point(444, 475);
            this.btn_postIssies.Name = "btn_postIssies";
            this.btn_postIssies.Size = new System.Drawing.Size(474, 45);
            this.btn_postIssies.TabIndex = 5;
            this.btn_postIssies.Text = "Post Recruitment Issues";
            this.btn_postIssies.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_visa);
            this.panel1.Controls.Add(this.btn_postIssies);
            this.panel1.Controls.Add(this.btn_Emp_Registor);
            this.panel1.Controls.Add(this.btn_Client_Details);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 6;
            // 
            // Managing_Clerk_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Name = "Managing_Clerk_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managing_Clerk_View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Emp_Registor;
        private System.Windows.Forms.Button btn_visa;
        private System.Windows.Forms.Button btn_Client_Details;
        private System.Windows.Forms.Button btn_postIssies;
        private System.Windows.Forms.Panel panel1;
    }
}