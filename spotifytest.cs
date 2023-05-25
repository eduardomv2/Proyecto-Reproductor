using Google.Apis.Auth.OAuth2.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Media;
//using NAudio.Wave;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Wpf;
using HtmlAgilityPack;


namespace Proyecto_Reproductor
{
    public partial class spotifytest : Form
    {
        private const string ClientId = "fa363345548b40f2ac2903983220c417"; //client id
        private const string ClientSecret = "7c551a307fe046539c1b7b759672d40d"; //client secret
        private const string RedirectUri = "http://localhost:8888/callback";


        
        public spotifytest()
        {
            InitializeComponent();
        }

        private async Task<string> GetAccessToken()
        {
            using (var client = new HttpClient())
            {
                var base64Auth = Convert.ToBase64String(
                    System.Text.Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}"));

                client.DefaultRequestHeaders.Add("Authorization", $"Basic {base64Auth}");

                var formContent = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "client_credentials")
                });

                var response = await client.PostAsync("https://accounts.spotify.com/api/token", formContent);

                var responseContent = await response.Content.ReadAsStringAsync();

                // Analizar la respuesta JSON y obtener el token de acceso
                dynamic responseData = JsonConvert.DeserializeObject(responseContent);
                string accessToken = responseData.access_token;

                return accessToken;
            }
        }

        private void spotifytest_Load(object sender, EventArgs e)
        {

        }

        private List<dynamic> searchedTracks; // Variable para almacenar los datos de las canciones
        private async void button1_Click(object sender, EventArgs e)
        {

            var accessToken = await GetAccessToken();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

                var searchQuery = txtSearch.Text;
                var apiUrl = $"https://api.spotify.com/v1/search?q={searchQuery}&type=track";

                var response = await client.GetAsync(apiUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // Analizar la respuesta JSON y utilizar los datos de Spotify según sea necesario
                dynamic searchResult = JsonConvert.DeserializeObject(responseContent);

                // Obtener los resultados de la búsqueda de canciones
                searchedTracks = searchResult.tracks.items.ToObject<List<dynamic>>();

                // Limpiar el ListBox antes de mostrar los nuevos resultados
                Canciones.Items.Clear();

                // Mostrar los resultados en el ListBox
                foreach (var track in searchedTracks)
                {
                    var name = track.name;
                    var artist = track.artists[0].name;
                    var album = track.album.name;
                    var imageUrl = track.album.images[0].url;

                    // Concatenar la información adicional al resultado principal
                    string itemText = $"{name} - {artist} - {album}";

                    // Agregar el resultado al ListBox
                    Canciones.Items.Add(itemText);
                }
            }
        }


        private void button19_Click(object sender, EventArgs e)
        {
            button19.SendToBack();

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



            Canciones.SelectedIndex = currentFileIndex; // Mueve la selección del ListBox al índice actual
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.SendToBack();
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

            Canciones.SelectedIndex = currentFileIndex; // Mueve la selección del ListBox al índice actual
        }

      

        private void button22_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void Canciones_DoubleClick(object sender, EventArgs e)
        {
           
        }

    }
}
