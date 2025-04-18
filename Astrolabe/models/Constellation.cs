using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.models
{
    public class Constellation
    {
        public string Name { get; set; }
        public List<Star> Stars { get; set; } = new();
    }
}
