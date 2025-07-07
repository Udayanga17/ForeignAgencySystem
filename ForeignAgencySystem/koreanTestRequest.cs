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
    public partial class koreanTestRequest : Form
    {
        DataSet ds;
        public koreanTestRequest()
        {
            InitializeComponent();
        }


        String att1 ;
        String att2 ;
        String att3 ;

        String at1 = "No";
        String at2 = "No";
        String at3 = "No";
        public void Clear()
        {
            this.cmb_available_ID.Text = "";
            txt_localResult.Text = "";
            cb_1.Checked = false;
            cb_2.Checked = false;
            cb_3.Checked = false;

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_available_ID.Text == "")
            {



                MessageBox.Show("Please provide Welder ID  ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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
                String sql = "SELECT * FROM tblLocalTestResults  WHERE welderNo = @welderNo";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@welderNo", this.cmb_available_ID.Text);


                //Execute command and access data using Data Reader method
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read() == true)

                {



                    //bind data with controls

                    att1 = dr.GetValue(1).ToString();

                    att2 = dr.GetValue(2).ToString();

                    att3 = dr.GetValue(3).ToString();



                    if (att1 == "A" || att2 == "A" || att3 == "A")
                    {
                        this.txt_localResult.Text = "A";



                    }
                    else 
                    {

                        MessageBox.Show("Welder has not A pass for Local test ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }




                }
                else
                {
                    MessageBox.Show("No records found, Welder is not Request for  1st Attempt,Plece Request your 1st Attempt !!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




                //Disconnect from the server
                con.Close();







                //create a connection with mssql server
                string cs2 = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
                SqlConnection con2 = new SqlConnection(cs2);
                con2.Open();



                //Define a command
                String sql2 = "SELECT * FROM tblKoreanTestRequest  WHERE welderNo = @welderNo";
                SqlCommand com2 = new SqlCommand(sql2, con2);

                com2.Parameters.AddWithValue("@welderNo", this.cmb_available_ID.Text);


                //Execute command and access data using Data Reader method
                SqlDataReader dr2 = com2.ExecuteReader();
                if (dr2.Read() == true)
                {

                    //bind data with controls
                    at1 = dr2.GetValue(1).ToString();

                    if (at1 == "Yes")
                    {
                        cb_1.Checked = true;

                    }
                    else
                    {

                        cb_1.Checked = false;
                    }

                    at2 = dr2.GetValue(2).ToString();

                    if (at2 == "Yes")
                    {
                        cb_2.Checked = true;

                    }
                    else
                    {

                        cb_2.Checked = false;
                    }

                    at3 = dr2.GetValue(3).ToString();

                    if (at3 == "Yes")
                    {
                        cb_3.Checked = true;

                    }
                    else
                    {

                        cb_3.Checked = false;
                    }


                    con2.Close();


                }
            /*    else
                {
                    MessageBox.Show("No records found, Welder is not Request for  1st Attempt,Plece Request your 1st Attempt !!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/


            }







            
        }

        private void koreanTestRequest_Load(object sender, EventArgs e)
        {
            cb_1.Enabled = false;
            cb_2.Enabled = false;
            cb_3.Enabled = false;
            txt_localResult.ReadOnly = true;
        }

        private void txt_localResult_TextChanged(object sender, EventArgs e)
        {
            if (txt_localResult.Text != "")
            {
                cb_1.Enabled = true;



            }
            else 
            {
                cb_1.Enabled = false;

            }

        }

        private void cb_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_1.Checked)
            {
                at1 = "Yes";
                cb_2.Enabled= true;
            }
            else
            {
                at1 = "No";
                cb_2.Checked = false;
                cb_2.Enabled = false;
            }
        }

        private void cb_2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_2.Checked)
            {
                at2 = "Yes";
                cb_3.Enabled = true;
            }
            else
            {
                at2 = "No";
                cb_3.Enabled = false;
                cb_3.Checked = false;
            }

        }

        private void cb_3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_3.Checked)
            {
                at3 = "Yes";
            }
            else
            {
                at3 = "No";
            }
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            if (txt_localResult.Text == "")
            {



                MessageBox.Show("Please provide Welder ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }



            else if (at1 == "Yes" && (at2 == "Yes" || at3 == "Yes"))
            {
                DateTime today = DateTime.Now;
                String date = today.ToShortDateString();
                //   this.textBox1.Text = date;
                //create a connection with mssql server
                string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                //Define a command
                String sql = "UPDATE tblKoreanTestRequest SET attempt1=@at1,attempt2=@at2,attempt3=@at3,date=@date  Where welderNo = @welderNo";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@welderNo", this.cmb_available_ID.Text);
                com.Parameters.AddWithValue("@at1", at1);
                com.Parameters.AddWithValue("@at2", at2);
                com.Parameters.AddWithValue("@at3", at3);
                com.Parameters.AddWithValue("@date", date);




                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Update Completed:" + ret, "Information");


                //Disconnect from the server
                con.Close();
               Clear();












            }

            else
            {
                DateTime today = DateTime.Now;
                String date = today.ToShortDateString();
                //   this.textBox1.Text = date;

                //create a connection with mssql server
                string cs = @"Data Source = DESKTOP-KMN9R2D; 
                    Initial Catalog = ForeignAgency;
                    Integrated Security = True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                //Define a command
                String sql = "INSERT INTO tblKoreanTestRequest VALUES (@welderNo,@at1,@at2,@at3,@date)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@welderNo", this.cmb_available_ID.Text);
                com.Parameters.AddWithValue("@at1", at1);
                com.Parameters.AddWithValue("@at2", at2);
                com.Parameters.AddWithValue("@at3", at3);
                com.Parameters.AddWithValue("@date", date);



                //Execute command and access data using Data Adapter method
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records inserted:" + ret, "Information");

                //Disconnect from the server
                con.Close();
                Clear();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.cmb_available_ID.Text = "";
            txt_localResult.Text = "";
            cb_1.Checked = false;
            cb_2.Checked = false;
            cb_3.Checked = false;



        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();




            //Define a command
            String sql = "SELECT welderNo FROM tblKoreanTestRequest WHERE date BETWEEN @start AND @end ";
            SqlCommand com = new SqlCommand(sql, con);



            this.dta_Start.Format = DateTimePickerFormat.Custom;
            this.dta_End.Format = DateTimePickerFormat.Custom;
            this.dta_Start.CustomFormat = "M/dd/yyyy";
            this.dta_End.CustomFormat = "M/dd/yyyy";

            com.Parameters.AddWithValue("@start", this.dta_Start.Text);
            com.Parameters.AddWithValue("@end", this.dta_End.Text);



            //Execute command and access data using Data Reader method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);
            int x = ds.Tables[0].Rows.Count;
            this.textBox2.Text = x.ToString();




            this.dataGridView1.DataSource = ds.Tables[0];





            //Disconnect from the server
            con.Close();
        }
    }
}
