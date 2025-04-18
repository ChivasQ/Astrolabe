using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.models
{
    public class SkyCoordinate
    {
        public double RightAscension { get; set; } // в годинах
        public double Declination { get; set; } // в градусах (-90 - +90)
    }

}
