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

   
    public partial class DHL : Form
    {
        String StatusSend = "No";
        String StatusReceived= "No";
      

        DataSet ds,ds1,ds2;
        public DHL()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_send.Checked)
            {
                StatusSend = "Yes";
            }
            else
            {

                StatusSend = "No";

            }
        }

        private void Received_CheckedChanged(object sender, EventArgs e)
        {
            if (Received.Checked)
            {
                StatusReceived = "Yes";
            }
            else 
            {
                StatusReceived = "No";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (txt_welid.Text == "")
            {

                MessageBox.Show("Please enter WeldetID first ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



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
                String sql = "INSERT INTO tblDHL VALUES (@welid,@send,@received)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@welid", this.txt_welid.Text);
                com.Parameters.AddWithValue("@send", StatusSend);
                com.Parameters.AddWithValue("@received", StatusReceived);


                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Add Completed:" + ret, "Information");


                //Disconnect from the server
                con.Close();
                Refresh();
                Clear();
            }
          
           
        }

        private void DHL_Load(object sender, EventArgs e)
        {

            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();




            //Define a command
            String sql = "SELECT * FROM tblDHL ";
            SqlCommand com = new SqlCommand(sql, con);




            //Execute command and access data using Data Reader method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);


            this.dataGridView1.DataSource = ds.Tables[0];


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (this.txtsearch.Text != "")
            {


                //create a connection with mssql server
                string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                //Define a command
                String sql = "UPDATE tblDHL SET  send=@send,received=@received WHERE welid = @welid";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@welid",this.txt_welid.Text );
                com.Parameters.AddWithValue("@send", StatusSend);
                com.Parameters.AddWithValue("@received", StatusReceived);



                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Update Completed:" + ret, "Information");


                //Disconnect from the server
                con.Close();
            }
            else
            {

                MessageBox.Show("Please  Search by Welder ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            Refresh();
            Clear();
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (this.txtsearch.Text !="")
            {

                //create a connection with mssql server
                string cs1 = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
                SqlConnection conn = new SqlConnection(cs1);
                conn.Open();




                //Define a command
                String sql1 = "SELECT * FROM tblDHL WHERE welid = @welid ";
                SqlCommand comm = new SqlCommand(sql1, conn);
                comm.Parameters.AddWithValue("@welid", this.txtsearch.Text);




                //Execute command and access data using Data Reader method
                SqlDataAdapter dap1 = new SqlDataAdapter(comm);
                ds1 = new DataSet();
                dap1.Fill(ds1);

                this.txt_welid.Text = ds1.Tables[0].Rows[0][0].ToString();



                String send = ds1.Tables[0].Rows[0][1].ToString();

                if (send == "Yes")
                {
                    cb_send.Checked = true;
                    
                 }
                else
                {
                    cb_send.Checked = false;
                }

                String received = ds1.Tables[0].Rows[0][2].ToString();

                if (received == "Yes")
                {
                   Received.Checked = true;

                }
                else
                {
                   Received.Checked= false;
                }



                this.dataGridView1.DataSource = ds1.Tables[0];


                //Disconnect from the server
                conn.Close();
            }
            else
            {


                MessageBox.Show("Please  Enter Welder ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }


        public void Refresh()
        {
            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();




            //Define a command
            String sql = "SELECT * FROM tblDHL WHERE welid = @welid ";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@welid", this.txt_welid.Text);




            //Execute command and access data using Data Reader method
            SqlDataAdapter dap = new SqlDataAdapter(comm);
            ds = new DataSet();
            dap.Fill(ds);


            
          



            this.dataGridView1.DataSource = ds.Tables[0];


            //Disconnect from the server
            conn.Close();






        }

        public void Clear()
        {

            this.txtsearch.Clear();
            this.txt_welid.Clear();
            cb_send.Checked = false;
            Received.Checked = false;
        
        
        
        
        
        }







    
    }
}
