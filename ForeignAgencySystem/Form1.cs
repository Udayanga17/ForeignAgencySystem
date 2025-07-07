using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ForeignAgencySystem
{
    public partial class Form1 : Form

       
    {

        string gender;
        DataSet ds;
        String a = "EMP";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Registor_Click(object sender, EventArgs e)
        {

            String pw = this.txt_password.Text;
            String rpw = this.txt_repassword.Text;

            if (txt_address.Text == "" || txt_email.Text == "" || txt_fName.Text == "" || txt_lName.Text == "" || txt_mobile.Text == "" || txt_nic.Text == ""||cmb_Possition.Text =="")
            {

                MessageBox.Show(" All fields are required to proceed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (pw != rpw)
                {
                    MessageBox.Show(" Wrong Re-type Password:", "Information");

                }
                else if (pw == rpw)
                {

                    //create a connection with mssql server
                    string cs = @"Data Source = DESKTOP-KMN9R2D; 
                    Initial Catalog = ForeignAgency;
                    Integrated Security = True";
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();


                    //Define a command
                    String sql = "INSERT INTO tblEmpRegistration VALUES (@empno,@fname,@lname,@gender,@nic,@dob,@mobile,@address,@email,@username,@password,@possition)";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@empno", this.txt_empNO.Text);
                    com.Parameters.AddWithValue("@fname", this.txt_fName.Text);
                    com.Parameters.AddWithValue("@lname", this.txt_lName.Text);
                    com.Parameters.AddWithValue("@gender", gender);
                    com.Parameters.AddWithValue("@nic", this.txt_nic.Text);
                    com.Parameters.AddWithValue("@dob", this.dob.Text);
                    com.Parameters.AddWithValue("@mobile", this.txt_mobile.Text);
                    com.Parameters.AddWithValue("@address", this.txt_address.Text);
                    com.Parameters.AddWithValue("@email", this.txt_email.Text);
                    com.Parameters.AddWithValue("@username", txt_username.Text);
                    com.Parameters.AddWithValue("@password", this.txt_password.Text);
                    com.Parameters.AddWithValue("@possition", this.cmb_Possition.Text);



                    int ret = com.ExecuteNonQuery();
                    MessageBox.Show("Registration Completed:" + ret, "Information");


                    //Disconnect from the server
                    con.Close();
                   
                    refresh();
                }
            }
        }

        private void rbn_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbn_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            {
                //create a connection with mssql server
                string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();



                //Define a command
                String sql = "SELECT * FROM tblEmpRegistration  ";
                SqlCommand com = new SqlCommand(sql, con);

                //Execute command and access data using Data Adaptor method
                SqlDataAdapter dap = new SqlDataAdapter(com);
                ds = new DataSet();
                dap.Fill(ds);

                int x = ds.Tables[0].Rows.Count + 1;

                this.txt_empNO.Text = a + x.ToString();

                //Disconnect from the server
                con.Close();

               
            }
            { 
                 //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();




            //Define a command
            String sql = "SELECT * FROM tblEmpRegistration ";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@empno", this.txtsearch.Text);


                //Execute command and access data using Data Reader method
                SqlDataAdapter dap = new SqlDataAdapter(com);
                ds = new DataSet();
                dap.Fill(ds);


                this.dataGridView1.DataSource = ds.Tables[0];





                //Disconnect from the server
                con.Close();
            
            
            
            
            
            
            
            }



        }

        private void btn_search_Click(object sender, EventArgs e)


        {

            if (txtsearch.Text == "")
            {



                MessageBox.Show("Please provide EMP Number ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {




                //create a connection with mssql server
                string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();




                //Define a command
                String sql = "SELECT * FROM tblEmpRegistration WHERE empNo = @empno";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@empno", this.txtsearch.Text);


                //Execute command and access data using Data Reader method
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read() == true)

                {



                    //bind data with controls
                    this.txt_empNO.Text = dr.GetValue(0).ToString();
                    this.txt_fName.Text = dr.GetValue(1).ToString();
                    this.txt_lName.Text = dr.GetValue(2).ToString();


                    gender = dr.GetValue(3).ToString();
                    if (gender == "Male")
                    {


                        this.rbn_male.Checked = true;
                    }
                    else
                    {
                        this.rbn_female.Checked = true;
                    }

                    this.txt_nic.Text = dr.GetValue(4).ToString();
                    this.dob.Text = dr.GetValue(5).ToString();
                    this.txt_mobile.Text = dr.GetValue(6).ToString();
                    this.txt_address.Text = dr.GetValue(7).ToString();
                    this.txt_email.Text = dr.GetValue(8).ToString();
                    this.txt_username.Text = dr.GetValue(9).ToString();
                    this.cmb_Possition.Text = dr.GetValue(11).ToString();

                }
                else
                {
                    MessageBox.Show("No records found...", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




                //Disconnect from the server
                con.Close();



            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtsearch.Text == "")
            {



                MessageBox.Show("Please first Search by EMP NO ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                //create a connection with mssql server
                string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                //Define a command
                String sql = "UPDATE tblEmpRegistration SET firstName =@fname,lastName=@lname,gender=@gender,nic=@nic,dob =@dob,tp=@mobile,address=@address,email =@email,username =@username,password=@password,possition=@possition Where empNo = @empNo";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@empno", this.txt_empNO.Text);
                com.Parameters.AddWithValue("@fname", this.txt_fName.Text);
                com.Parameters.AddWithValue("@lname", this.txt_lName.Text);
                com.Parameters.AddWithValue("@gender", gender);
                com.Parameters.AddWithValue("@nic", this.txt_nic.Text);
                com.Parameters.AddWithValue("@dob", this.dob.Text);
                com.Parameters.AddWithValue("@mobile", this.txt_mobile.Text);
                com.Parameters.AddWithValue("@address", this.txt_address.Text);
                com.Parameters.AddWithValue("@email", this.txt_email.Text);
                com.Parameters.AddWithValue("@username", txt_username.Text);
                com.Parameters.AddWithValue("@password", this.txt_password.Text);
                com.Parameters.AddWithValue("@possition", this.cmb_Possition.Text);



                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Update Completed:" + ret, "Information");


                //Disconnect from the server
                con.Close();
                Clear();
                refresh();
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (txtsearch.Text == "")
            {



                MessageBox.Show("Please first Search by EMP NO ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            
                else
                {
                    try
                    {//create a connection with mssql server
                        string cs = @"Data Source = DESKTOP-KMN9R2D; 
                        Initial Catalog = ForeignAgency;
                        Integrated Security = True";
                        SqlConnection con = new SqlConnection(cs);
                        con.Open();




                        //Define a command
                        String sql = "DELETE FROM tblEmpRegistration WHERE empNo = @empno";
                        SqlCommand com = new SqlCommand(sql, con);

                        com.Parameters.AddWithValue("@empno", this.txtsearch.Text);



                        //Execute command and access data using Data Adaptor method
                        //get the confirmation from a msg box
                        string mret = MessageBox.Show("Are you sure to delete this record?", "Warning",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

                        if (mret == "Yes")
                        {
                            int ret = com.ExecuteNonQuery();
                            MessageBox.Show("No of records Deleted:" + ret, "Information");
                            refresh();


                    }



                        //Disconnect from the server
                          con.Close();
                    }

                    catch (Exception Ex)
                    {

                        MessageBox.Show(Ex.Message);


                    }

                Clear();


                 }




        }

        private void refresh()
        {

            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();




            //Define a command
            String sql = "SELECT * FROM tblEmpRegistration ";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@empno", this.txtsearch.Text);


            //Execute command and access data using Data Reader method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);


            this.dataGridView1.DataSource = ds.Tables[0];





            //Disconnect from the server
            con.Close();








        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            /////////////
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
            /////////
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txtsearch.Clear();
            this.txt_address.Clear();
            this.txt_email.Clear();
            this.txt_empNO.Clear();
            this.txt_fName.Clear();
            this.txt_lName.Clear();
            this.txt_mobile.Clear();
            this.txt_mobile.Clear();
            this.txt_nic.Clear();
            this.txt_password.Clear();
            this.txt_repassword.Clear();
            this.txt_username.Clear();
            this.cmb_Possition.Text ="";
             empnumber();






        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void empnumber()
        {

            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();



            //Define a command
            String sql = "SELECT * FROM tblEmpRegistration  ";
            SqlCommand com = new SqlCommand(sql, con);

            //Execute command and access data using Data Adaptor method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);

            int x = ds.Tables[0].Rows.Count + 1;

            this.txt_empNO.Text = a + x.ToString();

            //Disconnect from the server
            con.Close();




        }
        public void Clear()
        {
            this.txtsearch.Clear();
            this.txt_address.Clear();
            this.txt_email.Clear();
            this.txt_empNO.Clear();
            this.txt_fName.Clear();
            this.txt_lName.Clear();
            this.txt_mobile.Clear();
            this.txt_mobile.Clear();
            this.txt_nic.Clear();
            this.txt_password.Clear();
            this.txt_repassword.Clear();
            this.txt_username.Clear();
            this.cmb_Possition.Text = "";
            rbn_male.Checked = false;
            rbn_female.Checked = false;




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Possition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
