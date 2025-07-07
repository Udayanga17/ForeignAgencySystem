using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ForeignAgencySystem
{
    public partial class CliantRegistration : Form
    {
        DataSet ds;
        public CliantRegistration()
        {
            InitializeComponent();
        }
        String Gender;


        public void clear()
        {
            this.txtClientNo.Clear();
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            radioFemale.Checked = false;
            radioMale.Checked = false;
            this.txtNIC.Clear();
            this.txtTel.Clear();
            this.txtAddress.Clear();
            this.txtEmail.Clear();
            this.txtsearch.Clear();


        }

        private void CliantRegistration_Load(object sender, EventArgs e)
        {
            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();




            //Define a command
            String sql = "SELECT * FROM tblClientRegistration ";
            SqlCommand com = new SqlCommand(sql, con);

          


            //Execute command and access data using Data Reader method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);


            this.dataGridView1.DataSource = ds.Tables[0];





            //Disconnect from the server
            con.Close();
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtClientNo.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || Gender == "" || txtNIC.Text == "" || txtTel.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("All fields are required to proceed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {

                    //create a connection with mssql server
                    string cs = @"Data Source = DESKTOP-KMN9R2D; 
                    Initial Catalog = ForeignAgency;
                    Integrated Security = True";
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();


                    //Define a command
                    String sql = "INSERT INTO tblClientRegistration VALUES (@clientNo,@firstName,@lastName,@gender,@nic,@tp,@address,@email,@dob)";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@clientNo", this.txtClientNo.Text);
                    com.Parameters.AddWithValue("@firstName", this.txtFirstName.Text);
                    com.Parameters.AddWithValue("@lastName", this.txtLastName.Text);
                    com.Parameters.AddWithValue("@gender", Gender);
                    com.Parameters.AddWithValue("@nic", this.txtNIC.Text);
                    com.Parameters.AddWithValue("@tp", this.txtTel.Text);
                    com.Parameters.AddWithValue("@address", this.txtAddress.Text);
                    com.Parameters.AddWithValue("@email", this.txtEmail.Text);
                    com.Parameters.AddWithValue("@dob", this.dateTimePicker1.Text);


                    //Execute command and access data using Data Adapter method
                    int ret = com.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information");

                    //Disconnect from the server
                    con.Close();
                    clear();
                    refresh();

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            this.txtClientNo.Clear();
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            radioFemale.Checked = false;
            radioMale.Checked = false;
            this.txtNIC.Clear();
            this.txtTel.Clear();
            this.txtAddress.Clear();
            this.txtEmail.Clear();
            this.txtsearch.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /////////////
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
            /////////
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            HomePage h1 = new HomePage();
            this.Hide();
            h1.Show();

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
                String sql = "SELECT * FROM tblClientRegistration WHERE cliantNo = @cliantno";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@cliantno", this.txtsearch.Text);


                //Execute command and access data using Data Reader method
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read() == true)

                {



                    //bind data with controls
                    this.txtClientNo.Text = dr.GetValue(0).ToString();
                    this.txtFirstName.Text = dr.GetValue(1).ToString();
                    this.txtLastName.Text = dr.GetValue(2).ToString();


                    Gender = dr.GetValue(3).ToString();
                    if (Gender == "Male")
                    {


                        this.radioMale.Checked = true;
                    }
                    else
                    {
                        this.radioFemale.Checked = true;
                    }

                    this.txtNIC.Text = dr.GetValue(4).ToString();
                    this.txtTel.Text = dr.GetValue(5).ToString();
                    this.txtAddress.Text = dr.GetValue(6).ToString();

                    this.txtEmail.Text = dr.GetValue(7).ToString();
                    this.dateTimePicker1.Text = dr.GetValue(8).ToString();

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

        private void btn_Update_Click(object sender, EventArgs e)
        {


            if (txtsearch.Text == "")
            {



                MessageBox.Show("Please First Search by client Number ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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
                String sql = "UPDATE tblClientRegistration SET firstName =@firstname,lastName=@lastname,gender=@gender,nic=@nic,tp=@tp,address=@address,email =@email,dob =@dob   Where cliantNo = @clientno";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@clientno", this.txtClientNo.Text);
                com.Parameters.AddWithValue("@firstName", this.txtFirstName.Text);
                com.Parameters.AddWithValue("@lastName", this.txtLastName.Text);
                com.Parameters.AddWithValue("@gender", Gender);
                com.Parameters.AddWithValue("@nic", this.txtNIC.Text);
                com.Parameters.AddWithValue("@tp", this.txtTel.Text);
                com.Parameters.AddWithValue("@address", this.txtAddress.Text);
                com.Parameters.AddWithValue("@email", this.txtEmail.Text);
                com.Parameters.AddWithValue("@dob", this.dateTimePicker1.Text);



                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Update Completed:" + ret, "Information");


                //Disconnect from the server
                con.Close();
                clear();
                refresh();
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
            String sql = "SELECT * FROM tblClientRegistration";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@cliantNo", this.txtsearch.Text);


            //Execute command and access data using Data Reader method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);


            this.dataGridView1.DataSource = ds.Tables[0];





            //Disconnect from the server
            con.Close();








        }

        private void btn_Delete_Click(object sender, EventArgs e)
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
                    String sql = "DELETE FROM tblClientRegistration WHERE cliantNo = @cliantno";
                    SqlCommand com = new SqlCommand(sql, con);

                    com.Parameters.AddWithValue("@cliantno", this.txtsearch.Text);



                    //Execute command and access data using Data Adaptor method
                    //get the confirmation from a msg box
                    string mret = MessageBox.Show("Are you sure to delete this record?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

                    if (mret == "Yes")
                    {
                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show("No of records Deleted:" + ret, "Information");
                        refresh();
                        clear();


                    }



                    //Disconnect from the server
                    con.Close();
                    
                }

                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);


                }



            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
