using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Bill
    {
        [Key] 
        public int Id { get; set; }

        [Required] 
        public string Title { get; set; }

        public int SponsorId { get; set; }
    }
}