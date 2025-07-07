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
    public partial class Reportview4 : Form
    {
        public Reportview4()
        {
            InitializeComponent();
        }

        private void Reportview4_Load(object sender, EventArgs e)
        {
            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
                    Initial Catalog = ForeignAgency;
                    Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            //Define a command
            String sql = "SELECT * FROM tblPayments_And_AditionalTraining";
            //sql command object
            SqlCommand com = new SqlCommand(sql, con);


            //ACCESS Data
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            //create a Report object
            CrystalReport4 rpt = new CrystalReport4();
            rpt.Load(@"D:\FinalProject\New folder\ForeignAgencySystem\ForeignAgencySystem\ForeignAgencySystem\CrystalReport4.rpt");
            rpt.SetDataSource(ds.Tables[0]);

            this.crystalReportViewer3.ReportSource = rpt;

            //Disconnect from the server
            con.Close();
        }
    }
}
