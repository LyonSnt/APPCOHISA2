using System;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class FormP : Form
    {
        public FormP()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Loginn lo = new Loginn();
            this.Hide();
            lo.ShowDialog();
            this.Show();

        }

        private void FormP_Load(object sender, EventArgs e)
        {

        }
    }


}
