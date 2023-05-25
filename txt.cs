using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Reproductor
{
    public partial class txt : Form
    {
        public txt()
        {
            InitializeComponent();
        }

        private void txt_Load(object sender, EventArgs e)
        {
            // Ruta del archivo de texto de canciones
            string filePath = @"C:\Users\eduar\OneDrive\Escritorio\canciones.txt"; // Reemplaza con la ruta correcta de tu archivo

            // Verifica si el archivo existe
            if (File.Exists(filePath))
            {
                // Lee el contenido del archivo de texto
                string[] canciones = File.ReadAllLines(filePath);

                // Agrega las canciones al ListBox
                listBox1.Items.AddRange(canciones);
            }
        }
    }
}
