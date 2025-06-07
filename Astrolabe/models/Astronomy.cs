using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Astrolabe.models
{
    public class Astronomy
    {
        public List<Star> stars = new List<Star>();
        public List<string> constellations = new List<string>();

        public void InitConstellations()
        {
            this.constellations = stars
                .Select(s => s.Constellation)
                .Distinct()
                .OrderBy(s => s)
                .ToList();
        }

        public void Fill(int len)
        {
            stars = Tests.createStars(len);
        }

        public void Serialize(string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            string json = JsonSerializer.Serialize(this.stars, options);
            File.WriteAllText(path, json);
        }

        public void Deserialize(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                this.stars = JsonSerializer.Deserialize<List<Star>>(json);
            }
            catch (Exception e)
            {
                MessageBox.Show("Помилка при завантажені файлу:\n" + e.Message);
            }
        }

    }
}
