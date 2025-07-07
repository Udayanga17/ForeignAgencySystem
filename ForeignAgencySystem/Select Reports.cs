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
    public partial class Select_Reports : Form
    {
        public Select_Reports()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage h1 = new HomePage();
            this.Hide();
            h1.Show();

        }

        private void btn_genarete_Click(object sender, EventArgs e)
        {
      
        }

        private void Select_Reports_Load(object sender, EventArgs e)
        {

            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
                    Initial Catalog = ForeignAgency;
                    Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            //Define a command
            String sql = "SELECT * FROM tblClientRegistration";
            //sql command object
            SqlCommand com = new SqlCommand(sql, con);


            //ACCESS Data
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            //create a Report object
            CrystalReport1 rpt = new CrystalReport1();
            rpt.Load(@"D:\FinalProject\New folder\ForeignAgencySystem\ForeignAgencySystem\ForeignAgencySystem\Registered Cliant.rpt");
            rpt.SetDataSource(ds.Tables[0]);

            this.crystalReportViewer2.ReportSource = rpt;

            //Disconnect from the server
            con.Close();
        }
    
    }
}
