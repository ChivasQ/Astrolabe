using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrolabe.Forms
{
    public partial class LocationPickerForm : Form
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double scale { get; set; }

        private bool locationSelected = false;

        public LocationPickerForm()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void LocationPickerForm_Load(object sender, EventArgs e)
        {

        }

        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async();

            webView21.WebMessageReceived += WebView_WebMessageReceived;

            string html = @"  
                               <!DOCTYPE html>  
                               <html>  
                               <head>  
                                 <meta charset='utf-8'>  
                                 <meta name='viewport' content='width=device-width, initial-scale=1.0'>  
                                 <title>Leaflet Map</title>  
                                 <link rel='stylesheet' href='https://unpkg.com/leaflet@1.7.1/dist/leaflet.css'/>  
                                 <script src='https://unpkg.com/leaflet@1.7.1/dist/leaflet.js'></script>  
                                 <style> html, body, #map { height: 100%; margin: 0; padding: 0; } </style>  
                               </head>  
                               <body>  
                                 <div id='map'></div>  
                                 <script>  
                                   var map = L.map('map').setView([50.4501, 30.5234], 10);  
                                   L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {  
                                     maxZoom: 19  
                                   }).addTo(map);  

                                   var marker = null;  

                                   map.on('click', function(e) {  
                                     if (marker) {  
                                       map.removeLayer(marker);  
                                     }  
                                     marker = L.marker(e.latlng).addTo(map);  
                                     let lat = e.latlng.lat.toFixed(6);  
                                     let lng = e.latlng.lng.toFixed(6);  
                                     let scale = map.getZoom();  
                                     window.chrome.webview.postMessage(lat + ',' + lng + ',' + scale);  
                                   });  
                                 </script>  
                               </body>  
                               </html>  
                               ";

            webView21.NavigateToString(html);
        }

        private void WebView_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string[] parts = e.TryGetWebMessageAsString().Split(',');
            if (parts.Length == 3)
            {
                locationSelected = true;
                //MessageBox.Show($"Ви Вибрали:\nШирота: {parts[0]}\nДовгота: {parts[1]}\nZoom: {parts[2]}");
                latitude = double.Parse(parts[0].Replace('.', ','));
                longitude = double.Parse(parts[1].Replace('.', ','));
                scale = double.Parse(parts[2].Replace('.', ','));
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!locationSelected)
            {
                MessageBox.Show("Будь ласка, виберіть місце на карті.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
