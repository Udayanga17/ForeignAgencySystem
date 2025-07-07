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
    public partial class Registration_Clerk_View : Form
    {
        public Registration_Clerk_View()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UploadKoreanTestResults k1 = new UploadKoreanTestResults();
            this.Hide();
            k1.Show();
        }

        private void btn_localTest_Click(object sender, EventArgs e)
        {
            Upload_Local_Test_Results l1 = new Upload_Local_Test_Results();
            this.Hide();
            l1.Show();
        }

        private void btn_client_Registration_Click(object sender, EventArgs e)
        {
            CliantRegistration c1 = new CliantRegistration();
            this.Hide();
            c1.Show();

        }

        private void btn_welder_Registration_Click(object sender, EventArgs e)
        {
            Welder_Registration w1 = new Welder_Registration();
            this.Hide();
            w1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koreanTestRequest k1 = new koreanTestRequest();
            this.Hide();
            k1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Local_test_Request l1 = new Local_test_Request();
            this.Hide();
            l1.Show();
        }
    }
}
