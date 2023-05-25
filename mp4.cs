using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Wpf;
using TagLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing.Imaging;
using System.Net;
using Newtonsoft.Json.Linq;
using FFmpeg.AutoGen;


namespace Proyecto_Reproductor
{
    public partial class mp4 : Form
    {

       
        public mp4()
        {
            InitializeComponent();


        }

        private void mp4_Load(object sender, EventArgs e)
        {
         

            string carpeta = @"C:\Users\eduar\OneDrive\Escritorio\mp4"; // Ruta de tu carpeta que contiene los archivos MP4

            string[] archivos = Directory.GetFiles(carpeta, "*.mp4");

            foreach (string archivo in archivos)
            {
                string nombreArchivo = Path.GetFileNameWithoutExtension(archivo);
                ListBoxVideos.Items.Add(nombreArchivo);
            }
        }

        private void Videos_DoubleClick(object sender, EventArgs e)
        {
            if (ListBoxVideos.SelectedItem != null)
            {
                string nombreArchivo = ListBoxVideos.SelectedItem.ToString();
                string rutaArchivo = Path.Combine(@"C:\Users\eduar\OneDrive\Escritorio\mp4", nombreArchivo + ".mp4");
                labelNombreArchivo.Text = Path.GetFileNameWithoutExtension(rutaArchivo);
                vlcControl1.SetMedia(new FileInfo(rutaArchivo));
                vlcControl1.Play();
            }
        }


        public void vlcControl1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.SendToBack();
            vlcControl1.Pause();
        }


        private int currentFileIndex = 0;
        //siguiente
        private void button20_Click(object sender, EventArgs e)
        {

            currentFileIndex++; // incrementa el índice

            if (currentFileIndex >= ListBoxVideos.Items.Count) // si el índice supera la cantidad de archivos en el ListBox, vuelve al primer archivo
            {
                currentFileIndex = 0;
            }

            string nombreArchivo = ListBoxVideos.Items[currentFileIndex].ToString(); // obtiene el nombre del archivo correspondiente al índice actual
            string rutaArchivo = Path.Combine(@"C:\Users\eduar\OneDrive\Escritorio\mp4", nombreArchivo + ".mp4"); // construye la ruta completa del archivo
            vlcControl1.SetMedia(new FileInfo(rutaArchivo)); // establece la ruta del archivo en el control de VLC
            vlcControl1.Play(); // reproduce el archivo en el control de VLC
            labelNombreArchivo.Text = Path.GetFileNameWithoutExtension(rutaArchivo);

            ListBoxVideos.SelectedIndex = currentFileIndex; // Mueve la selección del ListBox al índice actual


        }
        //antes

        private void button18_Click(object sender, EventArgs e)
        {
            currentFileIndex--; // disminuye el índice

            if (currentFileIndex < 0) // si el índice es menor a 0, significa que estamos en el primer archivo, así que establece el índice en el último archivo en el ListBox
            {
                currentFileIndex = ListBoxVideos.Items.Count - 1;
            }

            string nombreArchivo = ListBoxVideos.Items[currentFileIndex].ToString(); // obtiene el nombre del archivo correspondiente al índice actual
            string rutaArchivo = Path.Combine(@"C:\Users\eduar\OneDrive\Escritorio\mp4", nombreArchivo + ".mp4"); // construye la ruta completa del archivo
            vlcControl1.SetMedia(new FileInfo(rutaArchivo)); // establece la ruta del archivo en el control de VLC
            vlcControl1.Play(); // reproduce el archivo en el control de VLC
            labelNombreArchivo.Text = Path.GetFileNameWithoutExtension(rutaArchivo);

            ListBoxVideos.SelectedIndex = currentFileIndex; // Mueve la selección del ListBox al índice actual
        }


        private void ReproducirArchivoSeleccionado()
        {

        }


        private void button24_Click(object sender, EventArgs e)
        {
            button24.SendToBack();
            vlcControl1.Play();
        }




        private void macTrackBar2_ValueChanged(object sender, decimal value)
        {
            vlcControl1.Audio.Volume = macTrackBar2.Value * 10;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //// Verifica que se haya seleccionado un archivo MP4 del ListBox
            //if (ListBoxVideos.SelectedItem != null)
            //{
            //    // Obtiene la ruta del archivo seleccionado
            //    string filePath = ListBoxVideos.SelectedItem.ToString();

            //    // Extrae el nombre de la canción sin la extensión
            //    string songName = Path.GetFileNameWithoutExtension(filePath);

            //    // Realiza la solicitud a la API de Last.fm para obtener la letra de la canción
            //    string apiKey = "faff6132ec2bd3a3cd419272de9bae9c"; // Reemplaza con tu clave de API
            //    string apiUrl = $"http://api.lyrics.ovh/v1/{songName}";

            //    using (WebClient client = new WebClient())
            //    {
            //        try
            //        {
            //            string response = client.DownloadString(apiUrl);
            //            JObject json = JObject.Parse(response);

            //            // Verifica si se encontró la letra de la canción
            //            if (json.ContainsKey("lyrics"))
            //            {
            //                string lyrics = json["lyrics"].ToString();

            //                // Muestra la letra de la canción en un cuadro de mensaje
            //                MessageBox.Show(lyrics, "Letra de la canción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                MessageBox.Show("No se encontró la letra de la canción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        catch (WebException ex)
            //        {
            //            MessageBox.Show("Error al obtener la letra de la canción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No se ha seleccionado un archivo MP4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        public void MostrarLetraMP4(string rutaArchivo)
        {
           
        }

        private void button23_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panelPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            if (vlcControl1.GetCurrentMedia() != null)
            {
                // Calcula la posición en base al valor del control MacTrackBar
                float position = (float)macTrackBar1.Value / macTrackBar1.Maximum;

                // Establece la posición del video en VLCControl
                vlcControl1.Position = position;
            }
        }

        private void vlcControl1_PositionChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs e)
        {
            // Calcula el valor del control MacTrackBar en base a la posición del video
            int trackBarValue = (int)(e.NewPosition * macTrackBar1.Maximum);

            // Actualiza la posición del control MacTrackBar
            macTrackBar1.Value = trackBarValue;

            // Habilita o deshabilita el temporizador según el estado de reproducción del video
            timer1.Enabled = vlcControl1.GetCurrentMedia() != null && vlcControl1.IsPlaying;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vlcControl1.GetCurrentMedia() != null && vlcControl1.IsPlaying)
            {
                // Obtiene la posición actual del video
                float currentPosition = vlcControl1.GetCurrentMedia().Duration.Ticks * vlcControl1.Position;

                // Obtiene la duración total del video
                float totalDuration = vlcControl1.GetCurrentMedia().Duration.Ticks;

                // Calcula el valor del control MacTrackBar en base a la posición actual del video y la duración total
                int trackBarValue = (int)(currentPosition / totalDuration * macTrackBar1.Maximum);

                // Actualiza la posición del control MacTrackBar
                macTrackBar1.Value = trackBarValue;
            }
        }
    }
}
