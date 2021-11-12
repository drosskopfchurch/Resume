namespace Resume.UI.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Proficiency { get; set; }
        public string? Description { get; set; }
        public ICollection<Skill> Skills { get; set; } = new HashSet<Skill>();
        public ICollection<Experience> Experiences { get; set; } = new HashSet<Experience>();
        public ICollection<Employer> Employers { get; set; } = new HashSet<Employer>();
        public bool ShowSkills { get; set; } = false;
    }
}