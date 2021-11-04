namespace Resume.UI.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Employer Employer { get; set; } = new Employer();
        public ICollection<Skill> Skills { get; set; } = new HashSet<Skill>();
        public ICollection<Experience> Experiences { get; set; } = new HashSet<Experience>();
    }
}