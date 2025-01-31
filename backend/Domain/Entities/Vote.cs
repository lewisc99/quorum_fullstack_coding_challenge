using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }

        public int BillId { get; set; }
    }
}
