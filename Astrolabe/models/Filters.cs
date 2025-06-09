using System.Text.RegularExpressions;

namespace Astrolabe.Models
{
    /// <summary>
    /// Статичний клас, який реалізує фільтри для списку зірок.
    /// Забезпечує складний пошук зірок за текстовим запитом з підтримкою різних полів та операцій порівняння,
    /// а також фільтрацію зірок за видимістю з урахуванням координат спостерігача та часу.
    /// </summary>
    public static class Filters
    {
        public static List<Star> ApplyAdvancedFilter(string input, Astronomy astronomy)
        {
            if (string.IsNullOrWhiteSpace(input))
                return astronomy.Stars;

            var result = new List<Star>(astronomy.Stars);

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
                                ">" => result.Where(s => s.Distance > dist).ToList(),
                                "<" => result.Where(s => s.Distance < dist).ToList(),
                                ">=" => result.Where(s => s.Distance >= dist).ToList(),
                                "<=" => result.Where(s => s.Distance <= dist).ToList(),
                                "=" or "" => result.Where(s => s.Distance == dist).ToList(),
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

                    case "visible":
                    case "isvisible":
                        if (bool.TryParse(value, out bool visible))
                        {
                            if(visible)
                                result = result.Where(s => s.ApparentMagnitude <= 6.5).ToList();
                            else
                                result = result.Where(s => s.ApparentMagnitude > 6.5).ToList();
                        }
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

            var extraWords = remaining.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in extraWords)
            {
                result = result.Where(s => !string.IsNullOrEmpty(s.Name) &&
                                           s.Name.Contains(word, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return result;
        }

        public static List<Star> FindVisibleStars(List<Star> stars, double lat, double lon, DateTime time)
        {
            return stars
                .Where(star => StarVisibility.IsStarVisible(star.RightAscension, star.Declination, lat, lon, time))
                .ToList();
        }
    }
}
