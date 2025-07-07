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
    public partial class Language_Translateor_view : Form
    {
        public Language_Translateor_view()
        {
            InitializeComponent();
        }

        private void btn_Client_Details_Click(object sender, EventArgs e)
        {
            language_trancelator_View_client v1 = new language_trancelator_View_client();
            this.Hide();
            v1.Show();
        }
    }
}
