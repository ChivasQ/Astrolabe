using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Astrolabe.models
{
    public class Settings
    {
        public string LastOpenedFile { get; set; }
        //public string LastPickedLocation{ get; set; } 

        private static string AppDir => AppDomain.CurrentDomain.BaseDirectory;
        private static string SaveFolder => Path.Combine(AppDir, "AstrolabeSavedData");
        private static string SettingsFile => Path.Combine(SaveFolder, "settings.json");

        public static Settings Load()
        {
            if (!Directory.Exists(SaveFolder))
                Directory.CreateDirectory(SaveFolder);

            if (File.Exists(SettingsFile))
            {
                try
                {
                    string json = File.ReadAllText(SettingsFile);
                    return JsonSerializer.Deserialize<Settings>(json) ?? new Settings();
                }
                catch
                {
                    return new Settings();
                }
            }
            return new Settings();
        }

        public void Save()
        {
            if (!Directory.Exists(SaveFolder))
                Directory.CreateDirectory(SaveFolder);

            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(SettingsFile, json);
        }

        public string GetLastOpenedFileName()
        {
            return LastOpenedFile.Split("\\").Last();
        }

    }

}
