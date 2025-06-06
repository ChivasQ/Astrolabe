using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.models
{
    public class Constellation
    {
        public string? Name { get; set; } // null означає "без сузір'я"
        public string? Description { get; set; }
        public List<Star> Stars { get; set; } = new();

        public override string ToString()
        {
            return String.IsNullOrEmpty(Name) ? "empty string" : Name;
        }
    }

}
