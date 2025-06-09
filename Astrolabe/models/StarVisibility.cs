namespace Astrolabe.models
{
    public static class StarVisibility
    {
        const double DEG_TO_RAD = Math.PI / 180;
        const double RAD_TO_DEG = 180 / Math.PI;

        public static bool IsStarVisible(
            double raDeg, double decDeg,
            double latitudeDeg, double longitudeDeg,
            DateTime utc
        )
        {
            // Місцевий сидеричний час
            double lst = GetLocalSiderealTime(utc, longitudeDeg);

            // RA → годинний кут (HA)
            double haDeg = (lst - raDeg + 360) % 360;

            // Перетворення кутів у радіани
            double ha = haDeg * DEG_TO_RAD;
            double dec = decDeg * DEG_TO_RAD;

            // Вектор зірки (у горизонтальній системі координат)
            // Прямокутна система: X (південь), Y (захід), Z (зеніт)
            double x = Math.Cos(dec) * Math.Cos(ha);
            double y = Math.Cos(dec) * Math.Sin(ha);
            double z = Math.Sin(dec);

            // Вектор напрямку на зірку
            Vec3d starVector = new Vec3d(x, y, z);

            // Вектор зеніту (тобто напрямок прямо вгору) для спостерігача
            double lat = latitudeDeg * DEG_TO_RAD;
            Vec3d zenithVector = new Vec3d(Math.Cos(lat), 0, Math.Sin(lat));

            // Скалярний добуток
            double dot = Vec3d.dot(starVector, zenithVector);

            return dot > 0; // якщо більше нуля - зірка над горизонтом
        }

        public static double GetLocalSiderealTime(DateTime utc, double longitude) // описаний у книзі Жана Мея "Astronomical Algorithms" повертає місцевий зоряний час у градусах
        {
            double jd = GetJulianDate(utc);
            double d = jd - 2451545.0;
            double lst = 280.46061837 + 360.98564736629 * d;
            lst = (lst + longitude) % 360;
            if (lst < 0) lst += 360;
            return lst;
        }
        public static double GetJulianDate(DateTime utc) // Алгоритм Жана Мея
        {
            int Y = utc.Year;
            int M = utc.Month;
            if (M <= 2)
            {
                Y -= 1;
                M += 12;
            }
            int A = Y / 100;
            int B = 2 - A + A / 4;
            double day = utc.Day + utc.Hour / 24.0 + utc.Minute / 1440.0 + utc.Second / 86400.0;
            return  Math.Floor(365.25 * (Y + 4716)) + 
                    Math.Floor(30.6001 * (M + 1)) + 
                    day + B - 1524.5;
        }
    }
}
