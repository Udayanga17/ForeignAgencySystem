
namespace ForeignAgencySystem
{
    partial class Language_Translateor_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Language_Translateor_view));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Client_Details = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btn_Client_Details
            // 
            this.btn_Client_Details.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Client_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Client_Details.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Client_Details.Location = new System.Drawing.Point(350, 290);
            this.btn_Client_Details.Name = "btn_Client_Details";
            this.btn_Client_Details.Size = new System.Drawing.Size(650, 45);
            this.btn_Client_Details.TabIndex = 2;
            this.btn_Client_Details.Text = "View Client Details";
            this.btn_Client_Details.UseVisualStyleBackColor = false;
            this.btn_Client_Details.Click += new System.EventHandler(this.btn_Client_Details_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_Client_Details);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 3;
            // 
            // Language_Translateor_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Language_Translateor_view";
            this.Text = "Language_Translateor_view";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Client_Details;
        private System.Windows.Forms.Panel panel1;
    }
}