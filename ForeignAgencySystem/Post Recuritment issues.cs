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
    public partial class Post_Recuritment_issues : Form
    {
        public Post_Recuritment_issues()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (txtWID.Text == "" || txtIssue.Text == "" || dateTimePicker1.Text == "")
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
                    String sql = "INSERT INTO tblPostRecruitment VALUES (@welderID,@date,@issue)";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@welderID", this.txtWID.Text);
                    com.Parameters.AddWithValue("@date", this.dateTimePicker1.Text);
                    com.Parameters.AddWithValue("@issue", this.txtIssue.Text);


                    //Execute command and access data using Data Adapter method
                    int ret = com.ExecuteNonQuery();
                    MessageBox.Show("No of records:" + ret, "Information");

                    //Disconnect from the server
                    con.Close();

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }
    }
}
