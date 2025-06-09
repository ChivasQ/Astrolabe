using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrolabe.Models
{
    /// <summary>
    /// Структура тривимірного вектору double.
    /// Використовується для простих векторних операцій у 3D-просторі.
    /// </summary>
    public struct Vec3d
    {
        public double x, y, z;

        public Vec3d(double x, double y, double z)
        {
            this.x = x; 
            this.y = y; 
            this.z = z;
        }

        public static double dot(Vec3d a, Vec3d b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
    }
}
