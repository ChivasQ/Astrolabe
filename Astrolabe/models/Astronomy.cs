﻿using System;
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


        public List<Star> FindAll(String name) {
            List<Star> result = new List<Star>();
            for (int i = 0; i < stars.Count; i++)
            {
                Star st = stars[i];
                if (st.Name == null)
                {
                    continue;
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(st.Name, name))
                {
                    result.Add(st);
                }
            }
            return result;
        }

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
