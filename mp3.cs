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
using Vlc.DotNet.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Vlc.DotNet.Wpf;


namespace Proyecto_Reproductor
{
    
    public partial class mp3 : Form
    {

       
        public mp3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Canciones.SelectedItem != null)
            {
                string selectedFilePath = Canciones.SelectedItem.ToString();
                string selectedFileName = Path.GetFileName(selectedFilePath);
                string firstPart = GetFirstPart(selectedFileName);
                string secondPart = GetSecondPart(selectedFileName);
                label1.Text = firstPart;
                label2.Text = secondPart;
            }
        }
        private string GetFirstPart(string fileName)
        {
            const string Dash = "-";
            int dashIndex = fileName.IndexOf(Dash);
            if (dashIndex >= 0)
            {
                string firstPart = fileName.Substring(0, dashIndex).Trim();
                return firstPart;
            }
            else
            {
                return string.Empty;
            }
        }
        private string GetSecondPart(string fileName)
        {
            const string Dash = "-";
            int dashIndex = fileName.IndexOf(Dash);
            if (dashIndex >= 0 && dashIndex < fileName.Length - 1)
            {
                string secondPart = fileName.Substring(dashIndex + 1).Trim();
                return secondPart;
            }
            else
            {
                return string.Empty;
            }
        }

        private Dictionary<string, string> artistImages = new Dictionary<string, string>();
        private void mp3_Load(object sender, EventArgs e)
        {
            artistImages.Add("Shawn Mendes", @"C:\Users\eduar\Downloads\shawn.jpg");
            artistImages.Add("Imagine Dragons", @"C:\Users\eduar\Downloads\imgdr.jpg"); 
            artistImages.Add("Hozier", @"C:\Users\eduar\Downloads\Hozier.jpg");
            artistImages.Add("Paulo Londra" , @"C:\Users\eduar\Downloads\pl.jpg");
            artistImages.Add("Julia Michaels", @"C:\Users\eduar\Downloads\jm.jpg");
            artistImages.Add("Ed Sheeran", @"C:\Users\eduar\Downloads\si es ed.jpg");

            vlcControl.Audio.Volume = 50; // Establecer el volumen inicial
            string carpeta = @"C:\Users\eduar\OneDrive\Escritorio\mp3"; // Ruta de tu carpeta que contiene los archivos MP3

            // Obtén la lista de archivos MP3 de la carpeta
            string[] archivos = Directory.GetFiles(carpeta, "*.mp3");

            // Agrega solo los nombres de los archivos al ListBox sin la extensión
            foreach (string archivo in archivos)
            {
                string nombreArchivo = Path.GetFileNameWithoutExtension(archivo);
               Canciones.Items.Add(nombreArchivo);
            }         
           
        }

        


        private void Canciones_DoubleClick(object sender, EventArgs e)
        {
          
            if (Canciones.SelectedItem != null)
            {
                if (Canciones.SelectedItem != null)
                {
                    string nombreArtista = GetSecondPart(Canciones.SelectedItem.ToString());
                    MostrarImagenArtista(nombreArtista);

                    string nombreArchivo = Canciones.SelectedItem.ToString();
                    string rutaArchivo = Path.Combine(@"C:\Users\eduar\OneDrive\Escritorio\mp3", nombreArchivo + ".mp3");
                    label1.Text = Path.GetFileNameWithoutExtension(rutaArchivo);
                    vlcControl.Stop(); // Detener la reproducción actual antes de cargar el nuevo archivo
                    vlcControl.SetMedia(new FileInfo(rutaArchivo));
                    vlcControl.Play();
                }
            }
        }
        private string GetTruncatedFileName(string fileName)
        {
            const string Dash = "-";
            int dashIndex = fileName.IndexOf(Dash);
            if (dashIndex >= 0)
            {
                string truncatedFileName = fileName.Substring(0, dashIndex);
                return truncatedFileName;
            }
            else
            {
                return fileName;
            }
        }
       
        private void button19_Click(object sender, EventArgs e)
        {
            button19.SendToBack();
            vlcControl.Pause();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            currentFileIndex--; // disminuye el índice

            if (currentFileIndex < 0) // si el índice es menor a 0, significa que estamos en el primer archivo, así que establece el índice en el último archivo en el ListBox
            {
                currentFileIndex = Canciones.Items.Count - 1;
            }

            string nombreArchivo = Canciones.Items[currentFileIndex].ToString(); // obtiene el nombre del archivo correspondiente al índice actual
            string rutaArchivo = Path.Combine(@"C:\Users\eduar\OneDrive\Escritorio\mp3", nombreArchivo + ".mp3"); // construye la ruta completa del archivo
            vlcControl.SetMedia(new FileInfo(rutaArchivo)); // establece la ruta del archivo en el control de VLC
            vlcControl.Play(); // reproduce el archivo en el control de VLC
            string nombreArtista = GetSecondPart(Canciones.Items[currentFileIndex].ToString());
            MostrarImagenArtista(nombreArtista);

            Canciones.SelectedIndex = currentFileIndex; // Mueve la selección del ListBox al índice actual
          
        }

        private int currentFileIndex = 0;
        private void button20_Click(object sender, EventArgs e)
        {
            currentFileIndex++; // incrementa el índice

            if (currentFileIndex >= Canciones.Items.Count) // si el índice supera la cantidad de archivos en el ListBox, vuelve al primer archivo
            {
                currentFileIndex = 0;
            }

            string nombreArchivo = Canciones.Items[currentFileIndex].ToString(); // obtiene el nombre del archivo correspondiente al índice actual
            string rutaArchivo = Path.Combine(@"C:\Users\eduar\OneDrive\Escritorio\mp3", nombreArchivo + ".mp3"); // construye la ruta completa del archivo
            vlcControl.SetMedia(new FileInfo(rutaArchivo)); // establece la ruta del archivo en el control de VLC
            vlcControl.Play(); // reproduce el archivo en el control de VLC
            string nombreArtista = GetSecondPart(Canciones.Items[currentFileIndex].ToString());
            MostrarImagenArtista(nombreArtista);

            Canciones.SelectedIndex = currentFileIndex; // Mueve la selección del ListBox al índice actual
         
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.SendToBack();
            vlcControl.Play();
        }

        private void macTrackBar2_ValueChanged(object sender, decimal value)
        {
            vlcControl.Audio.Volume = 50; // Establecer el volumen inicial
            vlcControl.Audio.Volume = macTrackBar2.Value * 10;
        }

       
       

        private async Task<string> ObtenerLetraDesdeJson(string json)
        {
            dynamic response = await Task.Run(() => JsonConvert.DeserializeObject(json));
            string letra = response.message.body.lyrics.lyrics_body;
            return letra;
        }

        private async Task<string> BuscarLetraCancion(string artistName, string trackName)
        {
            try
            {
                string apiKey = "afa99817e0dd31c785ba4d712401c631"; // Reemplaza "tu_clave_de_API" con tu clave de API de Musixmatch
                string url = $"https://api.musixmatch.com/ws/1.1/matcher.lyrics.get?apikey={apiKey}&q_track={Uri.EscapeDataString(trackName)}&q_artist={Uri.EscapeDataString(artistName)}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        string letraCancion = await ObtenerLetraDesdeJson(json);
                        return letraCancion;
                    }
                    else
                    {
                        return "Error al obtener la letra de la canción.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al obtener la letra de la canción: {ex.Message}";
            }
        }

        private async void button22_Click(object sender, EventArgs e)
        {        
            string artistName = label2.Text;
            string trackName = label1.Text;

            string letraCancion = await BuscarLetraCancion(artistName, trackName);
            richTextBox1.Text = letraCancion;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            if (vlcControl.GetCurrentMedia() != null)
            {
                // Calcula la posición en base al valor del control MacTrackBar
                float position = (float)macTrackBar1.Value / macTrackBar1.Maximum;

                // Establece la posición del video en VLCControl
                vlcControl.Position = position;
            }
        }

        private void vlcControl_PositionChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs e)
        {
            // Calcula el valor del control MacTrackBar en base a la posición del video
            int trackBarValue = (int)(e.NewPosition * macTrackBar1.Maximum);

            // Actualiza la posición del control MacTrackBar
            macTrackBar1.Value = trackBarValue;
        }


        // Declarar una lista para almacenar las rutas de las canciones
        private List<string> rutasCanciones = new List<string>();
        private void button21_Click(object sender, EventArgs e)
        {
            string rutaCancion = Canciones.SelectedItem.ToString();
            rutasCanciones.Add(rutaCancion);
        }

        private void btnVerCanciones_Click(object sender, EventArgs e)
        {
            testdeapp formularioDestino = new testdeapp(rutasCanciones);
            formularioDestino.Show();
        }

        

       
        private void MostrarImagenArtista(string nombreArtista)
        {
            if (artistImages.ContainsKey(nombreArtista))
            {
                string rutaImagen = artistImages[nombreArtista];
                pictureBox3.Image = Image.FromFile(rutaImagen);
            }
            else
            {
                // No se encontró una imagen para el artista, puedes mostrar una imagen predeterminada o hacer algo más
                pictureBox3.Image = null; // Borra la imagen del PictureBox si no hay una imagen disponible para el artista
            }
        }

        private void vlcControl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
