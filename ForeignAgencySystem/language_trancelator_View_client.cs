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
    public partial class language_trancelator_View_client : Form
    {

        String Gender;
        public language_trancelator_View_client()
        {
            InitializeComponent();
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Language_Translateor_view l1 = new Language_Translateor_view();
            this.Hide();
            l1.Show();
            
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
    }
}
