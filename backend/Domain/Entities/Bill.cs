using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [ForeignKey("Sponsor")]
        public int SponsorId { get; set; }

        public Legislator Sponsor { get; set; }

        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
    }
}
