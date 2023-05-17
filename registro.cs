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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
           
        }


        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            // Validar que no haya campos en blanco
            if (string.IsNullOrWhiteSpace(textFullname.Text) ||

                string.IsNullOrWhiteSpace(txtEmail.Text) ||


                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar el usuario.");
                return;
            }
                try
            {
                // Establecer la conexión con la base de datos
                string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Login;Data Source=DESKTOP-SV6GQVL\SQLEXPRESS";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Crear la consulta INSERT
                string insertQuery = "INSERT INTO Users (u_fullname, u_email, u_username, u_password) VALUES (@Fullname, @Email, @Username, @Password)";
                SqlCommand command = new SqlCommand(insertQuery, connection);

                // Asignar los valores a los parámetros
                command.Parameters.AddWithValue("@Fullname", textFullname.Text);

                command.Parameters.AddWithValue("@Email", txtEmail.Text);


                command.Parameters.AddWithValue("@Username", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPass.Text);

                // Ejecutar la consulta
                command.ExecuteNonQuery();

                // Cerrar la conexión
                connection.Close();

                // Mostrar un mensaje de éxito
                MessageBox.Show("El usuario se ha registrado correctamente.");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante el proceso
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
