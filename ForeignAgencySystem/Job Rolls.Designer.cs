
namespace ForeignAgencySystem
{
    partial class Job_Rolls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job_Rolls));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_houseMaid = new System.Windows.Forms.Button();
            this.btn_cook = new System.Windows.Forms.Button();
            this.btn_welder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1027, 405);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(173, 55);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_houseMaid
            // 
            this.btn_houseMaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_houseMaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_houseMaid.Location = new System.Drawing.Point(558, 391);
            this.btn_houseMaid.Name = "btn_houseMaid";
            this.btn_houseMaid.Size = new System.Drawing.Size(253, 76);
            this.btn_houseMaid.TabIndex = 8;
            this.btn_houseMaid.Text = "Housemaid";
            this.btn_houseMaid.UseVisualStyleBackColor = true;
            // 
            // btn_cook
            // 
            this.btn_cook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cook.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cook.Location = new System.Drawing.Point(558, 547);
            this.btn_cook.Name = "btn_cook";
            this.btn_cook.Size = new System.Drawing.Size(253, 76);
            this.btn_cook.TabIndex = 7;
            this.btn_cook.Text = "Cook";
            this.btn_cook.UseVisualStyleBackColor = true;
            // 
            // btn_welder
            // 
            this.btn_welder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_welder.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_welder.Location = new System.Drawing.Point(558, 235);
            this.btn_welder.Name = "btn_welder";
            this.btn_welder.Size = new System.Drawing.Size(253, 76);
            this.btn_welder.TabIndex = 6;
            this.btn_welder.Text = "Welder";
            this.btn_welder.UseVisualStyleBackColor = true;
            this.btn_welder.Click += new System.EventHandler(this.btn_welder_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_welder);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_cook);
            this.panel1.Controls.Add(this.btn_houseMaid);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 745);
            this.panel1.TabIndex = 10;
            // 
            // Job_Rolls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Name = "Job_Rolls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job_Rolls";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_houseMaid;
        private System.Windows.Forms.Button btn_cook;
        private System.Windows.Forms.Button btn_welder;
        private System.Windows.Forms.Panel panel1;
    }
}