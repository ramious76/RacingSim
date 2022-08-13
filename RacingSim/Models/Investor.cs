namespace RacingSim.Models
{
    public class Investor
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public decimal Amount { get; set; }
        public int CareerId { get; set; }
        public Career Career { get; set; }
    }
}
