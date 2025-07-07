
namespace ForeignAgencySystem
{
    partial class Coordinator_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coordinator_View));
            this.btn_local = new System.Windows.Forms.Button();
            this.btn_korean = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_local
            // 
            this.btn_local.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_local.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_local.Location = new System.Drawing.Point(304, 271);
            this.btn_local.Name = "btn_local";
            this.btn_local.Size = new System.Drawing.Size(746, 53);
            this.btn_local.TabIndex = 14;
            this.btn_local.Text = "Local Test Request";
            this.btn_local.UseVisualStyleBackColor = false;
            this.btn_local.Click += new System.EventHandler(this.btn_local_Click);
            // 
            // btn_korean
            // 
            this.btn_korean.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_korean.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_korean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_korean.Location = new System.Drawing.Point(304, 387);
            this.btn_korean.Name = "btn_korean";
            this.btn_korean.Size = new System.Drawing.Size(746, 53);
            this.btn_korean.TabIndex = 15;
            this.btn_korean.Text = "Korean Test Request";
            this.btn_korean.UseVisualStyleBackColor = false;
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_attendance.Location = new System.Drawing.Point(304, 501);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(746, 53);
            this.btn_attendance.TabIndex = 16;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_local);
            this.panel1.Controls.Add(this.btn_attendance);
            this.panel1.Controls.Add(this.btn_korean);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 17;
            // 
            // Coordinator_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Name = "Coordinator_View";
            this.Text = "Coordinator_View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_local;
        private System.Windows.Forms.Button btn_korean;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Panel panel1;
    }
}