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
    public partial class Admin_Home_view : Form
    {
        public Admin_Home_view()
        {
            InitializeComponent();
        }

        private void btn_Emp_Registor_Click(object sender, EventArgs e)
        {
            Form1 admin = new Form1();
            this.Hide();
            admin.Show();

        }
    }
}
