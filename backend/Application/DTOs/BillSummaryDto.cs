
namespace Application.DTOs
{
    public class BillSummaryDto
    {
        public int Id { get; set; }
        public string BillTitle { get; set; }
        public int Supporters { get; set; }
        public int Opposers { get; set; }
        public string PrimarySponsor { get; set; }
    }
}
