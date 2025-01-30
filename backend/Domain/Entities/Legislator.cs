using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Legislator
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<VoteResult> VoteResults { get; set; } = new List<VoteResult>();
    }
}
