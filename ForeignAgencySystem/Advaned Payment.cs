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
    public partial class Advaned_Payment : Form
    {
        String att1;
        String att2;
        String att3;

        string skil = "No";
        string language = "No";
        string personality = "No";
        string method = "No";
        String outstanding = "No";
        string fulldate = "No";


        public Advaned_Payment()
        {
            InitializeComponent();
        }


        public void clear()
        {

            txt_advance.Clear();
            txt_welderId.Clear();
            cb_koreanResult.Checked = false;
            cb_skil.Checked = false;
            cb_personality.Checked = false;
            cb_language.Checked = false;

        
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
            String sql = "SELECT * FROM  tblUploadKoreanTestResult WHERE welderNo = @welderNo";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@welderNo", this.txt_welderId.Text);


            //Execute command and access data using Data Reader method
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)

            {

                att1 = dr.GetValue(1).ToString();

                att2 = dr.GetValue(2).ToString();

                att3 = dr.GetValue(3).ToString();



                if (att1 == "A" || att2 == "A" || att3 == "A")
                {
                    this.cb_koreanResult.Checked = true;



                }
                else
                {

                    MessageBox.Show("Welder has not A pass for Korean test ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
            else
            {
                MessageBox.Show("No records found !!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            //Disconnect from the server
            con.Close();

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (txt_welderId.Text == "")

            {



                MessageBox.Show("Please provide Welder ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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
                String sql = "INSERT INTO tblPayments_And_AditionalTraining VALUES (@welderNo,@skil,@language,@personality,@advance,@date,@methode,@outstanding,@fulldate)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@welderNo", this.txt_welderId.Text);
                com.Parameters.AddWithValue("@skil", skil);
                com.Parameters.AddWithValue("@language", language);
                com.Parameters.AddWithValue("@personality", personality);
                com.Parameters.AddWithValue("@advance", txt_advance.Text);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@methode", method);
                com.Parameters.AddWithValue("@outstanding", outstanding);
                com.Parameters.AddWithValue("@fulldate", fulldate);






                //Execute command and access data using Data Adapter method
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records inserted:" + ret, "Information");

                //Disconnect from the server
                con.Close();
                clear();

            }
        }

        private void cb_skil_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_skil.Checked)
            {
                skil = "Yes";
            }
            else
            {
                skil = "No";
            }

            if (cb_skil.Checked && cb_language.Checked && cb_personality.Checked)
            {

                this.txt_advance.Enabled = true;

            }
            else
            {

                this.txt_advance.Enabled = false;


            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void cb_personality_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_personality.Checked)
            {
               personality = "Yes";
            }
            else
            {
                personality = "No";
            }
            if (cb_skil.Checked && cb_language.Checked && cb_personality.Checked)
            {

                this.txt_advance.Enabled = true;

            }
            else
            {

                this.txt_advance.Enabled = false;


            }

        }

        private void Advaned_Payment_Load(object sender, EventArgs e)
        {
            cb_language.Enabled = false;
            cb_skil.Enabled = false;
            cb_personality.Enabled = false;
            txt_advance.Enabled = false;
            cb_koreanResult.Enabled = false;

            




        }

        private void cb_language_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_language.Checked)
            {
                language = "Yes";
            }
            else
            {
                language = "No";
            }
            if (cb_skil.Checked && cb_language.Checked && cb_personality.Checked)
            {

                this.txt_advance.Enabled = true;

            }
            else
            {

                this.txt_advance.Enabled = false;


            }


        }

        private void cb_koreanResult_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_koreanResult.Checked)
            {

                cb_language.Enabled = true;
                cb_skil.Enabled = true;
                cb_personality.Enabled = true;
                


            }
        }
    }


    }
