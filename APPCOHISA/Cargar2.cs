using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class Cargar2 : Form
    {

        //Instancia de la clase Leer
        Leer l = new Leer();
       // public 
            AFD matrizAFD = new AFD();
        public string respuesta;
        //Alamcena la ruta del archivo .txt
        //public string ARCHIVO = @"E:\c#\APPCOHISA\APPCOHISA\Archivos\Matriz.csv";
        public Cargar2()
        {
            InitializeComponent();
        }

        private void Cargar2_Load(object sender, EventArgs e)
        {
            cargarArchivo();


        }

        public void cargarArchivo()
        {
            try
            {
                // this.openFileDialog1.ShowDialog();

                // if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                //{
                //  ARCHIVO = this.openFileDialog1.FileName;
              //  string ARCHIVO = "Matriz.csv";
                //l.lecturaArchivo(tablaresult, ';', ARCHIVO);

//                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }


        private void btncaefar_Click(object sender, EventArgs e)
        {
            cargarArchivo();
        }



        public string cargar_archivo(string archivo)
        {
            string cad = "nooo";
            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    cad = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error. El archivo no se pudo cargar");
            }
            return cad;
        }

        public void Crearmatrizlex(string archivodevuelto)
        {
            matrizAFD.datos = archivodevuelto.Split('%');
            string[] mat = matrizAFD.datos[0].Split('\n');
            int filas = mat.Length - 1;
            string[] tokns = matrizAFD.datos[1].Split('\t');
            int col = tokns.Length;
            matrizAFD.elementos = new int[filas, col];
            int valor;
            for (int i = 0; i < filas; i++)
            {
                string[] aux = mat[i].Split('\t');
                for (int j = 0; j < col; j++)
                {
                    valor = Int32.Parse(aux[j]);
                    if (valor != 900)
                        matrizAFD.elementos[i, j] = valor;
                    this.respuesta += " " + matrizAFD.elementos[i, j] + " ";

                }
                this.respuesta += "\n";
            }
            char c;
            for (int k = 0; k < col - 1; k++)
            {
                c = char.Parse(tokns[k]);
                matrizAFD.columnas += c;
            }
           matrizAFD.columnas += '@';
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Crearmatrizlex(cargar_archivo("MatrizLexica1.txt"));
        }

        private void btnver_Click(object sender, EventArgs e)
        {
           
                MatrizAFD ver = new MatrizAFD();
                List<string> nuevaMatriz = new List<string>();
                nuevaMatriz.Add(this.respuesta);
                ver.lstMatrizAFD.Items.Add(this.respuesta + "\t\t");
                ver.ShowDialog().GetType();

          
           
        }
    }
}
   