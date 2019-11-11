using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
             ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
         
        }

        private void btnLexico_Click(object sender, EventArgs e)
        {
            panelsubmeu.Visible = true;

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            panelsubmeu.Visible = false;
        }


        private void btnVer_Click(object sender, EventArgs e)
        {
            panelsubmeu.Visible = false;
        }

        private void btnSintactico_Click(object sender, EventArgs e)
        {
            panelsub2.Visible = true;
        }

        private void btncrear2_Click(object sender, EventArgs e)
        {
            panelsub2.Visible = false;
        }

        private void btnver2_Click(object sender, EventArgs e)
        {
            panelsub2.Visible = false;
        }
    }


}
