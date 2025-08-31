using static System.Net.Mime.MediaTypeNames;

namespace JobBoard.Domain.Entities
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string ResumeText { get; set; } = string.Empty;
        public string Skills { get; set; } = string.Empty;
        public string Experience { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        public string ResumePath { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
