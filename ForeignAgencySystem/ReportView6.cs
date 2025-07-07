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
    public partial class ReportView6 : Form
    {
        public ReportView6()
        {
            InitializeComponent();
        }

        private void ReportView6_Load(object sender, EventArgs e)


        {
            //create a connection with mssql server
            string cs = @"Data Source = DESKTOP-KMN9R2D; 
                    Initial Catalog = ForeignAgency;
                    Integrated Security = True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            //Define a command
            String sql = "SELECT * FROM tblPostRecruitment";
            //sql command object
            SqlCommand com = new SqlCommand(sql, con);


            //ACCESS Data
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            //create a Report objec
            CrystalReport8 rpt = new CrystalReport8();
            rpt.Load(@"D:\FinalProject\New folder\ForeignAgencySystem\ForeignAgencySystem\ForeignAgencySystem\CrystalReport8.rpt");
            rpt.SetDataSource(ds.Tables[0]);

            this.crystalReportViewer5.ReportSource = rpt;

            //Disconnect from the server
            con.Close();
        }
    
    }
}
