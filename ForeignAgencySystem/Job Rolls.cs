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
    public partial class Job_Rolls : Form
    {
        public Job_Rolls()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void btn_welder_Click(object sender, EventArgs e)
        {
            Welder_Registration w1 = new Welder_Registration();
            this.Hide();
            w1.Show();
        }
    }
}
