namespace RacingSim.Models
{
    public class SeriesTeam
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public int TeamId { get; set; }
        public bool Player { get; set; }
        public Series Series { get; set; }
        public Team Team { get; set; }
        public int SeriesPoints { get; set; }
    }
}
