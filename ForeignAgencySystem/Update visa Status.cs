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
    public partial class Update_visa_Status : Form
    {
        string status;
        public Update_visa_Status()
        {
            InitializeComponent();
            this.txt_CoNumber.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (txt_welderid.Text == "" && this.txt_CoNumber.Text=="")
            {


                MessageBox.Show("All Fillds are Requards ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                String sql = "INSERT INTO tblVisaStatus VALUES (@welderNo,@status,@conumber)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@welderNo", this.txt_welderid.Text);
                com.Parameters.AddWithValue("@status", status);
                com.Parameters.AddWithValue("@conumber", this.txt_CoNumber.Text);
               




                //Execute command and access data using Data Adapter method
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records inserted:" + ret, "Information");

                //Disconnect from the server
                con.Close();
            }
        }

        private void rbn_app_CheckedChanged(object sender, EventArgs e)
        {
            status = "Approved";
            txt_CoNumber.Enabled = true;
        }

        private void rbn_rej_CheckedChanged(object sender, EventArgs e)
        {
            status = "Reject";
            txt_CoNumber.Enabled = false;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
            Initial Catalog = ForeignAgency;
            Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            //Define a command
            String sql = "UPDATE tblVisaStatus SET status=@status,conNumber=@conumber Where welderNo = @welderNo";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@welderNo", this.txt_welderid.Text);
            com.Parameters.AddWithValue("@status", status);
            com.Parameters.AddWithValue("@conumber", this.txt_CoNumber.Text);
            





            int ret = com.ExecuteNonQuery();
            MessageBox.Show("Update Completed:" + ret, "Information");


            //Disconnect from the server
            con.Close();
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
            String sql = "SELECT * FROM  tblVisaStatus tblLocalTestResults WHERE welderNo = @welderNo";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@welderNo", this.txt_searchwelder.Text);


            //Execute command and access data using Data Reader method
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)

            {



                //bind data with controls
                this.txt_welderid.Text = dr.GetValue(0).ToString();
                status = dr.GetValue(1).ToString();
                if (status == "Approved")
                {
                    rbn_app.Checked = true;

                }
                else
                {
                    rbn_rej.Checked = true;
                }

                this.txt_CoNumber.Text = dr.GetValue(2).ToString();




            }
            else
            {
                MessageBox.Show("No records found, First You have to add details!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            //Disconnect from the server
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
