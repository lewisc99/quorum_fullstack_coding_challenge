namespace Domain.Entities
{
    public class LegislatorVote
    {
        public int LegislatorId { get; set; }
        public string LegislatorName { get; set; }
        public int SupportedBills { get; set; }
        public int OpposedBills { get; set; }
    }
}
