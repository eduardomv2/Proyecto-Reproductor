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
        
        private string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Login;Data Source=DESKTOP-SV6GQVL\SQLEXPRESS";
        private string nombreUsuarioActual;
        
        public Reproductor(string usuario)
        {
            InitializeComponent();
            customizeDesign();
            this.nombreUsuarioActual = usuario; 

        }




        private void customizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelReproductorSubMenu.Visible = false;
            
            //..
        }

        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelReproductorSubMenu.Visible == true)
                panelReproductorSubMenu.Visible = false;
            
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }




        }




        private void Reproductor_Load(object sender, EventArgs e)
        {
            lbluser.Text = Form1.userFullName;
            string userFullname = lbluser.Text;
            MostrarImagenPerfil(nombreUsuarioActual);

        }





        private void imagenesPerfiles1_Click(object sender, EventArgs e)
        {

        }

        private void Reproductor_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (MessageBox.Show("Estas seguro de querer cerrar la aplicación?", "Warning",
            //     MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //    this.Close();
            ////
            ////mi codigo..
            ////
            //hideSubMenu();
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer cerrar la aplicación?", "Warning",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }







        #region SubMenu
        #endregion
        private void btnmedios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildform(new artistas());
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildform(new perfil());
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReproductorSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildform(new mp3());
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildform(new mp4());
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildform(new youtube());
           
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            openChildform(new spotifytest());
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            openChildform(new spotifytest());
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildform(new youtube());
            //
            //mi codigo..
            //
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer cerrar la aplicación?", "Warning",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            //
            //mi codigo..
            //
            hideSubMenu();
        }


        private Form activeForm = null;

        private void openChildform(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(childForm);
            panelchildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public mp4 Formulariomp4 { get; set; }

        private void button19_Click(object sender, EventArgs e)
        {

            button19.SendToBack();
            //vlcControl1.Pause();
        }

        private int ObtenerIdUsuarioActual()
        {
            int idUsuario = 0;

            // Establecer la conexión con la base de datos
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Login;Data Source=DESKTOP-SV6GQVL\SQLEXPRESS";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crear y ejecutar la consulta SQL para obtener el ID del usuario
                string query = "SELECT u_id FROM Users WHERE u_username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", nombreUsuarioActual);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Verificar si se obtiene el valor del ID de usuario correctamente
                    if (!reader.IsDBNull(0))
                    {
                        idUsuario = reader.GetInt32(0);
                    }
                    else
                    {
                        Console.WriteLine("El valor del ID de usuario es nulo.");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró el usuario en la base de datos.");
                }

                reader.Close();
            }

            return idUsuario;
        }



        

        private void GuardarRutaImagenEnSQL(string rutaImagen, string nombreUsuario)
        {
            // Realizar la conexión a la base de datos y ejecutar la consulta SQL para guardar la ruta de la imagen
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string consulta = "UPDATE Users SET u_image_path = @u_image_path WHERE u_username = @u_username";
                SqlCommand command = new SqlCommand(consulta, connection);
                command.Parameters.AddWithValue("@u_image_path", rutaImagen);

                command.Parameters.AddWithValue("@u_username", nombreUsuarioActual);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        private void imagenesPerfiles1_DoubleClick_1(object sender, EventArgs e)
        {            
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de imagen|*.*";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;
                    // Ajustar la ruta de la imagen para manejar caracteres especiales y barras invertidas
                    // Codificar la ruta de la imagen


                    // Guardar la ruta de la imagen en la base de datos
                    GuardarRutaImagenEnSQL(rutaImagen, nombreUsuarioActual);

                // Mostrar la imagen en el PictureBox
                imagenesPerfiles1.Image = Image.FromFile(rutaImagen);
                }               
        }
        public void MostrarImagenPerfil(string username)
        {
            // Realizar la conexión a la base de datos y ejecutar la consulta SQL para obtener los datos de la imagen
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string consulta = "SELECT u_image_path FROM Users WHERE u_username = @u_username";
                SqlCommand command = new SqlCommand(consulta, connection);
                command.Parameters.AddWithValue("@u_username", username);

                connection.Open();
                string rutaImagen = command.ExecuteScalar()?.ToString();
                if (!string.IsNullOrEmpty(rutaImagen))
                {
                    try
                    {
                        imagenesPerfiles1.Image = Image.FromFile(rutaImagen);
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }
                }
                else
                {
                    // Ruta de la imagen predeterminada
                    string rutaImagenPredeterminada = @"C:\Users\eduar\Downloads\fotofacebook.jpg";

                    // Verificar si la imagen predeterminada existe en la ruta especificada

                    imagenesPerfiles1.Image = Image.FromFile(rutaImagenPredeterminada);


                }
            }
        }

        private void imagenesPerfiles1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void panelMediaSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelchildform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildform(new txt());
        }
    }
}
