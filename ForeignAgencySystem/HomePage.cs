using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeignAgencySystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_Emp_Registor_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }

        private void btn_Client_Registration_Click(object sender, EventArgs e)
        {
            CliantRegistration c1 = new CliantRegistration();
            this.Hide();
            c1.Show();
        }

        private void btn_jobRolls_Click(object sender, EventArgs e)
        {
            Job_Rolls j1 = new Job_Rolls();
            this.Hide();
            j1.Show();
        }

        private void btn_cliantDocuments_Click(object sender, EventArgs e)
        {
            Client_Documents c1 = new Client_Documents();
            this.Hide();
            c1.Show();
        }

        private void btn_dhlDocuments_Click(object sender, EventArgs e)
        {
            DHL d1 = new DHL();
            this.Hide();
            d1.Show();

        }

        private void welderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Post_Recuritment_issues p1 = new Post_Recuritment_issues();
            this.Hide();
            p1.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports r1 = new Reports();
            this.Hide();
            r1.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
