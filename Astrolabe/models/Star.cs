using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.Models
{
    public class Star
    {
        public string Name { get; set; }
        public int ConstellationId { get; set; }
        public double ApparentMagnitude { get; set; } // видима зоряна величина
        public double Distance { get; set; }
        public double RightAscension { get; set; } // RA, год
        public double Declination { get; set; }    // Dec, градус
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonIgnore] // ігноруємо при серіалізації, бо заповнюється у коді
        public string Constellation { get; set; } // Буде використовуватися для відображення назви сузір'я

        public override string ToString()
        {
            return Name;
        }
    }
}