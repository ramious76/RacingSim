namespace RacingSim.Models
{
    public class RaceResults
    {
        public int Id { get; set; }
        public int Series { get; set; }
        public int DriverId { get; set; }
        public int RaceId { get; set; }
        public int Finish { get; set; }
    }
}

