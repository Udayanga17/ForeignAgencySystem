
namespace ForeignAgencySystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbn_male = new System.Windows.Forms.RadioButton();
            this.rbn_female = new System.Windows.Forms.RadioButton();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.txt_repassword = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.txt_empNO = new System.Windows.Forms.TextBox();
            this.btn_Registor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb_Possition = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbn_male
            // 
            this.rbn_male.AutoSize = true;
            this.rbn_male.Location = new System.Drawing.Point(294, 284);
            this.rbn_male.Name = "rbn_male";
            this.rbn_male.Size = new System.Drawing.Size(14, 13);
            this.rbn_male.TabIndex = 14;
            this.rbn_male.TabStop = true;
            this.rbn_male.UseVisualStyleBackColor = true;
            this.rbn_male.CheckedChanged += new System.EventHandler(this.rbn_male_CheckedChanged);
            // 
            // rbn_female
            // 
            this.rbn_female.AutoSize = true;
            this.rbn_female.Location = new System.Drawing.Point(504, 285);
            this.rbn_female.Name = "rbn_female";
            this.rbn_female.Size = new System.Drawing.Size(14, 13);
            this.rbn_female.TabIndex = 13;
            this.rbn_female.TabStop = true;
            this.rbn_female.UseVisualStyleBackColor = true;
            this.rbn_female.CheckedChanged += new System.EventHandler(this.rbn_female_CheckedChanged);
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(291, 367);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(351, 29);
            this.dob.TabIndex = 12;
            // 
            // txt_repassword
            // 
            this.txt_repassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repassword.Location = new System.Drawing.Point(292, 672);
            this.txt_repassword.Name = "txt_repassword";
            this.txt_repassword.PasswordChar = '*';
            this.txt_repassword.Size = new System.Drawing.Size(351, 29);
            this.txt_repassword.TabIndex = 11;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(292, 628);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(351, 29);
            this.txt_password.TabIndex = 11;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(292, 584);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(351, 29);
            this.txt_username.TabIndex = 11;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(291, 498);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(351, 29);
            this.txt_email.TabIndex = 11;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(291, 454);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(351, 31);
            this.txt_address.TabIndex = 11;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobile.Location = new System.Drawing.Point(291, 410);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(351, 29);
            this.txt_mobile.TabIndex = 11;
            // 
            // txt_nic
            // 
            this.txt_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nic.Location = new System.Drawing.Point(291, 323);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(351, 29);
            this.txt_nic.TabIndex = 11;
            // 
            // txt_lName
            // 
            this.txt_lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lName.Location = new System.Drawing.Point(293, 238);
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(349, 29);
            this.txt_lName.TabIndex = 11;
            // 
            // txt_fName
            // 
            this.txt_fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fName.Location = new System.Drawing.Point(293, 194);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(349, 29);
            this.txt_fName.TabIndex = 11;
            // 
            // txt_empNO
            // 
            this.txt_empNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empNO.Location = new System.Drawing.Point(293, 150);
            this.txt_empNO.Name = "txt_empNO";
            this.txt_empNO.ReadOnly = true;
            this.txt_empNO.Size = new System.Drawing.Size(349, 29);
            this.txt_empNO.TabIndex = 11;
            // 
            // btn_Registor
            // 
            this.btn_Registor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Registor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registor.Location = new System.Drawing.Point(712, 650);
            this.btn_Registor.Name = "btn_Registor";
            this.btn_Registor.Size = new System.Drawing.Size(107, 43);
            this.btn_Registor.TabIndex = 15;
            this.btn_Registor.Text = "Register";
            this.btn_Registor.UseVisualStyleBackColor = false;
            this.btn_Registor.Click += new System.EventHandler(this.btn_Registor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(704, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 431);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1182, 144);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 33);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(863, 147);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(291, 29);
            this.txtsearch.TabIndex = 19;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(844, 650);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 43);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1103, 650);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 43);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(1226, 650);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(107, 43);
            this.btn_Back.TabIndex = 21;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.cmb_Possition);
            this.panel5.Controls.Add(this.btn_clear);
            this.panel5.Controls.Add(this.rbn_male);
            this.panel5.Controls.Add(this.txtsearch);
            this.panel5.Controls.Add(this.rbn_female);
            this.panel5.Controls.Add(this.btn_search);
            this.panel5.Controls.Add(this.txt_empNO);
            this.panel5.Controls.Add(this.txt_lName);
            this.panel5.Controls.Add(this.txt_fName);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.btn_delete);
            this.panel5.Controls.Add(this.btn_Back);
            this.panel5.Controls.Add(this.txt_repassword);
            this.panel5.Controls.Add(this.txt_password);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.dob);
            this.panel5.Controls.Add(this.txt_nic);
            this.panel5.Controls.Add(this.txt_username);
            this.panel5.Controls.Add(this.btn_Registor);
            this.panel5.Controls.Add(this.txt_email);
            this.panel5.Controls.Add(this.txt_address);
            this.panel5.Controls.Add(this.txt_mobile);
            this.panel5.Location = new System.Drawing.Point(0, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1366, 745);
            this.panel5.TabIndex = 22;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cmb_Possition
            // 
            this.cmb_Possition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Possition.FormattingEnabled = true;
            this.cmb_Possition.Items.AddRange(new object[] {
            "Office Clerk",
            "Admin",
            "Language Translator",
            "Managing Clerk",
            "File Handling Clerk",
            "Registration Clerk",
            "Coordinator",
            "Executive",
            "Training Program Coordinator",
            "Payment Clerk"});
            this.cmb_Possition.Location = new System.Drawing.Point(291, 539);
            this.cmb_Possition.Name = "cmb_Possition";
            this.cmb_Possition.Size = new System.Drawing.Size(351, 32);
            this.cmb_Possition.TabIndex = 25;
            this.cmb_Possition.SelectedIndexChanged += new System.EventHandler(this.cmb_Possition_SelectedIndexChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(974, 650);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 43);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "Clear ";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel5);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1364, 718);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Registor;
        private System.Windows.Forms.RadioButton rbn_male;
        private System.Windows.Forms.RadioButton rbn_female;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox txt_repassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.TextBox txt_empNO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmb_Possition;
    }
}

