using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class VoteResult
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Legislator")]
        public int LegislatorId { get; set; }

        [ForeignKey("Vote")]
        public int VoteId { get; set; }

        [Required]
        public int VoteType { get; set; }

        public Legislator Legislator { get; set; }
        public Vote Vote { get; set; }
    }
}
