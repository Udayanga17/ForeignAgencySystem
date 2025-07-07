
namespace ForeignAgencySystem
{
    partial class Advaned_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advaned_Payment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_koreanResult = new System.Windows.Forms.CheckBox();
            this.txt_advance = new System.Windows.Forms.TextBox();
            this.cb_language = new System.Windows.Forms.CheckBox();
            this.cb_personality = new System.Windows.Forms.CheckBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.cb_skil = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_welderId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cb_koreanResult);
            this.panel1.Controls.Add(this.txt_advance);
            this.panel1.Controls.Add(this.cb_language);
            this.panel1.Controls.Add(this.cb_personality);
            this.panel1.Controls.Add(this.btn_pay);
            this.panel1.Controls.Add(this.cb_skil);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_welderId);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cb_koreanResult
            // 
            this.cb_koreanResult.AutoSize = true;
            this.cb_koreanResult.BackColor = System.Drawing.Color.Transparent;
            this.cb_koreanResult.Location = new System.Drawing.Point(680, 264);
            this.cb_koreanResult.Name = "cb_koreanResult";
            this.cb_koreanResult.Size = new System.Drawing.Size(15, 14);
            this.cb_koreanResult.TabIndex = 14;
            this.cb_koreanResult.UseVisualStyleBackColor = false;
            this.cb_koreanResult.CheckedChanged += new System.EventHandler(this.cb_koreanResult_CheckedChanged);
            // 
            // txt_advance
            // 
            this.txt_advance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_advance.Location = new System.Drawing.Point(555, 604);
            this.txt_advance.Name = "txt_advance";
            this.txt_advance.Size = new System.Drawing.Size(431, 38);
            this.txt_advance.TabIndex = 11;
            // 
            // cb_language
            // 
            this.cb_language.AutoSize = true;
            this.cb_language.BackColor = System.Drawing.Color.Transparent;
            this.cb_language.Location = new System.Drawing.Point(442, 470);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(15, 14);
            this.cb_language.TabIndex = 9;
            this.cb_language.UseVisualStyleBackColor = false;
            this.cb_language.CheckedChanged += new System.EventHandler(this.cb_language_CheckedChanged);
            // 
            // cb_personality
            // 
            this.cb_personality.AutoSize = true;
            this.cb_personality.BackColor = System.Drawing.Color.Transparent;
            this.cb_personality.Location = new System.Drawing.Point(442, 536);
            this.cb_personality.Name = "cb_personality";
            this.cb_personality.Size = new System.Drawing.Size(15, 14);
            this.cb_personality.TabIndex = 9;
            this.cb_personality.UseVisualStyleBackColor = false;
            this.cb_personality.CheckedChanged += new System.EventHandler(this.cb_personality_CheckedChanged);
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Location = new System.Drawing.Point(1025, 598);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(129, 47);
            this.btn_pay.TabIndex = 8;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // cb_skil
            // 
            this.cb_skil.AutoSize = true;
            this.cb_skil.BackColor = System.Drawing.Color.Transparent;
            this.cb_skil.Location = new System.Drawing.Point(442, 407);
            this.cb_skil.Name = "cb_skil";
            this.cb_skil.Size = new System.Drawing.Size(15, 14);
            this.cb_skil.TabIndex = 9;
            this.cb_skil.UseVisualStyleBackColor = false;
            this.cb_skil.CheckedChanged += new System.EventHandler(this.cb_skil_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(946, 151);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(132, 45);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_welderId
            // 
            this.txt_welderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_welderId.Location = new System.Drawing.Point(436, 157);
            this.txt_welderId.Name = "txt_welderId";
            this.txt_welderId.Size = new System.Drawing.Size(467, 36);
            this.txt_welderId.TabIndex = 5;
            // 
            // Advaned_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Advaned_Payment";
            this.Text = "Advaned_Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Advaned_Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_koreanResult;
        private System.Windows.Forms.TextBox txt_advance;
        private System.Windows.Forms.CheckBox cb_language;
        private System.Windows.Forms.CheckBox cb_personality;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.CheckBox cb_skil;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_welderId;
    }
}