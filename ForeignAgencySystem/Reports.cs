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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {

            Select_Reports s1 = new Select_Reports();
            this.Hide();
            s1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report3View r3 = new Report3View();
            this.Hide();
            r3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportview4 r4 = new Reportview4();
            this.Hide();
            r4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reportview5 r5 = new Reportview5();
            this.Hide();
            r5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportView6 r6 = new ReportView6();
            this.Hide();
            r6.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            HomePage h1 = new HomePage();
            this.Hide();
            h1.Show();
        }
    }
}
