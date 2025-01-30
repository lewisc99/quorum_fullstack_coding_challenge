using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Bill")]
        public int BillId { get; set; }

        public Bill Bill { get; set; }

        public ICollection<VoteResult> VoteResults { get; set; } = new List<VoteResult>();
    }
}
