using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.Models
{
    public class Astronomy
    {
        List<Star> stars = new List<Star>();


        public List<Star> FindAll(String name) {
            List<Star> result = new List<Star>();
            for (int i = 0; i < stars.Count; i++)
            {
                Star st = stars[i];
                if (System.Text.RegularExpressions.Regex.IsMatch(st.Name, name))
                {
                    result.Add(st);
                }
            }
            return result;
        }

        public void Fill(int len)
        {
            stars = Tests.createStars(len);
        }
    }
}
