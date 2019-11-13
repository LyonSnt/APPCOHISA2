using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class Listad : Form
    {

        private string correo;
        private string Subject;
        private string Body;
        private MailMessage mail;

        BaseDeDatos bd = new BaseDeDatos();


        public Listad()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
                
        }

        private void btnbuscarr_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarbase_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rad = new Random();
            // Entre 1000 y 8988
            int aleato = rad.Next(1000, 8988);
            //  Console.WriteLine(aleato);
            string usuario = bd.selectstring("select correo from usuario where correo = '" + txtListar.Text + "'");
            string contraseña = bd.selectstring("select password from usuario where password = '" + txtresultado.Text + "'");

            if (txtListar.TextLength > 0 && txtresultado.TextLength > 0)
            {
                if (usuario == txtListar.Text && contraseña == txtresultado.Text)
                {
                    correo = txtListar.Text;
                    Subject = "APPCOHISA.SA";
                    Body = " Numero de verificación: " + aleato;

                    mail = new MailMessage();
                    mail.To.Add(new MailAddress(this.correo));
                    mail.From = new MailAddress("lyon12189@gmail.com");
                    mail.Subject = Subject;
                    mail.Body = Body;
                    mail.IsBodyHtml = false;

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    using (client)
                    {
                        client.Credentials = new System.Net.NetworkCredential("lyon12189@gmail.com", "cinthiagm31032014");
                        client.EnableSsl = true;
                        client.Send(mail);
                    }
                    //  MessageBox.Show("Mensaje enviado");

                    string agregar = "insert into verificacion values (" + 0 + ",'" + aleato + "')";
                    if (bd.executecommand(agregar))
                    {
                        MessageBox.Show("Revise su correo y valide");


                    }
                    else
                    {
                        MessageBox.Show("Error al insertar a la base de datos");
                    }

                    MessageBox.Show("enrarara");
                }
                else
                {
                    MessageBox.Show("Usuario/contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("llene todos los campos");
            }
        }

        private void Listad_Load(object sender, EventArgs e)
        {

        }
    }
}
