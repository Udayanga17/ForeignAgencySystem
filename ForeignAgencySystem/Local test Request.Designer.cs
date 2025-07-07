
namespace ForeignAgencySystem
{
    partial class Local_test_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Local_test_Request));
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.cb_2 = new System.Windows.Forms.CheckBox();
            this.cb_3 = new System.Windows.Forms.CheckBox();
            this.btn_Request = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.dta_End = new System.Windows.Forms.DateTimePicker();
            this.dta_Start = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1001, 145);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(132, 42);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.BackColor = System.Drawing.Color.Transparent;
            this.cb_1.Location = new System.Drawing.Point(1203, 351);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(15, 14);
            this.cb_1.TabIndex = 10;
            this.cb_1.UseVisualStyleBackColor = false;
            this.cb_1.CheckedChanged += new System.EventHandler(this.cb_1_CheckedChanged);
            // 
            // cb_2
            // 
            this.cb_2.AutoSize = true;
            this.cb_2.BackColor = System.Drawing.Color.Transparent;
            this.cb_2.Location = new System.Drawing.Point(1203, 456);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(15, 14);
            this.cb_2.TabIndex = 11;
            this.cb_2.UseVisualStyleBackColor = false;
            this.cb_2.CheckedChanged += new System.EventHandler(this.cb_2_CheckedChanged);
            // 
            // cb_3
            // 
            this.cb_3.AutoSize = true;
            this.cb_3.BackColor = System.Drawing.Color.Transparent;
            this.cb_3.Location = new System.Drawing.Point(1203, 560);
            this.cb_3.Name = "cb_3";
            this.cb_3.Size = new System.Drawing.Size(15, 14);
            this.cb_3.TabIndex = 12;
            this.cb_3.UseVisualStyleBackColor = false;
            this.cb_3.CheckedChanged += new System.EventHandler(this.cb_3_CheckedChanged);
            // 
            // btn_Request
            // 
            this.btn_Request.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Request.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Request.Location = new System.Drawing.Point(1174, 664);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(132, 42);
            this.btn_Request.TabIndex = 15;
            this.btn_Request.Text = "Request";
            this.btn_Request.UseVisualStyleBackColor = false;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(1001, 664);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(132, 42);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.FormattingEnabled = true;
            this.textBox1.Location = new System.Drawing.Point(462, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 39);
            this.textBox1.TabIndex = 13;
            this.textBox1.SelectedIndexChanged += new System.EventHandler(this.cmb_available_ID_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btn_select);
            this.panel1.Controls.Add(this.dta_End);
            this.panel1.Controls.Add(this.dta_Start);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cb_1);
            this.panel1.Controls.Add(this.btn_Request);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.cb_2);
            this.panel1.Controls.Add(this.cb_3);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(345, 395);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(351, 38);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Location = new System.Drawing.Point(737, 664);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(132, 42);
            this.btn_select.TabIndex = 22;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // dta_End
            // 
            this.dta_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dta_End.Location = new System.Drawing.Point(255, 334);
            this.dta_End.Name = "dta_End";
            this.dta_End.Size = new System.Drawing.Size(441, 38);
            this.dta_End.TabIndex = 19;
            this.dta_End.Value = new System.DateTime(2024, 6, 20, 0, 0, 0, 0);
            this.dta_End.ValueChanged += new System.EventHandler(this.dta_End_ValueChanged);
            // 
            // dta_Start
            // 
            this.dta_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dta_Start.Location = new System.Drawing.Point(255, 271);
            this.dta_Start.Name = "dta_Start";
            this.dta_Start.Size = new System.Drawing.Size(441, 38);
            this.dta_Start.TabIndex = 18;
            this.dta_Start.Value = new System.DateTime(2024, 6, 20, 0, 0, 0, 0);
            this.dta_Start.ValueChanged += new System.EventHandler(this.dta_Start_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 467);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 243);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Local_test_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Name = "Local_test_Request";
            this.Text = "Local_test_Request";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Local_test_Request_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.CheckBox cb_2;
        private System.Windows.Forms.CheckBox cb_3;
        private System.Windows.Forms.Button btn_Request;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ComboBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DateTimePicker dta_End;
        private System.Windows.Forms.DateTimePicker dta_Start;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
    }
}