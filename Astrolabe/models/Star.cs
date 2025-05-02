using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.Models
{
    public class Star
    {
        public Star(string name) { this.Name = name; }
        public string Name { get; set; }
        public Constellation Constellation { get; set; }
        public double ApparentMagnitude { get; set; } // видима зоряна величина
        public double DistanceLightYears { get; set; }
        public SkyCoordinate Coordinates { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
