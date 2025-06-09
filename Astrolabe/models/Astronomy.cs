using System.Text.Json;

namespace Astrolabe.Models
{
    /// <summary>
    /// Представляє астрономічну модель, що містить колекції зірок та сузір'їв.
    /// Забезпечує функціонал для отримання зірок певного сузір'я,
    /// а також серіалізації та десеріалізації даних у JSON форматі.
    /// </summary>
    public class Astronomy
    {
        public List<Star> Stars { get; set; } = new List<Star>();
        public List<Constellation> Constellations { get; set; } = new List<Constellation>();

        public Astronomy()
        {
        }

        public List<Star> GetStarsInConstellation(int constellationId)
        {
            return Stars.Where(s => s.ConstellationId == constellationId).ToList();
        }

        public void Serialize(string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            var json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(path, json);
        }

        public void Deserialize(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                Astronomy deserializedAstronomy = JsonSerializer.Deserialize<Astronomy>(json);

                if (deserializedAstronomy != null)
                {
                    Stars = deserializedAstronomy.Stars ?? new List<Star>();
                    Constellations = deserializedAstronomy.Constellations ?? new List<Constellation>();

                    foreach (var star in Stars)
                    {
                        var constellation = Constellations.FirstOrDefault(c => c.Id == star.ConstellationId);
                        if (constellation != null)
                        {
                            star.Constellation = constellation.Name;
                        }
                        else
                        {
                            star.Constellation = "Невідоме сузір'я";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не вдалося завантажити дані з файлу. Десеріалізований об'єкт Astronomy є null.", "Помилка завантаження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Помилка при завантаженні файлу:\n" + e.Message, "Загальна помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}