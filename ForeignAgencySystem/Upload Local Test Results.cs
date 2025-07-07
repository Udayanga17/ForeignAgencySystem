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
    public partial class Upload_Local_Test_Results : Form
    {
        public Upload_Local_Test_Results()
        {
            InitializeComponent();
            
        }

        public void Clear()
        {

            this.txt_welderID.Text = "";
            this.txt_at1.Clear();
            this.txt_at2.Clear();
            this.txt_at3.Clear();


        }

        private void btn_upload_Click(object sender, EventArgs e)
        {

            if (txt_welderID.Text == "")
            {



                MessageBox.Show("Please provide Welder ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


            else if (this.txt_at1.Text != "" && (this.txt_at2.Text != "" || txt_at3.Text != ""))
            {

              //  DateTime today = DateTime.Now;
                //String date = today.ToShortDateString();
                //   this.textBox1.Text = date;

                //create a connection with mssql server
                string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                //Define a command
                String sql = "UPDATE tblLocalTestResults SET attempt1 =@at1,attempt2=@at2,attempt3=@at3  Where welderNo = @welderNo";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@welderNo", this.txt_welderID.Text);
                com.Parameters.AddWithValue("@at1", this.txt_at1.Text);
                com.Parameters.AddWithValue("@at2", this.txt_at2.Text);
                com.Parameters.AddWithValue("@at3", this.txt_at3.Text);
              




                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Update Completed:" + ret, "Information");


                //Disconnect from the server
                con.Close();

                Clear();



            }

            else
            {
                //DateTime today = DateTime.Now;
                //String date = today.ToShortDateString();
                //   this.textBox1.Text = date;

                //create a connection with mssql server
                string cs = @"Data Source = DESKTOP-KMN9R2D; 
                    Initial Catalog = ForeignAgency;
                    Integrated Security = True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                //Define a command
                String sql = "INSERT INTO tblLocalTestResults VALUES (@welderNo,@at1,@at2,@at3)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@welderNo", this.txt_welderID.Text);
                com.Parameters.AddWithValue("@at1", this.txt_at1.Text);
                com.Parameters.AddWithValue("@at2", this.txt_at2.Text);
                com.Parameters.AddWithValue("@at3", this.txt_at3.Text);
                



                //Execute command and access data using Data Adapter method
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records inserted:" + ret, "Information");

                //Disconnect from the server
                con.Close();
                Clear();
            }
        }

        private void cb_at1_TextChanged(object sender, EventArgs e)
        {
            txt_at2.Enabled = true;

        }

        private void Upload_Local_Test_Results_Load(object sender, EventArgs e)
        {
            txt_at2.Enabled = false;
            txt_at3.Enabled = false;
            
        }

        private void txt_at2_TextChanged(object sender, EventArgs e)
        {
            txt_at3.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {



            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();




            //Define a command
            String sql = "SELECT * FROM  tblLocalTestResults WHERE welderNo = @welderNo";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@welderNo", this.txt_welderID.Text);


            //Execute command and access data using Data Reader method
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)

            {



                //bind data with controls
                this.txt_at1.Text = dr.GetValue(1).ToString();
                this.txt_at2.Text = dr.GetValue(2).ToString();
                this.txt_at3.Text = dr.GetValue(3).ToString();




            }
            else
            {
                MessageBox.Show("No records found, First You have to Register Client!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            //Disconnect from the server
            con.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txt_welderID.Text = "";
            this.txt_at1.Clear();
            this.txt_at2.Clear();
            this.txt_at3.Clear();
            txt_at2.Enabled = false;
            txt_at3.Enabled = false;


        }

        private void txt_welderID_TextChanged(object sender, EventArgs e)
        {

            if (txt_welderID.Text != "")
            {


                txt_at1.Enabled = true;


            }
            else
            {
                txt_at1.Enabled = false;


            }

        }
    }
    }
