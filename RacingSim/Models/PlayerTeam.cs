namespace RacingSim.Models
{
    public class PlayerTeam
    {
        public int Id { get; set; }
        public int TeamName { get; set; }
        public int SeriesId { get; set; }
        public int DriverId1 { get; set; } = 0;
        public int DriverId2 { get; set; } = 0;
        public int DriverId3 { get; set; } = 0;
        public int DriverId4 { get; set; } = 0;

        public Series Series { get; set; }
    }
}
