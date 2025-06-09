namespace Astrolabe.Models
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
