﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class Verificacion : Form
    {
        MySqlConnection conexion = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=ejemplo;UID=root;PASSWORD=;");

        public Verificacion()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {

            string bus = "select * from verificacion where codigoverificacion='" + txtverificar.Text + "'";
            MySqlCommand comando = new MySqlCommand(bus, conexion);
            conexion.Open();

            MySqlDataReader leeer = comando.ExecuteReader();
            if (leeer.Read() == true)
            {
                MessageBox.Show("Gracias código correcto");

                Menu me = new Menu();
                this.Hide();
                me.Show();
                this.Show();
            }
            else
            {
                MessageBox.Show("El código es incorrecto");
            }

            conexion.Close();

        }
    }
}