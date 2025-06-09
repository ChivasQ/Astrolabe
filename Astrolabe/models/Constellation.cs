using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.models
{
    public class Constellation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return String.IsNullOrEmpty(Name) ? "empty string" : Name;
        }
    }

}
