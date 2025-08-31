using static System.Net.Mime.MediaTypeNames;

namespace JobBoard.Domain.Entities
{
    public class JobOffer
    {
        public int JobOfferId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime PublicationDate { get; set; } = DateTime.UtcNow;
        public DateTime ExpirationDate { get; set; } = DateTime.UtcNow.AddMonths(1);

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
