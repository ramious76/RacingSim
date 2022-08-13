namespace RacingSim.Models
{
    public class RawScores
    {
        public int Id { get; set; }
        public int Place { get; set; }
        public int DriverId { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public Driver Driver { get; set; }
    }
}
