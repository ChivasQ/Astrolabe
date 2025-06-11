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
        public double X, Y, Z;

        public Vec3d(double x, double y, double z)
        {
            this.X = x; 
            this.Y = y; 
            this.Z = z;
        }

        public static double Dot(Vec3d a, Vec3d b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
    }
}
