using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Reproductor
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
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
                command.ExecuteNonQuery();
            }
        }
    }
}
