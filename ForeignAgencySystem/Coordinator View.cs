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
    public partial class Coordinator_View : Form
    {
        public Coordinator_View()
        {
            InitializeComponent();
        }

        private void btn_local_Click(object sender, EventArgs e)
        {
            Local_test_Request l1 = new Local_test_Request();
            this.Hide();
            l1.Show();
        }
    }
}
