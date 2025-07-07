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
    public partial class Welder_Registration : Form
    {
        public Welder_Registration()
        {
            InitializeComponent();
        }
        String service,fcaw, passport= "No";
        String niccopys = "No";
        String photo = "No";
        String forignMinistry = "No";
        String bureau = "No";
        string koreanEmbassy = "No";
        String license = "No";
            DataSet ds;
        String a = "WEL";
        
        private void cb_serviceLetter_CheckedChanged(object sender, EventArgs e)
        {
           
            if (cb_serviceLetter.Checked)
            {
                service = "Yes";
            }
            else
            {
                service = "No";
            }


            if (cb_fcaw.Checked && cb_passport.Checked && cb_serviceLetter.Checked)
            {

                this.btn_Enroll.Enabled = true;

            }
            else
            {

                this.btn_Enroll.Enabled = false;


            }
        }

        private void cb_passport_CheckedChanged(object sender, EventArgs e)
        {

           

            passport = "Yes";

            if (cb_passport.Checked)
            {
                passport = "Yes";
            }
            else
            {
                passport = "No";
            }


            if (cb_fcaw.Checked && cb_passport.Checked && cb_serviceLetter.Checked)
            {

                this.btn_Enroll.Enabled = true;

            }
            else
            {

                this.btn_Enroll.Enabled = false;


            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (txt_search.Text == "")
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

                com.Parameters.AddWithValue("@cliantno", this.txt_search.Text);


                //Execute command and access data using Data Reader method
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read() == true)

                {



                    //bind data with controls
                    this.txtfirstname.Text = dr.GetValue(1).ToString();





                    this.txtNic.Text = dr.GetValue(4).ToString();


                }
                else
                {
                    MessageBox.Show("No records found, First You have to Register Client!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




                //Disconnect from the server
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Welder_Registration_Load(object sender, EventArgs e)
        {
            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();



            //Define a command
            String sql = "SELECT * FROM tblWelderRegistration  ";
            SqlCommand com = new SqlCommand(sql, con);

            //Execute command and access data using Data Adaptor method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);

            int x = ds.Tables[0].Rows.Count + 1;

            this.txtWelid.Text = a + x.ToString();

            //Disconnect from the server
            con.Close();

            this.btn_Enroll.Enabled= false;
        }

        private void btn_Enroll_Click(object sender, EventArgs e)
        {

            if (this.txtfirstname.Text != "" && this.txtNic.Text != "")
            {
                //create a connection with mssql server
                string cs = @"Data Source = DESKTOP-KMN9R2D; 
                    Initial Catalog = ForeignAgency;
                    Integrated Security = True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                //Define a command
                String sql = "INSERT INTO tblWelderRegistration VALUES (@clientNo,@welid,@firstName,@nic,@fcaw,@service,@passport,@niccopys,@photos,@license,@bureau,@forignMinistry,@koreanEmbassy)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@clientNo", this.txt_search.Text);
                com.Parameters.AddWithValue("@welid", this.txtWelid.Text);
                com.Parameters.AddWithValue("@firstName", this.txtfirstname.Text);

                com.Parameters.AddWithValue("@nic", this.txtNic.Text);
                com.Parameters.AddWithValue("@fcaw", fcaw);
                com.Parameters.AddWithValue("@service", service);
                com.Parameters.AddWithValue("@passport", passport);
                com.Parameters.AddWithValue("@niccopys", niccopys);
                com.Parameters.AddWithValue("@photos", photo);
                com.Parameters.AddWithValue("@license", license);
                com.Parameters.AddWithValue("@bureau", bureau);
                com.Parameters.AddWithValue("@forignMinistry", forignMinistry);
                com.Parameters.AddWithValue("@koreanEmbassy", koreanEmbassy);



                //Execute command and access data using Data Adapter method
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records inserted:" + ret, "Information");

                //Disconnect from the server
                con.Close();




                this.txtfirstname.Clear();
                this.txtNic.Clear();
                this.txt_search.Clear();
                this.cb_fcaw.Checked = false;
                this.cb_passport.Checked = false;
                this.cb_serviceLetter.Checked = false;

                clear();
                welInclreace();
            }

            else
            {

                MessageBox.Show("Please Search by Client Number First  ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }




        }

        public void welInclreace()
        {


            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();



            //Define a command
            String sql = "SELECT * FROM tblWelderRegistration  ";
            SqlCommand com = new SqlCommand(sql, con);

            //Execute command and access data using Data Adaptor method
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);

            int x = ds.Tables[0].Rows.Count + 1;

            this.txtWelid.Text = a + x.ToString();

            //Disconnect from the server
            con.Close();



            this.btn_Enroll.Enabled = false;


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Job_Rolls j1 = new Job_Rolls();
            this.Hide();
            j1.Show();
        }

        private void cb_fcaw_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_fcaw.Checked)
            {
                fcaw = "Yes";
            }
            else 
            {
                fcaw = "No";
            }


            if (cb_fcaw.Checked && cb_passport.Checked && cb_serviceLetter.Checked)
            {

                this.btn_Enroll.Enabled = true;

            }
            else
            {

                this.btn_Enroll.Enabled = false;


            }

        }

        public void clear()
        {

            this.txtfirstname.Clear();
            this.txtNic.Clear();
            this.txt_search.Clear();
            this.cb_fcaw.Checked = false;
            this.cb_passport.Checked = false;
            this.cb_serviceLetter.Checked = false;
            




        }


        /* private void Enrollenable()
         {
             
             if (cb_fcaw.Checked && cb_passport.Checked && cb_serviceLetter.Checked)
             {

                 this.btn_Enroll.Enabled = true;

             }




         }*/

        /*   private void CheckBox_CheckedChanged(object sender, EventArgs e)
           {
               if (this.txtfirstname.Text != "" && this.txtNic.Text != "")
               {

                   if (!cb_fcaw.Checked && !cb_passport.Checked && !cb_serviceLetter.Checked)
                   {

                       this.btn_Enroll.Enabled = false;

                   }
               }

           }*/
    }
}
