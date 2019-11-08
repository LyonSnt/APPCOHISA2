using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class Login : Form
    {
        MySqlConnection conexion = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=ejemplo;UID=root;PASSWORD=;");

        BaseDeDatos bd = new BaseDeDatos();

        private string correo;
        private string Subject;
        private string Body;

        private MailMessage mail;
        private Attachment Data;


        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningesar_Click(object sender, EventArgs e)
        {
            Random rad = new Random();
            // Entre 1000 y 8988
            int aleato = rad.Next(1000, 8988);
            //  Console.WriteLine(aleato);
            if (txtusuario != null)
            {
                bool aceptado = false;
                //
                switch (txtusuario.Text.ToLower())
                {
                    case "lyon12189@gmail.com":
                        if (txtpassword.Text == "lyon")
                        {
                            aceptado = true;
                            correo = txtusuario.Text;
                            Subject = txtpassword.Text;
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

                        }
                        break;
                    case "jhonatan":
                        if (txtpassword.Text == "jhonatan")
                        {
                            aceptado = true;
                        }
                        break;
                    default:

                        aceptado = false;
                        break;
                }
                //
                // si es un usuario de los "previstos"
                // redirigirlo a la página "principal", por defecto: Default.aspx
                if (aceptado)
                {
                    // FormsAuthentication.RedirectFromLoginPage(txtusuario.Text, false);

                    Verificacion ve = new Verificacion();
                    this.Hide();
                    ve.ShowDialog();
                    this.Show();
                }
                else
                {
                    // sino.. a la de error de login
                    // Response.Redirect("Candemor.aspx");
                    MessageBox.Show("Usuario/contraseña incorrectos");
                }

            }
            else
            {
                MessageBox.Show("No se admiten campos vacios");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
