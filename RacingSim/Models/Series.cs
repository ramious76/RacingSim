namespace RacingSim.Models
{
    public class Series
    {
        public int Id { get; set; }
        public int CareerId { get; set; }
        public string SeriesName { get; set; }
        public Career Career { get; set; }
    }
}
