using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
