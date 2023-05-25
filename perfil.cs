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
using System.IO;

namespace Proyecto_Reproductor
{
    public partial class perfil : Form
    {
        public perfil()
        {
            InitializeComponent();
        }

        private void perfil_Load(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Login;Data Source=DESKTOP-SV6GQVL\SQLEXPRESS";

            // Consulta SQL para obtener los datos de la tabla
            string sqlQuery = "SELECT u_fullname, u_email, u_password, u_username, u_image_path FROM Users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Obtener los valores de las columnas
                        string fullName = reader["u_fullname"].ToString();
                        string email = reader["u_email"].ToString();
                        string password = reader["u_password"].ToString();
                        string username = reader["u_username"].ToString();
                        string imagePath = reader["u_image_path"].ToString();

                        // Mostrar los valores en las etiquetas
                        label1.Text = fullName;
                        label2.Text = email;
                        label3.Text = password;
                        label4.Text = username;

                        // Mostrar la imagen en el PictureBox
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            imagenesPerfiles1.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            // Mostrar una imagen de reemplazo si la ruta no es válida o está vacía
                            imagenesPerfiles1.Image = Image.FromFile("ruta_imagen_reemplazo.jpg");
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}


