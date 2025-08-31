namespace JobBoard.Domain.Entities
{
    public class Application
    {
        public int ApplicationId { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int JobOfferId { get; set; }
        public JobOffer JobOffer { get; set; }

        public DateTime ApplicationDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending";
    }
}
