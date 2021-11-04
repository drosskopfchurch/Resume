namespace Resume.UI.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public Position Position { get; set; } = new Position();
        public ICollection<Skill> Skills { get; set; } = new HashSet<Skill>();
    }
}