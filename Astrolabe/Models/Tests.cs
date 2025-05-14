namespace Astrolabe.models
{
    public class Tests
    {
        static string[] testnames = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum".ToLower().Split(' ');
        static Random rnd = new Random();

        static public List<Star> createStars(int len)
        {
            List<Star> result = new List<Star>();
            for (int i = 0; i < len; i++)
            {
                int n = rnd.Next(testnames.Length);
                Star star = new Star($"Star{i}: {testnames[n]}");
                star.Description = $"Description to star{i}: {testnames[n]}";
                result.Add(star);
            }
            return result;
        }
    }
}
