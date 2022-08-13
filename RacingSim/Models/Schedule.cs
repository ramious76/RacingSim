namespace RacingSim.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int RaceNumber { get; set; }
        public int TrackId { get; set; }
        public int SeriesId { get; set; }
        public Series Series { get; set; }
        public Track Tracks { get; set; }
    }
}
