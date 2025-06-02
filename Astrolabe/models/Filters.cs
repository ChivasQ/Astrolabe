using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Astrolabe.models
{
    public class Filters
    {
        public static List<Star> ApplyAdvancedFilter(string input, Astronomy astronomy)
        {
            if (string.IsNullOrWhiteSpace(input))
                return astronomy.stars;

            var result = new List<Star>(astronomy.stars);

            var regex = new Regex(@"(?<field>\w+):(?<op>>=|<=|>|<|=)?(?<value>""[^""]+""|\S+)", RegexOptions.IgnoreCase);
            var matchedSpans = new List<(int Start, int Length)>();

            foreach (Match match in regex.Matches(input))
            {
                string field = match.Groups["field"].Value.ToLower();
                string op = match.Groups["op"].Value;
                string value = match.Groups["value"].Value.Trim('"');

                matchedSpans.Add((match.Index, match.Length));

                switch (field)
                {
                    case "dist":
                    case "distance":
                        if (double.TryParse(value, out double dist))
                        {
                            result = op switch
                            {
                                ">" => result.Where(s => s.DistanceLightYears > dist).ToList(),
                                "<" => result.Where(s => s.DistanceLightYears < dist).ToList(),
                                ">=" => result.Where(s => s.DistanceLightYears >= dist).ToList(),
                                "<=" => result.Where(s => s.DistanceLightYears <= dist).ToList(),
                                "=" or "" => result.Where(s => s.DistanceLightYears == dist).ToList(),
                                _ => result
                            };
                        }
                        break;

                    case "name":
                        result = result.Where(s => !string.IsNullOrEmpty(s.Name) &&
                                                   s.Name.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList();
                        break;

                    case "mag":
                    case "magnitude":
                        if (double.TryParse(value, out double mag))
                        {
                            result = op switch
                            {
                                ">" => result.Where(s => s.ApparentMagnitude > mag).ToList(),
                                "<" => result.Where(s => s.ApparentMagnitude < mag).ToList(),
                                ">=" => result.Where(s => s.ApparentMagnitude >= mag).ToList(),
                                "<=" => result.Where(s => s.ApparentMagnitude <= mag).ToList(),
                                "=" or "" => result.Where(s => s.ApparentMagnitude == mag).ToList(),
                                _ => result
                            };
                        }
                        break;

                    case "cons":
                    case "constellation":
                        result = result.Where(s => !string.IsNullOrEmpty(s.Constellation) &&
                                                   s.Constellation.Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
                        break;
                }
            }

            // обробка тексту, що не підійшов до виразу Regex, буде шукати за ім'ям 
            var usedRanges = matchedSpans.Select(s => new { Start = s.Start, End = s.Start + s.Length }).ToList();
            string remaining = input;

            foreach (var range in usedRanges.OrderByDescending(r => r.Start))
            {
                remaining = remaining.Remove(range.Start, range.End - range.Start);
            }

            var extraWords = remaining.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in extraWords)
            {
                result = result.Where(s => !string.IsNullOrEmpty(s.Name) &&
                                           s.Name.Contains(word, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return result;
        }

        public static List<Star> FindAllByName(String name, List<Star> stars)
        {
            List<Star> result = new List<Star>();
            for (int i = 0; i < stars.Count; i++)
            {
                Star st = stars[i];
                if (st.Name == null)
                {
                    continue;
                }
                if (Regex.IsMatch(st.Name, name))
                {
                    result.Add(st);
                }
            }
            return result;
        }

        public static List<Star> FindVisibleStars(List<Star> stars, double lat, double lon, DateTime time)
        {
            List<Star> result = new List<Star>();
            foreach (Star star in stars)
            {
                if (StarVisibility.IsStarVisible(star.RightAscension, star.Declination, lat, lon, time))
                {
                    result.Add(star);
                }
            }
            return result;
        }
    }
}
