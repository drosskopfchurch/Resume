using Resume.UI.Models;

namespace Resume.UI.Data
{
    public static class Employers
    {
        public static Employer TheChurch
        {
            get =>
                new Employer
                {
                    Id = 1,
                    OriginalName = "The Church of Jesus Christ of Latter-day Saints",
                    StartDate = new DateTime(2010, 6, 1),
                };
        }
        public static Employer ComplianceInformationSystems
        {
            get =>
                new Employer
                {
                    Id = 2,
                    OriginalName = "Compliance Information Systems",
                    NewName = "Form Fox, inc.",
                    StartDate = new DateTime(2005, 11, 1),
                    EndDate = new DateTime(2010, 5, 1),
                };
        }
        public static Employer PartnersInLeadership
        {
            get =>
                new Employer
                {
                    Id = 3,
                    OriginalName = "Partners In Leadership",
                    NewName = "Culture Partners",
                    StartDate = new DateTime(2003, 11, 1),
                    EndDate = new DateTime(2005, 10, 1),
                };
        }
        public static IList<Employer> All()
        {
            return typeof(Employers)
            .GetProperties()
            .Where(p =>
                        p != null &&
                        p.GetValue(null) != null &&
                        p.GetValue(null).GetType().Equals(typeof(Employer)))
                    .Select(p => (Employer)p.GetValue(null))
                    .ToList();

        }
    }

}