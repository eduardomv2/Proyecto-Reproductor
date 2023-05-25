using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Oauth2.v2;
using Google.Apis.Oauth2.v2.Data;
using Google.Apis.Auth.OAuth2.Web;
using Google.Apis.Util.Store;
using System.Threading;
using System.Diagnostics;
using Google.Apis.Services;
using YoutubeExplode.Channels;

namespace Proyecto_Reproductor
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            //Codigo para hacer el formulario del login redondo
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;
        }

        //Esto es para poder mover el formulario del login
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Sirve para que al iniciar el programa detecte la palabra "USUARIO" y la quite para poder sobreescribir
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO:")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }
        //Sirve para cuando no estamos picandole al txt salga la palabra "USUARIO:"
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO:";
                txtuser.ForeColor = Color.DimGray;
            }
        }
        //Sirve para que al iniciar el programa detecte la palabra "CONTRASEÑA" y la quite para poder sobreescribir, tambien hace que la contraseña se oculte al escribir
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "CONTRASEÑA:")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = true;
            }

        }
        //Sirve para cuando no estamos picandole al txt salga la palabra "CONTRASEÑA:"
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "CONTRASEÑA:";
                txtpassword.ForeColor = Color.DimGray;
                txtpassword.UseSystemPasswordChar = false;
            }
        }
        //es un picturebox pero le puse btn porque en si está haciendo una funcion de boton de cerrar
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //este de minimizar
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Con esto podemos mover el formulario usando el evento del mousedown
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //boton para que acceda a la base de datos en sq
        static string constr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Login;Data Source=DESKTOP-SV6GQVL\SQLEXPRESS";
        static SqlConnection con = new SqlConnection(constr);


        public static string userFullName = null;


        //public static string Username = null;
        private void btnacceder_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "select u_fullname, u_password from Users Where u_username = '" + txtuser.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    sdr.Read();

                    if (sdr["u_password"].Equals(txtpassword.Text))
                    {

                        userFullName = sdr["u_fullname"].ToString();
                        Reproductor hs = new Reproductor(usuario);                        
                        hs.Show();
                        hs.FormClosed += Logout_Click;
                        this.Hide();


                        
                        //MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpassword.Clear();
                        txtuser.Focus();



                    }

                }
                else
                {
                    MessageBox.Show("Username is Incorrect..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //Evento del formulario login. Esto para hacer el formulario con los bordes redondos
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 20; // Ajusta el valor según el radio de esquina deseado
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(rect.X + rect.Width - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(rect.X + rect.Width - borderRadius, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }


        private void Logout_Click(object sender, FormClosedEventArgs e)
        {

            txtpassword.Clear();
            txtuser.Clear();
            this.Show();
            txtuser.Focus();
        }

        private void btnlinkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear una instancia del formulario de registro
            registro registroForm = new registro();

            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de registro
            registroForm.ShowDialog();

            // Mostrar el formulario anterior después de cerrar el formulario de registro
            this.Show();
        }

    }
}
