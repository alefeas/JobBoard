using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<JobOffer> JobOffers { get; set; } = new List<JobOffer>();
    }
}
