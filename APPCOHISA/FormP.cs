using System;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class FormP : Form
    {
        public FormP()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();
           

        }

        private void FormP_Load(object sender, EventArgs e)
        {

        }
    }


}
