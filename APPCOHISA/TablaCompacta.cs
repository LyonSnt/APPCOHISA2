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
    public partial class TablaCompacta : Form
    {

        Leer l = new Leer();
        public TablaCompacta()
        {
            InitializeComponent();
        }

        public void cargarArchivo()
        {
            try
            {
                // this.openFileDialog1.ShowDialog();

                // if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                //{
                //  ARCHIVO = this.openFileDialog1.FileName;
                string ARCHIVO = @"E:\c#\APPCOHISA\APPCOHISA\Archivos\Matriz.csv";
                l.lecturaArchivo(tabladatagrid, ';', ARCHIVO);

                //                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public void cargarArchivoCom()
        {
            try
            {
                // this.openFileDialog1.ShowDialog();

                // if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                //{
                //  ARCHIVO = this.openFileDialog1.FileName;
                string ARCHIVO = @"E:\c#\APPCOHISA\APPCOHISA\Archivos\tablacompacta.csv";
                l.lecturaArchivo(tablacompa3, ';', ARCHIVO);

                //                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        private void tabladatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       

        }

        private void TablaCompacta_Load(object sender, EventArgs e)
        {
            cargarArchivo();
            cargarArchivoCom();
        }
    }
}
