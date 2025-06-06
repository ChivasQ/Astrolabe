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
        public List<Constellation> constellations = new List<Constellation>();

        public void InitConstellations()
        {
            stars = constellations
                .Where(c => c.Stars != null)
                .SelectMany(c => c.Stars)
                .ToList();

            foreach (var constellation in constellations)
            {
                if (constellation.Stars != null)
                {
                    foreach (var star in constellation.Stars)
                    {
                        star.Constellation = constellation.Name;
                    }
                }
            }

            var groupedStars = stars.GroupBy(s => s.Constellation).ToList();
            constellations.Clear();

            foreach (var group in groupedStars)
            {
                constellations.Add(new Constellation
                {
                    Name = group.Key,
                    Description = group.Key == null ? "stars with no constellation" : null,
                    Stars = group.ToList()
                });
            }

            constellations = constellations
                .OrderBy(c => c.Name == null ? "" : c.Name)
                .ToList();
        }

        public void Fill(int len)
        {
            stars = Tests.createStars(len);
        }
    }
}
