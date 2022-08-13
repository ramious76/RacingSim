namespace RacingSim.Models
{
    public class Sponsor
    {

        public Sponsor()
        {
            MedianProfit = Median - PerRace;
            MaxProfit = Max - PerRace;
        }
        public int Id { get; set; }
        public int Level { get; set; }
        public decimal UpgradeAmount { get; set; }
        public decimal PerRace { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public int MaxSeriesLevel { get; set; }
        public decimal Median { get; set; }
        public decimal MedianProfit { get; private set; }
        public decimal MaxProfit { get; private set; }
        public int MedianRacesUntilUpgrade { get; set; }

    }
}
