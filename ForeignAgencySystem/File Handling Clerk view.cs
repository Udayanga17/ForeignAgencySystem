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
    public partial class File_Handling_Clerk_view : Form
    {
        public File_Handling_Clerk_view()
        {
            InitializeComponent();
        }

        private void btn_dhl_Click(object sender, EventArgs e)
        {
            DHL d1 = new DHL();
            this.Hide();
            d1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client_Documents c1 = new Client_Documents();
            this.Hide();
            c1.Show();
        }
    }
}
