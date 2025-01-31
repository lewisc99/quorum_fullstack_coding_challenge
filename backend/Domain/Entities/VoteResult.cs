using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class VoteResult
    {
        [Key]
        public int Id { get; set; }

        public int LegislatorId { get; set; }

        public int VoteId { get; set; }

        [Required]
        public int VoteType { get; set; }
    }
}
