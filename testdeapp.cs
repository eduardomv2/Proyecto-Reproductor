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
    public partial class testdeapp : Form
    {

        // Declaramos una lista de cadenas llamada "rutasCanciones" para almacenar las rutas de las canciones.
        private List<string> rutasCanciones;

        public testdeapp(List<string> rutasCanciones)
        {
            InitializeComponent();
            // Asignamos el valor del parámetro "rutasCanciones" a la variable de clase "rutasCanciones".
            this.rutasCanciones = rutasCanciones;
        }

        // Evento al hacer clic en el botón "button5"
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        // Evento que se dispara cuando el formulario "testdeapp" se carga
        private void testdeapp_Load(object sender, EventArgs e)
        {
            CargarRutasCancionesDesdeArchivo(); // Cargar las rutas de canciones desde un archivo
            foreach (string rutaCancion in rutasCanciones)
            {
                listBox1.Items.Add(rutaCancion); // Agregar cada ruta de canción al ListBox
            }
        }

        // Método para cargar las rutas de canciones desde un archivo
        private void CargarRutasCancionesDesdeArchivo()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Obtiene la ruta del escritorio
            string filePath = Path.Combine(desktopPath, "canciones.txt"); // Combina la ruta del escritorio con el nombre del archivo "canciones.txt"

            if (File.Exists(filePath)) // Verifica si el archivo existe
            {
                try
                {
                    List<string> rutasCanciones = File.ReadAllLines(filePath).ToList(); // Lee todas las líneas del archivo y las convierte en una lista de cadenas

                    foreach (string rutaCancion in rutasCanciones)
                    {
                        listBox1.Items.Add(rutaCancion); // Agrega cada ruta de canción al ListBox
                    }

                    // Muestra un mensaje de éxito
                    MessageBox.Show("Las rutas de canciones se han cargado correctamente desde el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error si ocurre una excepción durante la lectura del archivo
                    MessageBox.Show("Error al cargar las rutas de canciones desde el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Muestra un mensaje de error si el archivo no existe
                MessageBox.Show("El archivo de rutas de canciones no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para recibir una lista de rutas de canciones y agregarlas al ListBox
        public void RecibirRutasCanciones(List<string> rutasCanciones)
        {
            // Asignar las rutas de canciones al ListBox de destino
            foreach (string rutaCancion in rutasCanciones)
            {
                listBox1.Items.Add(rutaCancion);
            }
         
        }

        // Método para guardar las rutas de canciones en un archivo
        private void GuardarRutasCancionesEnArchivo()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// Obtiene la ruta del escritorio
            string filePath = Path.Combine(desktopPath, "canciones.txt");// Combina la ruta del escritorio con el nombre del archivo "canciones.txt"

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath)) // Crea un escritor de archivos para escribir en el archivo
                {
                    foreach (string rutaCancion in rutasCanciones) // Escribe cada ruta de canción en una nueva línea del archivo
        
                {
                        writer.WriteLine(rutaCancion);
                    }
                }

                MessageBox.Show("Las rutas de canciones se han guardado correctamente en el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar las rutas de canciones en el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Evento que se dispara cuando el formulario "testdeapp" se está cerrando
        private void testdeapp_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarRutasCancionesEnArchivo(); // Guarda las rutas de canciones en un archivo antes de cerrar el formulario
        }
                
        
    }
}
