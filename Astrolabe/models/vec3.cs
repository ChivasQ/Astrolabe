using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.models
{
    public class vec3d
    {
        public double x, y, z;

        public vec3d(double x, double y, double z)
        {
            this.x = x; 
            this.y = y; 
            this.z = z;
        }

        public static double dot(vec3d a, vec3d b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
    }
}
