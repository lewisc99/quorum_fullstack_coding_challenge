namespace Domain.Entities
{
    public class BillSummary
    {
        public int Id { get; set; }
        public string BillTitle { get; set; }
        public int Supporters { get; set; }
        public int Opposers { get; set; }
        public string PrimarySponsor { get; set; }
    }
}
