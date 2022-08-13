namespace RacingSim.Models
{
    public class SeriesDriver
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int SeriesTeamId { get; set; }
        public Driver Driver { get; set; }
        public SeriesTeam SeriesTeam { get; set; }
    }
}
