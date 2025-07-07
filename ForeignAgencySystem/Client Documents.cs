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
    public partial class Client_Documents : Form
    {

        DataSet ds,ds1;
        String fcaw, passport, serviceLetter;



       
        String nicCoppys = "No";
        String photo = "No";
        String forignMinistry = "No";
        String bureau = "No";
        string korianEmbussy = "No";
        String License = "No";




        public void Refresh()
        {

            //create a connection with mssql server
            string cs1 = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection conn = new SqlConnection(cs1);
            conn.Open();




            //Define a command
            String sql1 = "SELECT * FROM tblWelderRegistration WHERE welderNo = @welNo ";
            SqlCommand comm = new SqlCommand(sql1, conn);
            comm.Parameters.AddWithValue("@welNo", this.txt_search.Text);




            //Execute command and access data using Data Reader method
            SqlDataAdapter dap1 = new SqlDataAdapter(comm);
            ds1 = new DataSet();
            dap1.Fill(ds1);


            this.dataGridView1.DataSource = ds1.Tables[0];



    }
    private void btn_update_Click(object sender, EventArgs e)
        {




            if (txt_search.Text == "")
            {



                MessageBox.Show("Please  Search by Welder ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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
                String sql = "UPDATE tblWelderRegistration SET niccopys =@niccopys,photos=@photos,license =@license,bureau=@bureau,forigenMinistry=@forigenMinistry,koreanEmbassy=@koreanEmbassy  Where welderNo = @welderNo";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@welderNo", this.txt_search.Text);
                com.Parameters.AddWithValue("@niccopys", nicCoppys);
                com.Parameters.AddWithValue("@photos", photo);
                com.Parameters.AddWithValue("@license", License);
                com.Parameters.AddWithValue("@bureau", bureau);
                com.Parameters.AddWithValue("@forigenMinistry", forignMinistry);
                com.Parameters.AddWithValue("@koreanEmbassy ", korianEmbussy);



                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Update Completed:" + ret, "Information");


                //Disconnect from the server
                con.Close();
                Refresh();


              /*  cb_fcaw.Checked = false;
                cb_serviceLettter.Checked = false;
                cb_passport.Checked = false;
                cb_NicCoppys.Checked = false;
                cb_photo.Checked = false;
                cb_license.Checked = false;
                cb_bureau.Checked = false;
                cb_koreanEmbassy.Checked = false;
                cb_forignMinistry.Checked = false;*/

            }
        }

        private void cb_koreanEmbassy_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_koreanEmbassy.Checked)
            {
                korianEmbussy = "Yes";
            }
            else
            {
                korianEmbussy = "No";
            }
        }

        private void cb_forignMinistry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_forignMinistry.Checked)
            {
                 forignMinistry= "Yes";
            }
            else
            {
                forignMinistry= "No";
            }
        }

        private void cb_bureau_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_bureau.Checked)
            {
                bureau = "Yes";
            }
            else
            {
                bureau = "No";
            }
        }

        private void cb_photo_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_photo.Checked)
            {
                photo = "Yes";
            }
            else
            {
                photo = "No";
            }
        }


        private void cb_NicCoppys_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_NicCoppys.Checked)
            {
                nicCoppys = "Yes";
            }
            else
            {
                nicCoppys= "No";
            }
        }

        private void cb_license_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_license.Checked)
            {
                License = "Yes";
            }
            else
            {
                License = "No";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();



        }

        private void Client_Documents_Load(object sender, EventArgs e)
        {


         
            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();




            //Define a command
            String sql = "SELECT * FROM tblWelderRegistration ";
            SqlCommand com = new SqlCommand(sql, con);




            //Execute command and access data using Data Reader method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);


            this.dataGridView1.DataSource = ds.Tables[0];









        }

        public Client_Documents()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (txt_search.Text == "")
            {



                MessageBox.Show("Please provide Welder ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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
                String sql = "SELECT * FROM tblWelderRegistration WHERE welderNo = @welNo";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@welNo", this.txt_search.Text);


                //Execute command and access data using Data Reader method
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read() == true)

                {



                    //bind data with controls



                    //this.textBox1.Text = dr.GetValue(4).ToString();

                    fcaw = dr.GetValue(4).ToString();
                    if (fcaw == "Yes")
                    {
                        cb_fcaw.Checked = true;

                    }
                    else
                    {

                        cb_fcaw.Checked = false;
                    }

                    serviceLetter = dr.GetValue(5).ToString();
                    if (serviceLetter == "Yes")
                    {
                        cb_serviceLettter.Checked = true;

                    }
                    else
                    {

                        cb_serviceLettter.Checked = false;
                    }


                    passport = dr.GetValue(6).ToString();
                    if (passport == "Yes")
                    {
                       cb_passport.Checked = true;

                    }
                    else
                    {

                        cb_passport.Checked = false;
                    }


                    nicCoppys = dr.GetValue(7).ToString();
                    if (nicCoppys == "Yes")
                    {
                        cb_NicCoppys.Checked = true;

                    }
                    else
                    {

                        cb_NicCoppys.Checked = false;
                    }


                    photo = dr.GetValue(8).ToString();
                    if (photo == "Yes")
                    {
                        cb_photo.Checked = true;

                    }
                    else
                    {
                        cb_photo.Checked = false;
                    }


                    License = dr.GetValue(9).ToString();
                    if (License == "Yes")
                    {
                        cb_license.Checked = true;

                    }
                    else
                    {

                        cb_license.Checked = false;
                    }




                    bureau = dr.GetValue(10).ToString();
                    if (bureau == "Yes")
                    {
                        cb_bureau.Checked = true;

                    }
                    else
                    {

                        cb_bureau.Checked = false;
                    }


                    forignMinistry = dr.GetValue(11).ToString();
                    if (forignMinistry == "Yes")
                    {
                        cb_forignMinistry.Checked = true;

                    }

                    else
                    {

                        cb_forignMinistry.Checked = false;
                    }


                    korianEmbussy = dr.GetValue(12).ToString();
                    if (korianEmbussy== "Yes")
                    {
                        cb_koreanEmbassy.Checked = true;

                    }

                    else
                    {

                        cb_koreanEmbassy.Checked = false;
                    }

                    {
                        //create a connection with mssql server
                        string cs1= @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
                        SqlConnection conn = new SqlConnection(cs1);
                        conn.Open();




                        //Define a command
                        String sql1 = "SELECT * FROM tblWelderRegistration WHERE welderNo = @welNo ";
                        SqlCommand comm = new SqlCommand(sql1, conn);
                        comm.Parameters.AddWithValue("@welNo", this.txt_search.Text);




                        //Execute command and access data using Data Reader method
                        SqlDataAdapter dap1 = new SqlDataAdapter(comm);
                        ds1 = new DataSet();
                        dap1.Fill(ds1);


                        this.dataGridView1.DataSource = ds1.Tables[0];


                    }



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
    }
}
