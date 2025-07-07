using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeignAgencySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {

            this.txtusername.Clear();
            this.txtpassword.Clear();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
                    Initial Catalog = ForeignAgency;
                    Integrated Security = True";
            SqlConnection conn = new SqlConnection(cs);
           

            if (this.txtusername.Text == "" || this.txtpassword.Text == "")
            {
                MessageBox.Show("All fields are required to proceed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {
                try
                {

                    conn.Open();

                    //command
                    string sql = "SELECT * FROM tblEmpRegistration WHERE username = @un AND password = @pwd";
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.Parameters.AddWithValue("@un", this.txtusername.Text);
                    com.Parameters.AddWithValue("@pwd", this.txtpassword.Text);

                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.Read() == true )
                    {
                        /*MessageBox.Show("Login Success", "Information");*/
                        if (dr.GetValue(11).ToString() == "Executive")
                        {
                            HomePage home = new HomePage();
                            home.Show();
                            this.Hide();

                        }
                        else if (dr.GetValue(11).ToString() == "Admin")
                        {
                            Admin_Home_view admin = new Admin_Home_view();
                            this.Hide();
                            admin.Show();


                        }
                      
                        else if (dr.GetValue(11).ToString() == "Office Clerk")
                        {
                            Office_Clerk_View view2 = new Office_Clerk_View();
                            this.Hide();
                            view2.Show();


                        }
                        else if (dr.GetValue(11).ToString() == "Coordinator")
                        {
                            Coordinator_View view3 = new Coordinator_View();
                            this.Hide();
                            view3.Show();


                        }
                        else if (dr.GetValue(11).ToString() == "Registration Clerk")
                        {
                            Registration_Clerk_View view4 = new Registration_Clerk_View();
                            this.Hide();
                            view4.Show();


                        }
                        else if (dr.GetValue(11).ToString() == "Training Program Coordinator")
                        {
                            Training_Program_Coordinator_View view5 = new Training_Program_Coordinator_View();
                            this.Hide();
                            view5.Show();


                        }
                        else if (dr.GetValue(11).ToString() == "Payment Clerk")
                        {
                           Payment_Clerk_View view6 = new Payment_Clerk_View();
                            this.Hide();
                            view6.Show();


                        }
                        else if (dr.GetValue(11).ToString() == "Managing Clerk")
                        {
                            Managing_Clerk_View view7 = new Managing_Clerk_View();
                            this.Hide();
                            view7.Show();


                        }
                        else if (dr.GetValue(11).ToString() == "File Handling Clerk")
                        {
                            File_Handling_Clerk_view view8 = new File_Handling_Clerk_view();
                            this.Hide();
                            view8.Show();


                        }
                        else if (dr.GetValue(11).ToString() == "Language Translator")
                        {
                            Language_Translateor_view view9 = new Language_Translateor_view();
                            this.Hide();
                            view9.Show();


                        }



                    }

                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error");
                        this.txtusername.Clear();
                        this.txtpassword.Clear();

                    }
                    //Disconnect
                    conn.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);


                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
