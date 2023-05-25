using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Core.Interops;
using YoutubeExplode;
using YoutubeExplode.Videos;
using System.Web;
using System.Text.RegularExpressions;


namespace Proyecto_Reproductor
{
    public partial class youtube : Form
    {

        

        public youtube()
        {
            InitializeComponent();
        }

        private void youtube_Load(object sender, EventArgs e)
        {
            
        }
     
        private  void btnReproducir_Click(object sender, EventArgs e)
        {
            //igualamos youtubelink con lo que vayamos a escribir en el textbox
            string youtubeLink = textBox1.Text;

            if (string.IsNullOrEmpty(youtubeLink))
            {
                //hacemos una condicion de si no hay algo en el textbox, al presionar el boton nos mande un msj de advertencia
                MessageBox.Show("Por favor, ingresa un enlace de YouTube.", "Enlace vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //formato del link 
            string embedLink = "https://www.youtube.com/embed/{0}";
            //formato del webbrowser
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "</head><body>";
            html += "<iframe id='video' src='" + string.Format(embedLink, GetVideoId(youtubeLink)) + "' width='680' height='485' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            webBrowser1.DocumentText = html;
        }

        private string GetVideoId(string youtubeLink)
        {
            string videoId = string.Empty;

            Uri uri = new Uri(youtubeLink);
            string query = uri.Query;

            if (!string.IsNullOrEmpty(query))
            {
                string[] queryParts = query.Substring(1).Split('&');

                foreach (string part in queryParts)
                {
                    string[] keyValuePair = part.Split('=');
                    if (keyValuePair.Length == 2 && keyValuePair[0].ToLower() == "v")
                    {
                        videoId = keyValuePair[1];
                        break;
                    }
                }
            }
            else
            {
                string[] pathParts = uri.AbsolutePath.Split('/');
                if (pathParts.Length >= 2)
                {
                    videoId = pathParts[1];
                }
            }

            return videoId;
        }

    }
}
