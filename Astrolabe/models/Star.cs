using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.models
{
    public class Star
    {
        public string Name { get; set; }
        public string Constellation { get; set; }
        public double ApparentMagnitude { get; set; } // видима зоряна величина
        public double Distance { get; set; }
        public double RightAscension { get; set; } // RA, год
        public double Declination { get; set; }    // Dec, градус
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
