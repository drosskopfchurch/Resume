namespace Resume.UI.Models
{
    public class Employer
    {
        public Employer(){}
        public Employer(Employer employer)
        {
            Id = employer.Id;
            OriginalName = employer.OriginalName;
            NewName = employer.NewName;
            Description = employer.Description;
            StartDate = employer.StartDate;
            EndDate = employer.EndDate;
            LogoHref = employer.LogoHref;
        }
        public int Id { get; set; }
        public string OriginalName { get; set; } = String.Empty;
        public string NewName { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LogoHref { get; set; } = String.Empty;
        public ICollection<Position> Positions { get; set; } = new HashSet<Position>();
    }
}