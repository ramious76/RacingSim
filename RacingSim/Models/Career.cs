namespace RacingSim.Models
{
    public class Career
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public DateTime CurrentYear { get; set; }
        public decimal FinanceBalance { get; set; }
        public int[] InvestorIds { get; set; }
        

        public ICollection<Investor> Investors { get; set; }

    }
}
