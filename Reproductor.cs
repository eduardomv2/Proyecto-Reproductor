using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Reproductor
    
{
    public partial class Reproductor : Form
    {

        private DatabaseManager databaseManager;
        private string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Login;Data Source=DESKTOP-SV6GQVL\SQLEXPRESS";
        public Reproductor()
        {
            InitializeComponent();
            // Establecer la conexión con la base de datos
           
            
            databaseManager = new DatabaseManager(connectionString);
        }

        private void Reproductor_Load(object sender, EventArgs e)
        {
            lbluser.Text = Form1.userFullName;
        }

        private void imagenesPerfiles1_Click(object sender, EventArgs e)
        {

        }

        private void Reproductor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer cerrar la aplicación?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }


        public void GuardarRutaImagen(int userId, string imagePath)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Users SET u_image_path = @ImagePath WHERE u_id = @UserId";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@ImagePath", imagePath);
                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al guardar la ruta de la imagen: " + ex.Message);
                }
            }
        }

        private int ObtenerIdUsuarioActual()
        {
            // Implementa la lógica para obtener el ID del usuario actual
            // y devuelve el ID correspondiente.
            return 1;
        }
        private void imagenesPerfiles1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Title = "Seleccionar imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                imagenesPerfiles1.Image = Image.FromFile(imagePath);

                GuardarRutaImagen(ObtenerIdUsuarioActual(), imagePath);
            }
        }           
        
    }
}
