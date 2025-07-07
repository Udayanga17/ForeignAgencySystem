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
    public partial class Managing_Clerk_View : Form
    {
        public Managing_Clerk_View()
        {
            InitializeComponent();
        }

        private void btn_visa_Click(object sender, EventArgs e)
        {
            Update_visa_Status v1 = new Update_visa_Status();
            this.Hide();
            v1.Show();
        }

        private void btn_Client_Details_Click(object sender, EventArgs e)
        {
            
        }
    }
}
